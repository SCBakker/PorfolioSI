using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PorfolioV2.Data;

[assembly: HostingStartup(typeof(PorfolioV2.Areas.Identity.IdentityHostingStartup))]
namespace PorfolioV2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PorfolioV2Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PorfolioV2ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<PorfolioV2Context>();
            });
        }
    }
}