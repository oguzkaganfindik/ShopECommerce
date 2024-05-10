using Microsoft.Extensions.DependencyInjection;
using ShopECommerce.Business.Mapping;

namespace ShopECommerce.Business
{
    public static class MappingRegistration
    {
        public static void AddMappingRegistration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AboutMapping));
            services.AddAutoMapper(typeof(BasketMapping));
            services.AddAutoMapper(typeof(UserMapping));
            services.AddAutoMapper(typeof(SubCategoryMapping));
            services.AddAutoMapper(typeof(CategoryMapping));
            services.AddAutoMapper(typeof(ContactMapping));
            services.AddAutoMapper(typeof(DiscountMapping));
            services.AddAutoMapper(typeof(MessageMapping));
            services.AddAutoMapper(typeof(ProductMapping));
            services.AddAutoMapper(typeof(RoleMapping));
            services.AddAutoMapper(typeof(SliderMapping));
            services.AddAutoMapper(typeof(SocialMediaMapping));
            services.AddAutoMapper(typeof(TestimonialMapping));
            services.AddAutoMapper(typeof(NotificationMapping));
            services.AddAutoMapper(typeof(ShopTableMapping));
            services.AddAutoMapper(typeof(FactMapping));
            services.AddAutoMapper(typeof(FeaturMapping));
            services.AddAutoMapper(typeof(BannerMapping));
        }
    }
}