using Microsoft.Extensions.DependencyInjection;
using ShopECommerce.Business.Abstract;
using ShopECommerce.Business.Concrete;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Concrete;

namespace ShopECommerce.Business
{
    public static class ServiceRegistration
    {
        public static void AddServicesRegistration(this IServiceCollection services)
        {
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDal, EfAboutDal>();

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, EfUserDal>();

            services.AddScoped<IRoleService, RoleManager>();
            services.AddScoped<IRoleDal, EfRoleDal>();

            services.AddScoped<ISubCategoryService, SubCategoryManager>();
            services.AddScoped<ISubCategoryDal, EfSubCategoryDal>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EfContactDal>();

            services.AddScoped<IDiscountService, DiscountManager>();
            services.AddScoped<IDiscountDal, EfDiscountDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();

            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();

            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IOrderDal, EfOrderDal>();

            services.AddScoped<IOrderDetailService, OrderDetailManager>();
            services.AddScoped<IOrderDetailDal, EfOrderDetailDal>();

            services.AddScoped<IMoneyCaseService, MoneyCaseManager>();
            services.AddScoped<IMoneyCaseDal, EfMoneyCaseDal>();

            services.AddScoped<IShopTableService, ShopTableManager>();
            services.AddScoped<IShopTableDal, EfShopTableDal>();

            services.AddScoped<ISliderService, SliderManager>();
            services.AddScoped<ISliderDal, EfSliderDal>();

            services.AddScoped<IBasketService, BasketManager>();
            services.AddScoped<IBasketDal, EfBasketDal>();

            services.AddScoped<INotificationService, NotificationManager>();
            services.AddScoped<INotificationDal, EfNotificationDal>();

            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDal, EfMessageDal>();

            services.AddScoped<IFactService, FactManager>();
            services.AddScoped<IFactDal, EfFactDal>();

            services.AddScoped<IFeaturService, FeaturManager>();
            services.AddScoped<IFeaturDal, EfFeaturDal>();

            services.AddScoped<IBannerService, BannerManager>();
            services.AddScoped<IBannerDal, EfBannerDal>();
        }
    }
}