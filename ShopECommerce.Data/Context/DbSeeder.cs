using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Context
{
    public static class DbSeeder
    {
        public static void SeedData(this ModelBuilder modelBuilder, IDataProtector dataProtector)
        {
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 1,
                Name = "Admin",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 2,
                Name = "User",
                CreatedDate = DateTime.Now,
            });

            //modelBuilder.Entity<Category>().HasData(new Category
            //{
            //    Id = 1,
            //    CategoryName = "İthal Muz",
            //    CategoryType = 0,
            //    CreatedDate = DateTime.Now,
            //    Status = true
            //});

            //modelBuilder.Entity<Category>().HasData(new Category
            //{
            //    Id = 2,
            //    CategoryName = "Yerli Muz",
            //    CategoryType = 0,
            //    CreatedDate = DateTime.Now,
            //    Status = true
            //});

            //modelBuilder.Entity<Category>().HasData(new Category
            //{
            //    Id = 3,
            //    CategoryName = "Salatalık",
            //    CategoryType = CategoryTypeEnum.Sebze,
            //    CreatedDate = DateTime.Now,
            //    Status = true
            //});

            //modelBuilder.Entity<Category>().HasData(new Category
            //{
            //    Id = 4,
            //    CategoryName = "Domates",
            //    CategoryType = CategoryTypeEnum.Meyve,
            //    CreatedDate = DateTime.Now,
            //    Status = true
            //});

            //modelBuilder.Entity<Product>().HasData(new Product
            //{
            //    Id = 1,
            //    CategoryId = 1,
            //    ProductName = "Bahçe Domatesi",
            //    Description = "Lezzetli",
            //    Price = 50,
            //    ImageUrl = "kjlnhsjkdf",
            //    Status = true,                
            //    CreatedDate = DateTime.Now,
            //});

            //modelBuilder.Entity<Product>().HasData(new Product
            //{
            //    Id = 2,
            //    CategoryId = 2,
            //    ProductName = "Yerli Muz",
            //    Description = "Lezzetli",
            //    Price = 75,
            //    ImageUrl = "asdasd",
            //    Status = true,
            //    CreatedDate = DateTime.Now,
            //});

            modelBuilder.Entity<User>().HasData(new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Şebnem",
                    LastName = "Ferah",
                    Status = true,
                    CreatedDate = DateTime.Now,
                    Email = "admin@test.com",
                    Username = "Admin",
                    Phone = "0850",
                    Address = "Ankara",
                    Password = dataProtector.Protect("123"),
                    RoleId = 1,
                }
            });
        }
    }
}
