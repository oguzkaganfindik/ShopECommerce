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

        public void Add(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.IsDeleted = false;
            entity.Status = true;
            _dbSet.Add(entity);
            _db.SaveChanges();
        }
        public void Update(T entity)
        {
            entity.ModifiedDate = DateTime.Now;
            entity.CreatedDate = _dbSet.AsNoTracking().FirstOrDefault(e => e.Id == entity.Id)?.CreatedDate ?? DateTime.Now;
            entity.Status = _dbSet.AsNoTracking().FirstOrDefault(e => e.Id == entity.Id)?.Status ?? true;
            _dbSet.Update(entity);
            _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.Status = false;
            entity.ModifiedDate = DateTime.Now;
            entity.DeletedDate = DateTime.Now;
            _dbSet.Update(entity);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            Delete(entity);
        }
        public void HardDelete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _db.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            return predicate is null ? _dbSet.Where(e => !e.IsDeleted) : _dbSet.Where(e => !e.IsDeleted).Where(predicate);
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetListAll()
        {
            return _db.Set<T>().Where(e => !e.IsDeleted).ToList();
        }

        public void ToggleStatus(T entity)
        {
            entity.Status = !entity.Status;
            _dbSet.Update(entity);
            _db.SaveChanges();
        }

        public void ToggleStatus(int id)
        {
            var entity = _dbSet.Find(id);
            ToggleStatus(entity);
        }

        public IQueryable<T> GetListByStatusTrue(Expression<Func<T, bool>> predicate = null)
        {
            return predicate is null ? _dbSet.Where(e => !e.IsDeleted && e.Status) : _dbSet.Where(e => !e.IsDeleted && e.Status).Where(predicate);
        }
    }
}
