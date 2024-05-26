using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Entities.Abstract;
using System.Linq.Expressions;

namespace ShopECommerce.Data.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : BaseEntity
    {
        private readonly ShopECommerceContext _db;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ShopECommerceContext context)
        {
            _db = context;
            _dbSet = _db.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.IsDeleted = false;
            entity.Status = true;
            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateAsync(T entity)
        {
            entity.ModifiedDate = DateTime.Now;
            entity.CreatedDate = await _dbSet.AsNoTracking()
                .Where(e => e.Id == entity.Id)
                .Select(e => (DateTime?)e.CreatedDate)
                .FirstOrDefaultAsync() ?? DateTime.Now;

            entity.Status = await _dbSet.AsNoTracking()
                .Where(e => e.Id == entity.Id)
                .Select(e => (bool?)e.Status)
                .FirstOrDefaultAsync() ?? true;

            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            entity.IsDeleted = true;
            entity.Status = false;
            entity.ModifiedDate = DateTime.Now;
            entity.DeletedDate = DateTime.Now;
            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            await DeleteAsync(entity);
        }
        public async Task HardDeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            return predicate is null ? _dbSet.Where(e => !e.IsDeleted) : _dbSet.Where(e => !e.IsDeleted).Where(predicate);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<T>> GetListAllAsync()
        {
            return await _db.Set<T>().Where(e => !e.IsDeleted).ToListAsync();
        }

        public async Task ToggleStatusAsync(T entity)
        {
            entity.Status = !entity.Status;
            _dbSet.Update(entity);
            await _db.SaveChangesAsync();
        }

        public async Task ToggleStatusAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            await ToggleStatusAsync(entity);
        }

        public async Task<IQueryable<T>> GetListByStatusTrueAsync(Expression<Func<T, bool>> predicate = null)
        {
            return predicate is null ? _dbSet.Where(e => !e.IsDeleted && e.Status) : _dbSet.Where(e => !e.IsDeleted && e.Status).Where(predicate);
        }
    }
}
