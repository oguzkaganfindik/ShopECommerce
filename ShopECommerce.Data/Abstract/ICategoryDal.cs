using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
    }
}
