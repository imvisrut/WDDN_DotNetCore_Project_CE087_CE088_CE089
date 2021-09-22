using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class EcommerceDBContext : IdentityDbContext<EcommerceAppUser>
    {
        public virtual DbSet<Models.Product> ProductTable { get; set; }
        public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options)
            : base(options)
        {
        }

        public EcommerceDBContext()
        {
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
                }
            );
        }
    }
}
