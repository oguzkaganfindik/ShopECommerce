using System.Linq.Expressions;

namespace ShopECommerce.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task TAddAsync(T entity);
        Task TDeleteAsync(T entity);
        Task TDeleteAsync(int id);
        Task THardDeleteAsync(int id);
        Task TUpdateAsync(T entity);
        Task<T> TGetByIdAsync(int id);
        Task<List<T>> TGetListAllAsync();
        Task<T> TGetAsync(Expression<Func<T, bool>> predicate);
        Task<IQueryable<T>> TGetAllAsync(Expression<Func<T, bool>> predicate = null);
        Task TToggleStatusAsync(int id);
        Task<IQueryable<T>> TGetListByStatusTrueAsync(Expression<Func<T, bool>> predicate = null);
    }
}
