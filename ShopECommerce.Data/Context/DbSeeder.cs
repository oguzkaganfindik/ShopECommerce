using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using ShopECommerce.Entities.Concrete;
using ShopECommerce.Entities.Enums;

namespace ShopECommerce.Data.Context
{
    public static class DbSeeder
    {
        public static void SeedData(this ModelBuilder modelBuilder, IDataProtector dataProtector)
        {
            modelBuilder.Entity<UserEntity>().HasData(new List<UserEntity>()
            {
                new UserEntity()
                {
                    Id = 1,
                    FirstName = "Şebnem",
                    LastName = "Ferah",
                    Email = "admin@test.com",
                    Password = dataProtector.Protect("123"),
                    UserType = UserTypeEnum.Admin
                }
            });
        }
    }
}
