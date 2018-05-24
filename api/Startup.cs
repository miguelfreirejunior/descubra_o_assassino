using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Services;
using api.Services.Impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace api
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
            services.AddDistributedMemoryCache();
            services.AddMvc();
            services.AddCors();

            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new Info { Title = "Game API", Version = "v1" });
                });

            services.AddSingleton<IGameService, GameService>();
            services.AddSingleton<IArmaService, ArmaService>();
            services.AddSingleton<ILocalService, LocalService>();
            services.AddSingleton<ISuspeitoService, SuspeitoService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();

                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Game API V1");
                });
            }

            

            // var policy = new Microsoft.AspNet.Cors.Infrastructure.CorsPolicy();

            // policy.Headers.Add("*");
            // policy.Methods.Add("*");
            // policy.Origins.Add("*");
            // policy.SupportsCredentials = true;

            // services.AddCors(x => x.AddPolicy("corsGlobalPolicy", policy));
            
             app.UseCors(builder =>
                 builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.UseMvc();
        }
    }
}
