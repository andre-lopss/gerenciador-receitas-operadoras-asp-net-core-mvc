using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GerenciadorDeOperadorasMVC.Models;
using GerenciadorDeOperadorasMVC.Data;
using GerenciadorDeOperadorasMVC.Services;

namespace GerenciadorDeOperadorasMVC
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
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<GerenciadorDeOperadorasMVCContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("GerenciadorDeOperadorasMVCContext"), builder =>
                        builder.MigrationsAssembly("GerenciadorDeOperadorasMVC")));

            services.AddScoped<ServicoPopularBase>();
            services.AddScoped<BeneficiarioService>();
            services.AddScoped<OperadoraService>();
            services.AddScoped<RegistroPlanosService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ServicoPopularBase servicoPopularBase)
        {
            var ptBr = new CultureInfo("pt-BR");
            var localizationOptions = new
                RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ptBr),
                SupportedCultures = new List<CultureInfo> { ptBr },
                SupportedUICultures = new List<CultureInfo> { ptBr }
            };

            app.UseRequestLocalization(localizationOptions);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                servicoPopularBase.Popular();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
