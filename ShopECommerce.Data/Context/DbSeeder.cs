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

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                CategoryName = "Meyve",
                Description = "Meyveler",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                CategoryName = "Sebze",
                Description = "Sebzeler",
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<SubCategory>().HasData(new SubCategory
            {
                Id = 1,
                Name = "Elma",
                CategoryId = 1,
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<SubCategory>().HasData(new SubCategory
            {
                Id = 2,
                Name = "Muz",
                CategoryId = 1,
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<SubCategory>().HasData(new SubCategory
            {
                Id = 3,
                Name = "Pırasa",
                CategoryId = 2,
                CreatedDate = DateTime.Now,
            });

            modelBuilder.Entity<SubCategory>().HasData(new SubCategory
            {
                Id = 4,
                Name = "Salatalık",
                CategoryId = 2,
                CreatedDate = DateTime.Now,
            });

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
