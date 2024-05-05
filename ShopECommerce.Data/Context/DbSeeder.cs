using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ShopECommerce.DTOs.SliderDto;
using ShopECommerce.Entities.Concrete;
using System.Threading.Tasks;

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
                Status = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 2,
                Name = "User",
                Status = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                CategoryName = "Meyve",
                Status = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                CategoryName = "Sebze",
                Status = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<SubCategory>().HasData(new SubCategory
            {
                Id = 1,
                CategoryId = 1,
                SubCategoryName = "Elma",
                Status = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<SubCategory>().HasData(new SubCategory
            {
                Id = 2,
                CategoryId = 2,
                SubCategoryName = "Salatalık",
                Status = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,                
                SubCategoryId = 2,
                ProductName = "Bahçe Domatesi",
                Description = "Lezzetli",
                Price = 50,
                ImageUrl = "kjlnhsjkdf",
                Status = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                SubCategoryId = 2,
                ProductName = "Yerli Muz",
                Description = "Lezzetli",
                Price = 75,
                ImageUrl = "asdasd",
                Status = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<User>().HasData(new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Şebnem",
                    LastName = "Ferah",
                    Email = "admin@test.com",
                    Username = "Admin",
                    Phone = "0850",
                    Address = "Ankara",
                    Password = dataProtector.Protect("123"),
                    RoleId = 1,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });

            modelBuilder.Entity<Testimonial>().HasData(new Testimonial
            {
                Id = 1,
                Name = "Şebnem Ferah",
                Title = "Şef Aşçı",
                Comment = "Lorem Ipsum is simply dummy text of the printing Ipsum has been the industry's standard dummy text ever since the 1500s,",
                ImageUrl = "/WebT/img/testimonial-1.jpg",
                Status = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<SocialMedia>().HasData(new List<SocialMedia>()
            {
                new SocialMedia()
                {
                    Id = 1,
                    Title = "Facebook", 
                    Cls = "btn btn-outline-secondary me-2 btn-md-square rounded-circle",
                    Url = "http://www.facebook.com",
                    Icon = "fab fa-facebook-f",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new SocialMedia()
                {
                    Id = 2,
                    Title = "Youtube",
                    Cls = "btn btn-outline-secondary me-2 btn-md-square rounded-circle",
                    Url = "http://www.youtube.com",
                    Icon = "fab fa-youtube",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new SocialMedia()
                {
                    Id = 3,
                    Title = "Linkedin",
                    Cls = "btn btn-outline-secondary me-2 btn-md-square rounded-circle",
                    Url = "http://www.linkedin.com",
                    Icon = "fab fa-linkedin-in",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new SocialMedia()
                {
                    Id = 4,
                    Title = "Twitter",
                    Cls = "btn btn-outline-secondary btn-md-square rounded-circle",
                    Url = "http://www.x.com",
                    Icon = "fab fa-twitter",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });

            modelBuilder.Entity<Slider>().HasData(new List<Slider>()
            {
                new Slider()
                {
                    Id = 1,
                    Title = "100% Organic Foods",
                    Description = "Organic Veggies & Fruits Foods",
                    Label1 = "Fruites",
                    ImageUrl1 = "/WebT/img/hero-img-1.png",
                    Url1 = "#",
                    Label2 = "Vesitables",
                    ImageUrl2 = "/WebT/img/hero-img-2.jpg",
                    Url2 = "#",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });

            modelBuilder.Entity<Discount>().HasData(new List<Discount>()
            {
                new Discount()
                {
                    Id = 1,
                    Title = "Fresh Apples",
                    Description = "OFF",
                    Amount = "20",
                    ImageUrl = "/WebT/img/featur-1.jpg"
                },
                new Discount()
                {
                    Id = 2,
                    Title = "Tasty Fruits",
                    Description = "Free delivery",
                    Amount = "",
                    ImageUrl = "/WebT/img/featur-2.jpg"
                },
                new Discount()
                {
                    Id = 3,
                    Title = "Exotic Vegitable",
                    Description = "Discount",
                    Amount = "30",
                    ImageUrl = "/WebT/img/featur-3.jpg"
                }
            });
        }
    }
}