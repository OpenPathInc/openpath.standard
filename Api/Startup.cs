using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using OpenPath.Standard.Base.Repository;
using OpenPath.Standard.Base.Repository.Interface;
using OpenPath.Standard.Base.Service;
using OpenPath.Standard.Base.Service.Interface;
using System.Text.Json.Serialization;

namespace OpenPath.Standard.Api {
    public class Startup {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) {

            Configuration = configuration;

        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            services.AddDbContext<StandardDbContext>(_ => _.UseSqlServer(Configuration.GetConnectionString("StandardDbContext")));
            services.AddScoped<IStandardUnitOfWork, StandardUnitOfWork>();

            services.AddScoped<IPlanetService, PlanetService>();

            services
                .AddControllers()
                .AddJsonOptions(
                    _ =>
                    _.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter())
                );

            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OpenPath.Standard.Api", Version = "v1" });
                c.UseInlineDefinitionsForEnums();
            });

            services.AddSwaggerGenNewtonsoftSupport();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApplication2 v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
