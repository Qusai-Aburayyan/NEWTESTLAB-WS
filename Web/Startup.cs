using Core.Entites.ApplicationUser;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Web
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(_configuration => {
                var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();
                _configuration.Filters.Add(new AuthorizeFilter(policy));
                });

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDataContext>();

            var connectingstring = _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDataContext>(options =>
            {
                options.UseSqlServer(connectingstring);
            });

            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDataContext context, UserManager<ApplicationUser> userManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area=Admin}/{controller=account}/{action=login}/{id?}");

            });

            DummyData.Initialize(context, userManager).Wait();
        }
    }
}
