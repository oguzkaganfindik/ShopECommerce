using System.Linq.Expressions;

namespace ShopECommerce.Data.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Delete(int id);
        void Update(T entity);
        T GetById(int id);
        List<T> GetListAll();
        T Get(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null);
        void ToggleStatus(int id);
        IQueryable<T> GetListByStatusTrue(Expression<Func<T, bool>> predicate = null);
    }
}
