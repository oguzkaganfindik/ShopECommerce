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

            modelBuilder.Entity<Category>().HasData(new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    CategoryName = "Fruites",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new Category()
                {
                    Id = 2,
                    CategoryName = "Vesitables",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });

            modelBuilder.Entity<SubCategory>().HasData(new List<SubCategory>()
            {
                new SubCategory()
                {
                    Id = 1,
                    CategoryId = 1,
                    SubCategoryName = "Grapes",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new SubCategory()
                {
                    Id = 2,
                    CategoryId = 1,
                    SubCategoryName = "Raspberries",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new SubCategory()
                {
                    Id = 3,
                    CategoryId = 1,
                    SubCategoryName = "Apricots",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new SubCategory()
                {
                    Id = 4,
                    CategoryId = 1,
                    SubCategoryName = "Banana",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new SubCategory()
                {
                    Id = 5,
                    CategoryId = 1,
                    SubCategoryName = "Oranges",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new SubCategory()
                {
                    Id = 6,
                    CategoryId = 1,
                    SubCategoryName = "Apple",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new SubCategory()
                {
                    Id = 7,
                    CategoryId = 2,
                    SubCategoryName = "Patatoes",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new SubCategory()
                {
                    Id = 8,
                    CategoryId = 2,
                    SubCategoryName = "Persely",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new SubCategory()
                {
                    Id = 9,
                    CategoryId = 2,
                    SubCategoryName = "Tomato",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new SubCategory()
                {
                    Id = 10,
                    CategoryId = 2,
                    SubCategoryName = "Brocoli",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new SubCategory()
                {
                    Id = 11,
                    CategoryId = 2,
                    SubCategoryName = "Bell Papper",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new SubCategory()
                {
                    Id = 12,
                    CategoryId = 1,
                    SubCategoryName = "Strawberry",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
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

            modelBuilder.Entity<Testimonial>().HasData(new List<Testimonial>()
            {
                new Testimonial()
                {
                    Id = 1,
                    Name = "Şebnem Ferah",
                    Title = "Şef Aşçı",
                    Comment = "Lorem Ipsum is simply dummy text of the printing Ipsum has been the industry's standard dummy text ever since the 1500s,",
                    ImageUrl = "/WebT/img/testimonial-1.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new Testimonial()
                {
                    Id = 2,
                    Name = "Teoman Yakupoğlu",
                    Title = "Şef Aşçı",
                    Comment = "Lorem Ipsum is simply dummy text of the printing Ipsum has been the industry's standard dummy text ever since the 1500s,",
                    ImageUrl = "/WebT/img/testimonial-1.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

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
                    ImageUrl = "/WebT/img/featur-1.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Discount()
                {
                    Id = 2,
                    Title = "Tasty Fruits",
                    Description = "Free delivery",
                    Amount = "",
                    ImageUrl = "/WebT/img/featur-2.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Discount()
                {
                    Id = 3,
                    Title = "Exotic Vegitable",
                    Description = "Discount",
                    Amount = "30",
                    ImageUrl = "/WebT/img/featur-3.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });
            modelBuilder.Entity<Product>().HasData(new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    SubCategoryId = 1,
                    ProductName = "Native Grapes",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt",
                    Price = 4.95M,
                    ImageUrl = "/WebT/img/fruite-item-5.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 2,
                    SubCategoryId = 2,
                    ProductName = "Native Raspberries",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt",
                    Price = 4.95M,
                    ImageUrl = "/WebT/img/fruite-item-2.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 3,
                    SubCategoryId = 3,
                    ProductName = "Native Apricots",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt",
                    Price = 4.95M,
                    ImageUrl = "/WebT/img/fruite-item-4.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 4,
                    SubCategoryId = 4,
                    ProductName = "Native Banana",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt",
                    Price = 4.95M,
                    ImageUrl = "/WebT/img/fruite-item-3.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 5,
                    SubCategoryId = 5,
                    ProductName = "Native Oranges",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt",
                    Price = 4.95M,
                    ImageUrl = "/WebT/img/fruite-item-1.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 6,
                    SubCategoryId = 6,
                    ProductName = "Native Apple",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt",
                    Price = 4.95M,
                    ImageUrl = "/WebT/img/featur-1.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 7,
                    SubCategoryId = 7,
                    ProductName = "Native Patatoes",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt",
                    Price = 4.95M,
                    ImageUrl = "/WebT/img/vegetable-item-5.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 8,
                    SubCategoryId = 8,
                    ProductName = "Native Persely",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt",
                    Price = 4.95M,
                    ImageUrl = "/WebT/img/vegetable-item-6.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 9,
                    SubCategoryId = 9,
                    ProductName = "Native Tomato",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt",
                    Price = 4.95M,
                    ImageUrl = "/WebT/img/vegetable-item-1.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 10,
                    SubCategoryId = 10,
                    ProductName = "Native Brocoli",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt",
                    Price = 4.95M,
                    ImageUrl = "/WebT/img/featur-3.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 11,
                    SubCategoryId = 11,
                    ProductName = "Native Bell Papper",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt",
                    Price = 4.95M,
                    ImageUrl = "/WebT/img/vegetable-item-4.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new Product()
                {
                    Id = 12,
                    SubCategoryId = 12,
                    ProductName = "Native Strawberry",
                    Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit sed do eiusmod te incididunt",
                    Price = 4.95M,
                    ImageUrl = "/WebT/img/featur-2.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });

            modelBuilder.Entity<Featur>().HasData(new List<Featur>()
            {
                new Featur()
                {
                    Id = 1,
                    Title = "Free Shipping",
                    Description = "Free on order over $300",
                    Icon = "fas fa-car-side fa-3x text-white",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new Featur()
                {
                    Id = 2,
                    Title = "Security Payment",
                    Description = "100% security payment",
                    Icon = "fas fa-user-shield fa-3x text-white",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new Featur()
                {
                    Id = 3,
                    Title = "30 Day Return",
                    Description = "30 day money guarantee",
                    Icon = "fas fa-exchange-alt fa-3x text-white",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new Featur()
                {
                    Id = 4,
                    Title = "24/7 Support",
                    Description = "Support every time fast",
                    Icon = "fa fa-phone-alt fa-3x text-white",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
            });

            modelBuilder.Entity<Fact>().HasData(new List<Fact>()
            {
                new Fact()
                {
                    Id = 1,
                    Title = "SATISFIED CUSTOMERS",
                    Description = "1963",
                    Icon = "fa fa-users text-secondary",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new Fact()
                {
                    Id = 2,
                    Title = "QUALITY OF SERVICE",
                    Description = "99%",
                    Icon = "fa fa-users text-secondary",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new Fact()
                {
                    Id = 3,
                    Title = "QUALITY CERTIFICATES",
                    Description = "33",
                    Icon = "fa fa-users text-secondary",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new Fact()
                {
                    Id = 4,
                    Title = "AVAILABLE PRODUCTS",
                    Description = "789",
                    Icon = "fa fa-users text-secondary",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
            });
        }
    }
}