using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BeSpokedBikes.Web
{
    public class Startup
    {
        public Startup(IWebHostEnvironment env)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile($"appsettings.json", false)
                .AddEnvironmentVariables();

            this.Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc(opt =>
            {
                opt.EnableEndpointRouting = false;
            });

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
        {
            configuration.RootPath = "client/build";
        });

            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin()
                        .WithExposedHeaders("WWW-Authenticate");
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())  app.UseDeveloperExceptionPage();       
            else app.UseHsts();
            
            string pathBase = this.Configuration["PATH_BASE"];

            if (!string.IsNullOrEmpty(pathBase)) app.UsePathBase(pathBase);

            app.UseCors("CorsPolicy");

            app.UseStaticFiles();

            app.UseMvc();

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "client";

                if (env.IsDevelopment()) spa.UseReactDevelopmentServer(npmScript: "start");
            });

            app.UseHttpsRedirection();

        }
    }
}
