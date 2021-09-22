using System;
using Ecommerce.Areas.Identity.Data;
using Ecommerce.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Ecommerce.Areas.Identity.IdentityHostingStartup))]
namespace Ecommerce.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EcommerceDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EcommerceDBContextConnection")));

                services.AddDefaultIdentity<EcommerceAppUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<EcommerceDBContext>();
            });
        }
    }
}