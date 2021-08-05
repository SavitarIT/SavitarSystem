using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Savitar.Bootstrapper;
using Savitar.Domain.Models;
using Savitar.Infrastructure.Repository.EFCore;
using Savitar.WebAssembly.Blockchain.Ethereum;

namespace WebApplication3.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            // Response Caching Middleware
            services.AddResponseCaching(options =>
            {
                // Each response cannot be more than 1 KB 
                options.MaximumBodySize = 1024;

                // Case Sensitive Paths 
                // Responses to be returned only if case sensitive paths match
                options.UseCaseSensitivePaths = true;
            });

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    x => x.MigrationsAssembly("Savitar.Infrastructure.Repository.EFCore")
                ));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddIdentityServer().AddApiAuthorization<ApplicationUser, ApplicationDbContext>();
            services.AddAuthentication().AddIdentityServerJwt();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Savitar.Server", Version = "v1" });
            });

            
            services.AddSavitarServices();

            var infuraApiKey = Configuration.GetSection("Infura")["APIKey"];
            services.AddSavitarBlockchainEthereumServices(infuraApiKey);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Savitar.Server v1"));
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            // CORS Should be before Response Caching 
            //app.UseCors();

            app.UseResponseCaching();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
