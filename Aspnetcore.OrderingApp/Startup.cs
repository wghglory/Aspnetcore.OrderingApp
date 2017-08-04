using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aspnetcore.OrderingApp.Infrastructure;
using Aspnetcore.OrderingApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Aspnetcore.OrderingApp
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            
//            services.Configure<RazorViewEngineOptions>(opts =>
//            {
//                opts.ViewLocationExpanders.Clear();
//                opts.ViewLocationExpanders.Add(new ThemeExpander());
//            });
            
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<ISurveyService, SurveyService>();
            services.AddScoped<IFormDataService, FormDataService>();

            // Autofac setup
//            var builder = new ContainerBuilder();
//            builder.Populate(services);
//            builder.RegisterType<InventoryService>().As<IInventoryService>();
//            builder.RegisterType<SurveyService>().As<ISurveyService>();
//            builder.RegisterType<FormDataService>().As<IFormDataService>();
//            return new AutofacServiceProvider(builder.Build());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}