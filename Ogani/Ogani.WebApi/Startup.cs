using System;
using System.Linq;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ogani.Application.Models.DataContext;

namespace Ogani.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<OganiDbContext>(cfg =>
            {
                //cfg.UseSqlServer(Configuration.GetConnectionString("cString"));
                cfg.UseSqlServer(Configuration.GetConnectionString("cStringWindows"));
            });

            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("Ogani")).ToArray() );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            }) ;
        }
    }
}

