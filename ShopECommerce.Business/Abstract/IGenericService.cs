using System.Linq.Expressions;

namespace ShopECommerce.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entity);
        void TDelete(T entity);
        void TDelete(int id);
        void THardDelete(int id);
        void TUpdate(T entity);
        T TGetById(int id);
        List<T> TGetListAll();
        T TGet(Expression<Func<T, bool>> predicate);
        IQueryable<T> TGetAll(Expression<Func<T, bool>> predicate = null);
        void TToggleStatus(int id);
        IQueryable<T> TGetListByStatusTrue(Expression<Func<T, bool>> predicate = null);
    }
}
