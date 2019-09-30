using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.WebApplication1.Services.Profile;
using Company.WebApplication1.Services.Mail;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using WebApp.Context;
using WebApp.Context.Repositories;

namespace WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });

            services.Configure<CookieTempDataProviderOptions>(options =>
            {
                options.Cookie.IsEssential = true;
            });

            services.AddDbContext<WebAppContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddIdentity<ApplicationUser, IdentityRole>(config =>
            {
                config.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 -._@+";
                config.SignIn.RequireConfirmedEmail = false;
            })
                .AddEntityFrameworkStores<WebAppContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IMenuItemRepository, MenuItemRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Kiosk", Version = "v1", Description = "Web API for Kiost Test" });
               // c.IncludeXmlComments("WebApp.xml");
            });

            services.AddMvc().AddRazorPagesOptions(options =>
            {
                options.Conventions.AuthorizeFolder("/");
                options.Conventions.AllowAnonymousToPage("/Error");
                options.Conventions.AllowAnonymousToPage("/Account/AccessDenied");
                options.Conventions.AllowAnonymousToPage("/Account/ConfirmEmail");
                options.Conventions.AllowAnonymousToPage("/Account/ExternalLogin");
                options.Conventions.AllowAnonymousToPage("/Account/ForgotPassword");
                options.Conventions.AllowAnonymousToPage("/Account/ForgotPasswordConfirmation");
                options.Conventions.AllowAnonymousToPage("/Account/Lockout");
                options.Conventions.AllowAnonymousToPage("/Account/Login");
                options.Conventions.AllowAnonymousToPage("/Account/LoginWith2fa");
                options.Conventions.AllowAnonymousToPage("/Account/LoginWithRecoveryCode");
                options.Conventions.AllowAnonymousToPage("/Account/Register");
                options.Conventions.AllowAnonymousToPage("/Account/ResetPassword");
                options.Conventions.AllowAnonymousToPage("/Account/ResetPasswordConfirmation");
                options.Conventions.AllowAnonymousToPage("/Account/SignedOut");
            })
                .SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.AddSingleton<IMailManager, EmptyMailManager>();

            services.AddScoped<Company.WebApplication1.Services.Profile.ProfileManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCookiePolicy();
            app.UseStaticFiles();
            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                //c.RoutePrefix = string.Empty;
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });
        }
    }
}
