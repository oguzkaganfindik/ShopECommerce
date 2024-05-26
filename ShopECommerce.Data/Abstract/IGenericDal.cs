using System.Linq.Expressions;

namespace ShopECommerce.Data.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteAsync(int id);
        Task HardDeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetListAllAsync();
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);
        Task ToggleStatusAsync(int id);
        Task<IQueryable<T>> GetListByStatusTrueAsync(Expression<Func<T, bool>> predicate = null);
    }
}
