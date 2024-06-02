using CarBookApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Persistence.Context
{
    public class CarBookContext : DbContext
    {
        /*
         CQRS DESING PATTERN
        -Yazma ve Okuma işlemlerini ayırmak üzerine.
        -Bir Metot objenin durumunu değiştirmeli.
        -Ya da metot gerye bir sonuç dönmelidir.
        -Performans, güvenlik ölçeklenebilirlik.
        -Yazma: Create - Update- Delete
        -Okuma: List - GetByID

        Commands: Select, Update, Delete propları
        Queries: Şartlı listeleme işlemlerinin propları
        Handlers: Crud işlemleri
        Results: Listeleme işlemlerinin propları

        Commands: Objenin durumunu değiştirir. Yani save changes kullanılır.
        Queries: Sonucu geriye döner ( return ) ** Genellikle "Get" ön eki ile isimlendirilirler. **

         */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=G™RKEMH; Database=CarBookApp; Uid=sa; Pwd=123;");
            optionsBuilder.UseSqlServer("Server=G™RKEMH; initial Catalog=CarBookAppDB; integrated Security=true; TrustServerCertificate=true ");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
