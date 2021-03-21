using System;
using Clean9.Web.Areas.Identity.Data;
using Clean9.Web.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Clean9.Web.Areas.Identity.IdentityHostingStartup))]
namespace Clean9.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Clean9WebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SQLServerConnection")));

                services.AddDefaultIdentity<Clean9WebUser>(options => options.SignIn.RequireConfirmedAccount = true)
                        .AddRoles<IdentityRole>()
                        .AddEntityFrameworkStores<Clean9WebContext>();
            });
        }
    }
}