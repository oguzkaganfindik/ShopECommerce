using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using ShopECommerce.Entities.Concrete;
using ShopECommerce.Entities.Configuration;

namespace ShopECommerce.Data.Context
{
    public class ShopECommerceContext : DbContext
    {
        private readonly IDataProtector _dataProtector;

        public ShopECommerceContext(DbContextOptions<ShopECommerceContext> options, IDataProtectionProvider dataProtectionProvider) : base(options)
        {
            _dataProtector = dataProtectionProvider.CreateProtector("security");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new SubCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.SeedData(_dataProtector);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<About> Abouts => Set<About>();
        public DbSet<Basket> Baskets => Set<Basket>();
        public DbSet<Booking> Bookings => Set<Booking>();
        public DbSet<Banner> Banners => Set<Banner>();
        public DbSet<SubCategory> SubCategories => Set<SubCategory>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Contact> Contacts => Set<Contact>();
        public DbSet<Discount> Discounts => Set<Discount>();
        public DbSet<Featur> Featurs => Set<Featur>();
        public DbSet<Fact> Facts => Set<Fact>();
        public DbSet<MenuTable> MenuTables => Set<MenuTable>();
        public DbSet<Message> Messages => Set<Message>();
        public DbSet<MoneyCase> MoneyCases => Set<MoneyCase>();
        public DbSet<Notification> Notifications => Set<Notification>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderDetail> OrderDetails => Set<OrderDetail>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<Slider> Sliders => Set<Slider>();
        public DbSet<SocialMedia> SocialMedias => Set<SocialMedia>();
        public DbSet<Testimonial> Testimonials => Set<Testimonial>();
        public DbSet<User> Users => Set<User>();
    }
}