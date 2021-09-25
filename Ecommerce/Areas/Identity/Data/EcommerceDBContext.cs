using System.IO;
using Ecommerce.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Ecommerce.Data
{
    public class EcommerceDBContext : IdentityDbContext<EcommerceAppUser>
    {
        public override DbSet<EcommerceAppUser> Users { get; set; }
        public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options)
            : base(options)
        {
        }

        public EcommerceDBContext()
        {
        }
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
    }
}
