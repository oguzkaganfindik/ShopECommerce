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
                Name = "SuperAdmin",
                Status = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 2,
                Name = "Admin",
                Status = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 3,
                Name = "User",
                Status = true,
                IsDeleted = false,
                CreatedDate = DateTime.Now
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 4,
                Name = "Customer",
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
                    FirstName = "Adile",
                    LastName = "Naşit",
                    Email = "superadmin@test.com",
                    Username = "AdileNasit",
                    Phone = "+90 850 147 45 67",
                    Address = "Bahçelievler Mh. 3. Cd. Çankaya / Ankara",
                    Password = dataProtector.Protect("123"),
                    Description = "SuperAdmin Onaylandı.",
                    RoleId = 1,
                    EmailConfirmed = true,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new User()
                {
                    Id = 2,
                    FirstName = "Kemal",
                    LastName = "Sunal",
                    Email = "admin@test.com",
                    Username = "KemalSunal",
                    Phone = "+90 312 458 65 12",
                    Address = "Gazi Mh. Silahtar Cd. Çankaya / Ankara",
                    Password = dataProtector.Protect("123"),
                    Description = "Admin Onaylandı.",
                    RoleId = 2,
                    EmailConfirmed = true,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new User()
                {
                    Id = 3,
                    FirstName = "Şener",
                    LastName = "Şen",
                    Email = "user@test.com",
                    Username = "SenerSen",
                    Phone = "+90 312 694 45 63",
                    Address = "Emek Mh. 8. Cd. Çankaya / Ankara",
                    Password = dataProtector.Protect("123"),
                    Description = "User Onaylandı.",
                    RoleId = 3,
                    EmailConfirmed = true,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new User()
                {
                    Id = 4,
                    FirstName = "Hulisi",
                    LastName = "Kentmen",
                    Email = "customer@test.com",
                    Username = "HulusiKentmen",
                    Phone = "0850",
                    Address = "Ankara",
                    Password = dataProtector.Protect("123"),
                    Description = "Customer Onaylandı.",
                    RoleId = 4,
                    EmailConfirmed = true,
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
                    Name = "Zeki Alasya",
                    Title = "Şef Aşçı",
                    Comment = "Lorem Ipsum is simply dummy text of the printing Ipsum has been the industry's standard dummy text ever since the 1500s,",
                    ImagePath = "/WebT/img/client2.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new Testimonial()
                {
                    Id = 2,
                    Name = "Emel Sayın",
                    Title = "Pastane Şefi",
                    Comment = "Lorem Ipsum is simply dummy text of the printing Ipsum has been the industry's standard dummy text ever since the 1500s,",
                    ImagePath = "/WebT/img/client1.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new Testimonial()
                {
                    Id = 3,
                    Name = "Perran Kutman",
                    Title = "Meze Ustası",
                    Comment = "Lorem Ipsum is simply dummy text of the printing Ipsum has been the industry's standard dummy text ever since the 1500s,",
                    ImagePath = "/WebT/img/testimonial-1.jpg",
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
                    ImagePath1 = "/WebT/img/hero-img-1.png",
                    Url1 = "#",
                    Label2 = "Vesitables",
                    ImagePath2 = "/WebT/img/hero-img-2.jpg",
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
                    Amount = "20%",
                    ImagePath = "/WebT/img/featur-1.jpg",
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
                    ImagePath = "/WebT/img/featur-2.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Discount()
                {
                    Id = 3,
                    Title = "Exotic Vegitable",
                    Description = "Discount",
                    Amount = "30$",
                    ImagePath = "/WebT/img/featur-3.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });

            modelBuilder.Entity<ShopTable>().HasData(new List<ShopTable>()
            {
                new ShopTable()
                {
                    Id = 1,
                    Name = "customer@test.com",
                    OrderId = 1,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new ShopTable()
                {
                    Id = 2,
                    Name = "user@test.com",
                    OrderId = 2,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });

            modelBuilder.Entity<Basket>().HasData(new List<Basket>()
            {
                new Basket()
                {
                    Id = 1,
                    Price = 4.95M,
                    Count = 1,
                    TotalPrice = 4.95M,
                    ProductId = 1,
                    ShopTableId = 1,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Basket()
                {
                    Id = 2,
                    Price = 4.95M,
                    Count = 1,
                    TotalPrice = 4.95M,
                    ProductId = 2,
                    ShopTableId = 1,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Basket()
                {
                    Id = 3,
                    Price = 4.95M,
                    Count = 1,
                    TotalPrice = 4.95M,
                    ProductId = 3,
                    ShopTableId = 1,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Basket()
                {
                    Id = 4,
                    Price = 4.95M,
                    Count = 1,
                    TotalPrice = 4.95M,
                    ProductId = 4,
                    ShopTableId = 2,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });


            modelBuilder.Entity<Order>().HasData(new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    Description = "Sipariş",
                    ShopTableId = 1,
                    OrderDate = DateTime.Now,
                    TotalPrice = 20,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new Order()
                {
                    Id = 2,
                    Description = "Sipariş",
                    ShopTableId = 2,
                    OrderDate = DateTime.Now,
                    TotalPrice = 5,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });

            modelBuilder.Entity<OrderDetail>().HasData(new List<OrderDetail>()
            {
                new OrderDetail()
                {
                    Id = 1,
                    ProductId = 1,
                    Count = 1,
                    UnitPrice = 5,
                    TotalPrice = 5,
                    OrderId = 1,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new OrderDetail()
                {
                    Id = 2,
                    ProductId = 2,
                    Count = 1,
                    UnitPrice = 5,
                    TotalPrice = 5,
                    OrderId = 1,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new OrderDetail()
                {
                    Id = 3,
                    ProductId = 3,
                    Count = 1,
                    UnitPrice = 5,
                    TotalPrice = 5,
                    OrderId = 1,
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },
                new OrderDetail()
                {
                    Id = 4,
                    ProductId = 4,
                    Count = 1,
                    UnitPrice = 5,
                    TotalPrice = 5,
                    OrderId = 2,
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
                    Description = "Yeşil üzümler de siyah üzümler gibi antioksidan içerir ve özellikle C ve K vitaminleri açısından çok zengindir. İçerdiği yüksek C ve K vitaminleri sayesinde bağışıklık sistemini güçlendirerek cilt sağlığını destekleyebilir, ayrıca K vitamini sayesinde kalp ve damar sağlığına olumlu katkıda bulunabilir. Yeşil üzümün faydaları arasında tıpkı siyah üzüm gibi damar sağlığı ve dolaşıma desteği vardır. Bunun yanı sıra siyah üzümün tersine kandaki HDL (yüksek yoğunluklu lipoprotein) ya da iyi kolesterolü arttırdığı gözlenmiştir. Kandaki yağ miktarını dengeleyen yeşil üzümün aynı zamanda karın bölgesinde oluşan ve özellikle organ yağlanmasına işaret eden göbek yağlarını da erittiği tespit edilmiştir. Siyah üzümlere kıyasla yeşil üzümlerde antosiyanin oranı daha düşük olsa da yeşil üzümler stilbenler açısından oldukça zengindir. Stilbenler, bitkinin stres yanıtına karşılık olarak ürettiği moleküler bileşenlerdir ve insan sağlığı için kritik öneme sahiplerdir. Bunlardan en önemlisi olan resveratrolün hastalıkların gelişmesini ya da ilerlemesini önlediği keşfedilmiştir. Dolayısıyla yeşil üzümün faydaları dendiğinde en önemli noktalardan biri kabuğundaki resveratrol miktardır. Bu sayede tıpkı koyu renkli üzümler gibi yeşil üzümler de vücudu enfeksiyona karşı koruyarak daha dirençli bir hale getirir. Hücresel boyutta bakıldığında üzümün içinde bulunan bileşenler hücrelerin işlevlerini desteklerken yapısal bozukluklarını önler. Bu nedenle hücre yapısının bozulmasından kaynaklanan kanser için de önleyici ve koruyucu bir etkiye sahiptir.",
                    Price = 4.95M,
                    ImagePath = "/WebT/img/fruite-item-5.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ProductTitle = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Weight = 1,
                    CountryOfOrigin = "Agro Farm",
                    Quality = "Organic",
                    Сheck = "Healthy",
                    MinWeight = 0.250M
                },
                new Product()
                {
                    Id = 2,
                    SubCategoryId = 2,
                    ProductName = "Native Raspberries",
                    Description = "Gülgiller ailesinden olan frambuaz, ülkemizde ahududu olarak bilinir (İng.raspberry). Doğada yaklaşık 200 kadar çeşidi olduğu bilinmektedir. Kırmızı/pembe renklerdeki bu meyve tam bir antioksidant deposudur.Diğer tüm minik taneli meyvelerde olduğu gibi C vitamini yönünden zengindir, antioksidant (kansere karşı koruyucu) aktivitesi yüksektir.rambuaz/ahududu ile ilgili yapılan çoğu araştırma antioksidant etkisi ve kalp damar sağlığı üzerindeki faydalarıyla ilgilidir. Bu araştırma sonuçlarına göre östrojen kaynaklı meme tümörlerinin oluşumunu engelleyici, mide ve kalın barsak (kolon) kanseri risklerini azaltıcı etkileri ortaya çıkarılmıştır. Ayrıca kan sulandırıcı/pıhtı çözücü etkisi sayesinde ateroskleroz (damar tıkanıklığı) oluşumunu azaltarak kalp damar hastalığı risklerini azaltmaktadır. Bazı araştırmalar karaciğer lezyonları üzerinde iyileştirici etkisinin olduğunu da göstermektedir. Kan sulandırıcı (antikoagülant) etkisi nedeni ile bazı ilaçların (özellikle pıhtı çözücü) aktivitelerini bozabileceği için hastaların bu meyveyi tüketirken mutlaka doktorlarına danışmaları gerekmektedir. Aynı zamanda antienflamatuar (iltihap önleyici) etkisi sayesinde iltihabi rahatsızlıkların tedavisinde bağışıklık sistemini destekleyici etkisi de vardır.",
                    Price = 4.95M,
                    ImagePath = "/WebT/img/fruite-item-2.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ProductTitle = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Weight = 1,
                    CountryOfOrigin = "Agro Farm",
                    Quality = "Organic",
                    Сheck = "Healthy",
                    MinWeight = 0.250M
                },
                new Product()
                {
                    Id = 3,
                    SubCategoryId = 3,
                    ProductName = "Native Apricots",
                    Description = "Lif açısından zengindir: Kuru kayısı, sindirim sistemi sağlığı için önemli olan lif açısından zengindir. Lif, kabızlığı önleyebilir ve bağırsak hareketlerini düzenleyebilir.\r\n\r\nVitamin ve mineral kaynağıdır: Kuru kayısı, C vitamini, A vitamini, potasyum ve demir gibi vitamin ve mineraller açısından zengindir. Bu vitamin ve mineraller, vücut fonksiyonlarının düzgün çalışmasını sağlayabilir ve bağışıklık sisteminin güçlenmesine yardımcı olabilir.\r\n\r\nDüşük kalorili bir atıştırmalık: Kuru kayısı, düşük kalorili bir atıştırmalık seçeneğidir. Oruçlu zamanlarda tokluk hissini artırmaya yardımcı olabilir.\r\n\r\nAncak, hurma ve kuru kayısı gibi kuruyemişler yüksek şeker içeriği nedeniyle aşırı tüketilmemelidir. Oruçlu zamanlarda ölçülü tüketmeye dikkat edin. Ayrıca, özellikle şeker hastalığı gibi bir sağlık sorununuz varsa, hurma ve kuru kayısı tüketimini doktorunuzla konuşmanız önerilir.",
                    Price = 4.95M,
                    ImagePath = "/WebT/img/fruite-item-4.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ProductTitle = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Weight = 1,
                    CountryOfOrigin = "Agro Farm",
                    Quality = "Organic",
                    Сheck = "Healthy",
                    MinWeight = 0.250M
                },
                new Product()
                {
                    Id = 4,
                    SubCategoryId = 4,
                    ProductName = "Native Banana",
                    Description = "Muz, dünyada en çok yetiştirilen tropik meyvelerden biridir. Bazen şeker ihtiyacımızı giderme, bazen tok tutması için yediğimiz muz, en sevilen ve en çok tüketilen meyvelerden olup; yüksek besin ögesi içeriğiyle dikkat çeker. Kolay sindirilebilen karbonhidrat içeriği ve yumuşak dokusu sayesinde tüm yaş grupları arasında yaygın olarak tercih edilir. Çocukların da severek tükettiği bu tatlı besleyici meyvenin sağlığa pek çok faydası olduğu bilinir. Sindirim sisteminden kemik sağlığına, bağırsak hastalarından kansere, kalp sağlığından beyin sağlığına kadar muz tüketiminin faydaları saymakla bitmez. Her gün muz yemek için sebep çok.\r\n\r\n\r\nPotasyumun Gücü\r\n“Muzun faydaları nelerdir?” deyince akla hemen potasyum içeriği gelir. Muzda yüksek miktarda bulunan potasyum minerali sıvı dengesinin düzenlenmesine yardım eden önemli bir elektrolittir. Potasyum, kasların kasılması ve sinir hücrelerinin yanıt vermesine yardımcı olur. Kalp atışlarını düzenler ve sodyumun kan basıncı üzerindeki etkisini dengeleyerek normal kan basıncı ve kalp fonksiyonlarının sürdürülmesi için önemlidir. Yaş ilerledikçe kemik sağlığını korurken böbrek taşı oluşma riskini de düşürmeye destek olabilir. Ancak, böbrek hastalığı olan potasyum kısıtlaması gereken bireylerde muzun zengin potasyum içeriği kan potasyum seviyelerini arttırarak kalp ritmini olumsuz etkileyebilir. Bu sebeple bu bireylerin muz tüketmeden önce diyetisyene danışmalarında fayda var.",
                    Price = 4.95M,
                    ImagePath = "/WebT/img/fruite-item-3.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ProductTitle = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Weight = 1,
                    CountryOfOrigin = "Agro Farm",
                    Quality = "Organic",
                    Сheck = "Healthy",
                    MinWeight = 0.250M
                },
                new Product()
                {
                    Id = 5,
                    SubCategoryId = 5,
                    ProductName = "Native Oranges",
                    Description = "Portakal faydaları ya da portakalın sağlık açısından katkıları dendiğinde akla gelen ilk şey, C vitaminidir. Narenciyeler genel olarak bağışıklık sistemini desteklemeye yardımcı olan, bol miktarda C vitamini içeren meyvelerdir. Ancak portakalın faydaları C vitamini ile sınırlı değildir. 3 Portakal; vitaminler, mineraller ve antioksidanlar gibi pek çok farklı besin maddelerinin yanı sıra koruyucu bitki bileşikleri açısından da zengin bir hazine olarak kabul edilir. Yapılan araştırmalar, düzenli olarak portakal tüketmenin sağlığa çeşitli şekillerde fayda sağlayabileceğini gösterir.1\r\n\r\nPortakal, flavonoidler, karotenoidler ve C vitamini gibi çeşitli biyoaktif bitki bileşikleri içerir. Hesperidin ve naringenin portakalda bulunan flavonoidler arasında yer alır. Hesperidin, portakalda yer alan ana antioksidanlardan biridir. Naringenin ise sağlık yararları ile bağlantılı olan başka bir narenciye flavonoididir. Örneğin naringenin açısından zengin portakal suyu içmek, vücuttaki antioksidan aktiviteyi güçlendirmeye yardımcı olabilir. Bu aynı zamanda taze sıkılmış portakal suyu faydaları arasında da gösterilebilir.1,4\r\n\r\nPortakala turuncu, kırmızı ve sarı rengini veren karotenoidler de bir tür antioksidandır. Yapılan bazı araştırmalar, portakal suyu faydaları arasında vücudun toplam antioksidan durumunun iyi bir göstergesi olan cilt karotenoid düzeylerini artırmaya yardımcı olduğunu gösterir.1, 5 Portakalın faydaları arasında yer alan karotenoidlerden biri olan beta kriptoksantin; hücreleri oksidatif hasara karşı korumaya yardımcı olur. Ayrıca vücut beta kriptoksantin'i A vitamininin aktif formuna dönüştürebilir. 6 Portakalda bulunan bir diğer karotenoid ise likopen adlı bileşiktir. Likopen, kırmızı renkli ve etli portakallarda yüksek miktarlarda bulunan güçlü bir antioksidandır. ",
                    Price = 4.95M,
                    ImagePath = "/WebT/img/fruite-item-1.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ProductTitle = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Weight = 1,
                    CountryOfOrigin = "Agro Farm",
                    Quality = "Organic",
                    Сheck = "Healthy",
                    MinWeight = 0.250M
                },
                new Product()
                {
                    Id = 6,
                    SubCategoryId = 6,
                    ProductName = "Native Apple",
                    Description = "Elmanın glisemik indeksi, protein ve yağ içeriği düşüktür. Elma, lifli bir yapısı olması nedeni ile bağırsak tembelliğine iyi gelen, bununla beraber kolesterol ve karbonhidratların emilimini düzenlemeye yardımcı çözünür bir lif olan pektin içeriği en yüksek meyvelerden biridir.\r\n\r\nElmada C, A, K, B6 ve E vitaminleri bulunur. C vitamini besinler yoluyla sağlanmalıdır. Yorgunluğu azaltmaya yardımcı olur, sinir sisteminin düzgün çalışması ve bağışıklık savunması için gereklidir, demir emilimini artırır. İçerisinde bulunan polifenoller sayesinde antioksidan özelliklere sahiptir.\r\n\r\nElma, potasyum, fosfor, kalsiyum, çinko, demir gibi mineraller içermektedir. Potasyum, normal kan basıncını ve kas fonksiyonunu korumaya yardımcı olan bir mineraldir.\r\n\r\nElmadaki vitaminden en iyi şekilde yararlanmak için elma çiğ olarak, kabuklu veya kabuğu soyulduktan hemen sonra tüketilmeli çünkü C vitamini havadaki ısı ve oksijenin etkisine karşı hassastır. Elma, enerji metabolizmasına katkıda bulunur ve hücreleri oksidatif strese karşı korur.  ",
                    Price = 4.95M,
                    ImagePath = "/WebT/img/featur-1.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ProductTitle = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Weight = 1,
                    CountryOfOrigin = "Agro Farm",
                    Quality = "Organic",
                    Сheck = "Healthy",
                    MinWeight = 0.250M
                },
                new Product()
                {
                    Id = 7,
                    SubCategoryId = 7,
                    ProductName = "Native Patatoes",
                    Description = "Patates tüm tartışmalara rağmen faydalıdır. Patates faydaları düşünüldüğünde akla hemen potasyum kaynağı olması ve potasyumun kalp hastalıklarına pozitif etkisi gelir. Ancak patatesin faydaları bununla sınırlı değildir. Detaylı açıklarsak patatesin faydaları şöyle sıralanabilir:\r\n\r\nTansiyonu Dengeler: Böbrek, kalp ve beyin sağlığını riske atan yüksek tansiyon, düşük potasyum ile ilişkilendirilir. Çünkü düşük potasyum nedeniyle vücuttaki sodyum tutulur. Bu da tansiyonun yükselmesine neden olur. Patates zengin bir potasyum kaynağı olarak sodyumun dengelenmesine yardımcı olurken felç ve kalp krizi riskini de azaltmaya destektir. Patates ayrıca lifli yapısı sayesinde kolesterolü damarlardan dışarı itmekle ilişkilendirilir ve böylece kalp sağlığına katkı sağlar.\r\n\r\nAntioksidan Deposu: Serbest radikallere karşı mücadele veren antioksidanlar, bu sayede hücrelerdeki oksidatif stresin yarattığı hasarı da azaltmaya ve önlemeye yardımcı olur. Flavonoidler, karotenoidler ve fenolik asitler patatesteki antioksidanlar olarak karşımıza çıkar. Antioksidanların diyabet hastaları için de faydalı bilinir. Antioksidan zengini tatlı patatesi de anti-inflamatuar etki gösterir. Bu özellik artrit ve gut hastalığı olan kişilerin patatesi tercih etmesi için bir nedendir.\r\n\r\nBağışıklığı Güçlendirir: Güçlü bir bağışıklık grip gibi hastalıklarla ve alerjiyle savaşmak için elzemdir. Güçlü bağışıklık ise vitamin ve minerallerden zengin beslenme ile mümkündür. Patatesteki C vitamini, B6 vitamini ve potasyum güçlü bağışıklığa katkı sağlar.",
                    Price = 4.95M,
                    ImagePath = "/WebT/img/vegetable-item-5.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ProductTitle = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Weight = 1,
                    CountryOfOrigin = "Agro Farm",
                    Quality = "Organic",
                    Сheck = "Healthy",
                    MinWeight = 0.250M
                },
                new Product()
                {
                    Id = 8,
                    SubCategoryId = 8,
                    ProductName = "Native Persely",
                    Description = "Maydanoz, petroselinum crispumdur adı verilen ve yaygın olarak yetiştirilen yeşil yapraklı, çiçekli bir bitkidir. Kokusu ve tadında yoğun bir aroma bulunan maydanoz ülkemizde yaygın olarak Akdeniz Bölgesi'nde yetişir. Çok faydalı bir bitki olan maydanoz salatalara ve yemeklerin üzerine süs olarak eklenmesiyle birlikte tomatolerin içerisinde de tüketilebilir.\r\n\r\nForm olarak birçok farklı şekilde kullanılabilen maydanoz, sağlık açısından sağladığı faydalarla öne çıkar. Maydanoz temel olarak antibakteriyel etkisiyle öne çıkar. Bu sayede vücudu ve özellikle karaciğeri zararlı maddelerden korur. Kalp sağlığını destekleyen, antikanser etkisi bulunan, kemikleri güçlendiren ve kanın pıhtılaşmasını sağlayan maydanoz aynı zamanda çiğ tüketildiğinde ağız kokusunun da önüne geçebilir.",
                    Price = 4.95M,
                    ImagePath = "/WebT/img/vegetable-item-6.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ProductTitle = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Weight = 1,
                    CountryOfOrigin = "Agro Farm",
                    Quality = "Organic",
                    Сheck = "Healthy",
                    MinWeight = 0.250M
                },
                new Product()
                {
                    Id = 9,
                    SubCategoryId = 9,
                    ProductName = "Native Tomato",
                    Description = "Domatesin ana vatanı Güney ve Orta Amerika kabul ediliyor. Domates, ülkemizde Ege, Akdeniz ve Marmara bölgelerinde yoğun şekilde yetiştiriliyor. Domates, hemen her tarifte kullanıldığı için Türk mutfağının temelini oluşturan sebzelerdendir.\r\n\r\nVücut için bilinen en etkili antioksidan olan likopen en fazla domateste bulunmaktadır. Domates ayrıca C, A ve K vitamininde önemli bir kaynağıdır. Yapılan çalışmalar yüksek likopen alımının kardiovasküler sağlığa olan olumlu etkilerini göstermektedir.\r\n\r\n1 kupa (yaklaşık olarak 180 gram) domates tüketildiğinde günlük C vitamini ihtiyacının % 57,3’ü, A vitamini ihtiyacının %22,4’ünü, K vitamini ihtiyacının % 17,8’ini ve lif ihtiyacının % 7,9’ü karşılanmış olacaktır. Bunun yanında domates; potasyum, niasin, B6 vitamini ve folatında iyi bir kaynağıdır. Günlük potasyum ihtiyacının %11,4’ü, niasin ihtiyacının %5,6’sını, B6 vitamini ihtiyacının % 7,0’si ve folat ihtiyacının %6,8’i karşılanmaktadır.",
                    Price = 4.95M,
                    ImagePath = "/WebT/img/vegetable-item-1.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ProductTitle = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Weight = 1,
                    CountryOfOrigin = "Agro Farm",
                    Quality = "Organic",
                    Сheck = "Healthy",
                    MinWeight = 0.250M
                },
                new Product()
                {
                    Id = 10,
                    SubCategoryId = 10,
                    ProductName = "Native Brocoli",
                    Description = "Brokoli, lahana grubu sebzeler çatısı altında yer alan bir sebzedir. Son yıllarda besleyici değerinin anlaşılması ile tüketimi artan bir besindir. İçerdiği bazı fitokimyasal ve biyoaktif bileşikler sayesinde insan sağlığında yararlı olarak kabul edilir. Vücudu toksik bileşiklerden uzaklaştırması, hücre hasarını önlemek, hastalıklara karşı koruyucu etkinliği ile bağışıklık sistemini güçlendirmeye yardımcıdır.\r\n\r\nGlukosinolat adı verilen kükürt ve şeker bileşiklerinin parçalanması sonucu oluşan sülforafan çeşitli hastalıklara karşı koruyucudur. Son yıllarda özellikle antioksidan ve antikanserojen olması sebebiyle kanser riskinin azaltılmasında etkinlik gösterdiği bilinir. Çeşitli araştırmalara konu olan brokoli, kalp ve damar hastalıkları, meme ve prostat kanseri gibi kronik hastalıkların önlenmesinde rol oynar. Brokolinin yaklaşık %30 kısmını oluşturan çiçekleri yemeklerde çoğunlukla kullanılan kısımdır. Daha az kullanılan yaprak ve sapları önemli oranda fitokimyasal kaynağıdır.",
                    Price = 4.95M,
                    ImagePath = "/WebT/img/featur-3.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ProductTitle = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Weight = 1,
                    CountryOfOrigin = "Agro Farm",
                    Quality = "Organic",
                    Сheck = "Healthy",
                    MinWeight = 0.250M
                },
                new Product()
                {
                    Id = 11,
                    SubCategoryId = 11,
                    ProductName = "Native Bell Papper",
                    Description = "Kırmızı biber, C vitamini açısından zengindir. 2 Sağlıklı bir bağışıklık sistemini desteklemedeki rolüyle bilinen ve suda çözünen bir vitamin olan C vitamini, vücudun her yerindeki dokuların büyümesi ve onarımı için gereklidir. 5 C vitamini vücudun doğal savunmasını güçlendirebilen güçlü bir antioksidandır. Antioksidanlar ise bağışıklık sistemini güçlendiren moleküller olarak açıklanabilir. Bunu hücreleri serbest radikaller adı verilen zararlı moleküllerden koruyarak yapar. Serbest radikaller vücutta biriktiğinde, birçok kronik hastalıkla bağlantılı olan oksidatif stres olarak bilinen durumu teşvik edebilir.7, 8, 9 Ek olarak kırmızı biber faydaları arasında beyaz kan hücrelerinin daha etkili çalışmasına yardımcı olmak onları serbest radikaller gibi potansiyel zararlı moleküllerden korumak da gösterilebilir. 7\r\n\r\nC vitamini eksikliği, bağışıklığın bozulmasına ve enfeksiyonlara karşı daha yüksek duyarlılığa neden olur. Enfeksiyonlar, artan inflamasyon ve metabolik gereksinimler nedeniyle C vitamini düzeyleri etkilenir. Ayrıca, C vitamini, solunum yolu ve sistemik enfeksiyonları hem önleyebildiği hem de tedaviye yardımcı olabileceği bilinir. C vitamini hem doğuştan hem de kazanılmış bağışıklık sisteminin çeşitli hücresel fonksiyonlarını destekleyerek bağışıklık savunmasına katkıda bulunur.6 C vitamini, hücre hasarıyla savaşan, bağışıklık sisteminin mikroplara karşı tepkisini artıran ve antiinflamatuar etkiye sahip güçlü bir antioksidandır. 2 Farklı bir anlatımla C vitamini, vücudun enfeksiyona karşı korunmasına yardımcı olan, lenfositler ve fagositler olarak bilinen beyaz kan hücrelerinin üretimini teşvik etmeye yardımcı olur.7, 10 Enfeksiyon bölgesine savunma mekanizmasının önemli bir parçası olan nötrofillerin yönlendirilmesinde rol oynar. Oksidan oluşumunu ve mikrobiyal öldürmeyi artırır. Bu nedenle, kişiye enfeksiyonların zarar verilmesini önlerken, bağışıklık sisteminin patojenlere karşı yeterli bir yanıt oluşturması için C vitamininin gerekli olduğu söylenebilir. 6\r\n\r\nTüm bunlara ek olarak kırmızı biberde bulunan A vitamini de vücudu hastalıklardan ve enfeksiyonlardan koruyan bağışıklık tepkisinin uyarılmasını sağlar. B ve T hücreleri de dahil olmak üzere bazı hücrelerin oluşumunda da rol oynayan A vitamini, oksidatif stresi kontrol altında tutarak, bağışıklık sistemini güçlendirebilir ve bazı hastalıklara karşı koruma sağlayarak sağlığı olumlu yönde etkiler.",
                    Price = 4.95M,
                    ImagePath = "/WebT/img/vegetable-item-4.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ProductTitle = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Weight = 1,
                    CountryOfOrigin = "Agro Farm",
                    Quality = "Organic",
                    Сheck = "Healthy",
                    MinWeight = 0.250M
                },

                new Product()
                {
                    Id = 12,
                    SubCategoryId = 12,
                    ProductName = "Native Strawberry",
                    Description = "Vitamin ve mineralce zengin bir meyve olan çilek içeriğinde çok sayıda fitokimyasal madde bulundurur. Fitokimyasallar sebze, meyve, tahıl ve baklagillerin sağlığını koruyan ve sağlık için faydalı olan kimyasal maddelerdir. İçerisinde fitokimyasal bulunan besinleri tüketmek insan yaşamını olumsuz etkileyen kanser, kalp damar hastalıkları ve diyabet oluşmasını önlerken var olan hastalıkların tedavisinde destekleyici bir etki gösterir. Ayrıca çilek iyi bir antioksidan kaynağıdır. Antioksidanlar vücut tarafından doğal olarak üretilebilen ve besinlerle dışarıdan alınan ve vücutta hücre hasarını önleyen maddelerdir.\r\n\r\nEşsiz lezzeti ve lif, manganez, C vitamini, potasyum, folik asit gibi önemli vitamin ve mineral madde içeriği ile; taze, işlenmiş ya da dondurulmuş olarak tüketilebilen çileğin insan sağlığı açısından birden çok yararı bulunmaktadır. ",
                    Price = 4.95M,
                    ImagePath = "/WebT/img/featur-2.jpg",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    ProductTitle = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Weight = 1,
                    CountryOfOrigin = "Agro Farm",
                    Quality = "Organic",
                    Сheck = "Healthy",
                    MinWeight = 0.250M
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

            modelBuilder.Entity<Banner>().HasData(new List<Banner>()
            {
                new Banner()
                {
                    Id = 1,
                    Title = "Fresh Exotic Fruits",
                    SubTitle = "in Our Store",
                    Description = "The generated Lorem Ipsum is therefore always free from repetition injected humour, or non-characteristic words etc.",
                    Url = "/Shop/Index/",
                    UrlLabel = "BUY",
                    Price1 = "1",
                    Price2 = "50",
                    ImagePath = "/WebT/img/baner-1.png",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });

            modelBuilder.Entity<Contact>().HasData(new List<Contact>()
            {
                new Contact()
                {
                    Id = 1,
                    Location = "Siteler Mh. 14. Cadde Marmaris / Muğla",
                    Phone = "+90 123 456 78 90",
                    Mail = "oguzkaganfindikwork@gmail.com",
                    FooterTitle = "Why People Like us!",
                    FooterDescription = "typesetting, remaining essentially unchanged. It was popularised in the 1960s with the like Aldus PageMaker including of Lorem Ipsum.",
                    SiteName = "Fruitables",
                    SiteTitle = "Fresh products",
                    SiteUrl = "www.fruitables.com",
                    GoogleMapsApi = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3178.377713261835!2d28.254894376351184!3d36.8497697731265!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14c8c1a6d11a2d3d%3A0x3c8f04cf4de3624!2s14.%20Cd.%2C%20Siteler%2C%2048700%20Marmaris%2FMu%C4%9Fla!5e0!3m2!1str!2str!4v1694259649153!5m2!1str!2str",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });

            modelBuilder.Entity<Notification>().HasData(new List<Notification>()
            {
                new Notification()
                {
                    Id = 1,
                    Type = "notif-icon notif-primary",
                    Icon = "la la-user-plus",
                    Description = "Yeni Siparişiniz Var",
                    Status = false,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                },

                new Notification()
                {
                    Id = 2,
                    Type = "notif-icon notif-success",
                    Icon = "la la-comment",
                    Description = "Yeni Mesajınız Var",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });

            modelBuilder.Entity<Message>().HasData(new List<Message>()
            {
                new Message()
                {
                    Id = 1,
                    NameSurname = "Hulusi Kentmen",
                    Mail = "customer@test.com",
                    Phone = "+90 123 456 78 90",
                    Subject = "Sipariş Süresi Hakkında",
                    MessageContent = "Merhaba. Acil ürüne ihtiyacım var. Hemen sipariş versem, ne kadar sürede ulaşır?",
                    MessageSendDate = DateTime.Now,
                    Description = "Mesaj Alındı",
                    Status = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now
                }
            });
        }
    }
}