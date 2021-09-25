using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;
using Ecommerce.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Ecommerce.Models
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Models.Product> ProductTable { get; set; }
        public virtual DbSet<Models.Cart> Cart { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("EcommerceDBContextConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            // Product Data
            builder.Entity<Models.Product>().HasData(
                new Models.Product {
                    Id = 1,
                    Name = "Redragon Keyboard",
                    Description = "PC GAMING KEYBOARD AND GAMING MOUSE COMBO: Includes Redragon RGB Backlit Computer Gaming Keyboard and RGB Backlit Gaming Mouse. ALL-IN-ONE PC GAMER VALUE KIT, Fantastic for Gamers (New Improved Version)",
                    Price = 4000,
                    Stock = 200,
                    Category = "Keyboard",
                    MainImageURL = "https://m.media-amazon.com/images/I/71kr3WAj1FL._AC_SL1500_.jpg",
                    ImageURL1 = "https://m.media-amazon.com/images/I/71uIslKmtoL._AC_SL1500_.jpg",
                    ImageURL2 = "https://m.media-amazon.com/images/I/71H6y1GGbAL._AC_SL1500_.jpg"
                },
                new Models.Product {
                    Id = 2,
                    Name = "RK ROYAL KLUDGE",
                    Description = "Mini 60% Keyboard: RK61 mini 60% gaming keyboard is a ultra-compact layout with 61 keys makes you a neat desktop with your organized gears on, even folks have nothing to do with Minimalist will dive into its tiny practical design. Tips you might want to know is that keyboard without numpad is most FPS gamers' choice, more spaces left for mouse movements.",
                    Price = 3000,
                    Stock = 100,
                    Category = "Keyboard",
                    MainImageURL = "https://m.media-amazon.com/images/I/61mBAMckzJL._AC_SL1500_.jpg",
                    ImageURL1 = "https://m.media-amazon.com/images/I/71ji90FcW4L._AC_SL1500_.jpg",
                    ImageURL2 = "https://m.media-amazon.com/images/I/71TYtZyvCrS._AC_SL1500_.jpg"
                },
                new Models.Product {
                    Id = 3,
                    Name = "SkyTech Blaze II",
                    Description = "Ryzen 5 3600 6-Core 3.6GHz (4.2GHz Max Boost) CPU Processor | 500G SSD – Up to 30x Faster Than Traditional HDD NVIDIA GeForce GTX 1660 Super 6GB GDDR5 Video Card | 16 GB Gaming Memory DDR4 3000 with Heat Spreader | Windows 10 Home 64 - bit",
                    Price = 60000,
                    Stock = 50,
                    Category = "CPU",
                    MainImageURL = "https://m.media-amazon.com/images/I/81Vm7yrdKCL._AC_SL1500_.jpg",
                    ImageURL1 = "https://m.media-amazon.com/images/I/71kwAe2O6xL._AC_SL1500_.jpg",
                    ImageURL2 = "https://m.media-amazon.com/images/I/9182gfeh28L._AC_SL1500_.jpg"
                },
                new Models.Product {
                    Id = 4,
                    Name = "PlayStation 5 Console",
                    Description = "Lightning Speed - Harness the power of a custom CPU, GPU, and SSD with Integrated I/O that rewrite the rules of what a PlayStation console can do. Stunning Games - Marvel at incredible graphics and experience new PS5 features.",
                    Price = 50000,
                    Stock = 400,
                    Category = "Games",
                    MainImageURL = "https://m.media-amazon.com/images/I/71vWi5Iuz3L._SL1500_.jpg",
                    ImageURL1 = "https://m.media-amazon.com/images/I/619BkvKW35L._SL1500_.jpg",
                    ImageURL2 = "https://m.media-amazon.com/images/I/71v7RDRYBTL._SL1500_.jpg"
                },
                new Models.Product {
                    Id = 5,
                    Name = "Sony PULSE 3D Wireless Headset",
                    Description = "Built for a new generation - Fine-tuned for 3D Audio on PS5 consoles. Enjoy comfortable gaming with refined earpads and headband strap. Play in style with a sleek design that complements the PS5 console. Available when feature is supported by game.",
                    Price = 6000,
                    Stock = 300,
                    Category = "Headphones",
                    MainImageURL = "https://m.media-amazon.com/images/I/610SsJ5aAQL._SL1393_.jpg",
                    ImageURL1 = "https://m.media-amazon.com/images/I/71lrh6vzPcL._SL1500_.jpg",
                    ImageURL2 = "https://m.media-amazon.com/images/I/71tU3AxObuL._SL1500_.jpg"
                },
                new Models.Product {
                    Id = 6,
                    Name = "Sony PULSE 2D Wireless Headset",
                    Description = "Built for a new generation - Fine-tuned for 2D Audio on PS6 consoles. Enjoy comfortable gaming with refined earpads and headband strap. Play in style with a sleek design that complements the PS5 console. Available when feature is supported by game.",
                    Price = 2000,
                    Stock = 100,
                    Category = "Headphones",
                    MainImageURL = "https://m.media-amazon.com/images/I/610SsJ5aAQL._SL1393_.jpg",
                    ImageURL1 = "https://m.media-amazon.com/images/I/71lrh6vzPcL._SL1500_.jpg",
                    ImageURL2 = "https://m.media-amazon.com/images/I/71tU3AxObuL._SL1500_.jpg"
                },
                new Models.Product {
                    Id = 7,
                    Name = "Redragon Keyboard",
                    Description = "PC GAMING KEYBOARD AND GAMING MOUSE COMBO: Includes Redragon RGB Backlit Computer Gaming Keyboard and RGB Backlit Gaming Mouse. ALL-IN-ONE PC GAMER VALUE KIT, Fantastic for Gamers (New Improved Version)",
                    Price = 4000,
                    Stock = 200,
                    Category = "Keyboard",
                    MainImageURL = "https://m.media-amazon.com/images/I/71kr3WAj1FL._AC_SL1500_.jpg",
                    ImageURL1 = "https://m.media-amazon.com/images/I/71uIslKmtoL._AC_SL1500_.jpg",
                    ImageURL2 = "https://m.media-amazon.com/images/I/71H6y1GGbAL._AC_SL1500_.jpg"
                },
                new Models.Product {
                    Id = 8,
                    Name = "RK ROYAL KLUDGE",
                    Description = "Mini 60% Keyboard: RK61 mini 60% gaming keyboard is a ultra-compact layout with 61 keys makes you a neat desktop with your organized gears on, even folks have nothing to do with Minimalist will dive into its tiny practical design. Tips you might want to know is that keyboard without numpad is most FPS gamers' choice, more spaces left for mouse movements.",
                    Price = 3000,
                    Stock = 100,
                    Category = "Keyboard",
                    MainImageURL = "https://m.media-amazon.com/images/I/61mBAMckzJL._AC_SL1500_.jpg",
                    ImageURL1 = "https://m.media-amazon.com/images/I/71ji90FcW4L._AC_SL1500_.jpg",
                    ImageURL2 = "https://m.media-amazon.com/images/I/71TYtZyvCrS._AC_SL1500_.jpg"
                },
                new Models.Product {
                    Id = 9,
                    Name = "SkyTech Blaze II",
                    Description = "Ryzen 5 3600 6-Core 3.6GHz (4.2GHz Max Boost) CPU Processor | 500G SSD – Up to 30x Faster Than Traditional HDD NVIDIA GeForce GTX 1660 Super 6GB GDDR5 Video Card | 16 GB Gaming Memory DDR4 3000 with Heat Spreader | Windows 10 Home 64 - bit",
                    Price = 60000,
                    Stock = 50,
                    Category = "CPU",
                    MainImageURL = "https://m.media-amazon.com/images/I/81Vm7yrdKCL._AC_SL1500_.jpg",
                    ImageURL1 = "https://m.media-amazon.com/images/I/71kwAe2O6xL._AC_SL1500_.jpg",
                    ImageURL2 = "https://m.media-amazon.com/images/I/9182gfeh28L._AC_SL1500_.jpg"
                },
                new Models.Product {
                    Id = 10,
                    Name = "PlayStation 5 Console",
                    Description = "Lightning Speed - Harness the power of a custom CPU, GPU, and SSD with Integrated I/O that rewrite the rules of what a PlayStation console can do. Stunning Games - Marvel at incredible graphics and experience new PS5 features.",
                    Price = 50000,
                    Stock = 400,
                    Category = "Games",
                    MainImageURL = "https://m.media-amazon.com/images/I/71vWi5Iuz3L._SL1500_.jpg",
                    ImageURL1 = "https://m.media-amazon.com/images/I/619BkvKW35L._SL1500_.jpg",
                    ImageURL2 = "https://m.media-amazon.com/images/I/71v7RDRYBTL._SL1500_.jpg"
                },
                new Models.Product {
                    Id = 11,
                    Name = "Sony PULSE 3D Wireless Headset",
                    Description = "Built for a new generation - Fine-tuned for 3D Audio on PS5 consoles. Enjoy comfortable gaming with refined earpads and headband strap. Play in style with a sleek design that complements the PS5 console. Available when feature is supported by game.",
                    Price = 6000,
                    Stock = 300,
                    Category = "Headphones",
                    MainImageURL = "https://m.media-amazon.com/images/I/610SsJ5aAQL._SL1393_.jpg",
                    ImageURL1 = "https://m.media-amazon.com/images/I/71lrh6vzPcL._SL1500_.jpg",
                    ImageURL2 = "https://m.media-amazon.com/images/I/71tU3AxObuL._SL1500_.jpg"
                }
            );
        }
    }
}
