using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using OpenPath.Standard.Base.Repository;
using OpenPath.Standard.Base.Repository.Interface;
using OpenPath.Standard.Base.Service;
using OpenPath.Standard.Base.Service.Interface;
using System;
using System.IO;

namespace OpenPath.Standard.Api {

    /// <summary>
    /// The entry point to the application, setting up configuration and wiring up services the
    /// application will use.
    /// </summary>
    public class Startup {

        // PROPERTIES
        // ====================================================================================================

        /// <summary>
        /// Represents a set of key/value application configuration properties.
        /// </summary>
        public IConfiguration Configuration { get; }



        // CONTRUCTORS
        // ====================================================================================================

        /// <summary>
        /// The start up constructor for this class.
        /// </summary>
        /// <param name="configuration">Represents a set of key/value application configuration properties.</param>
        public Startup(IConfiguration configuration) {

            Configuration = configuration;

        }



        // METHODS
        // ====================================================================================================

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">Specifies the contract for a collection of service descriptors.</param>
        public void ConfigureServices(IServiceCollection services) {

            // inject the database context and unit of work
            services.AddDbContext<StandardDbContext>(_ => _.UseSqlServer(Configuration.GetConnectionString("StandardDbContext")));
            services.AddScoped<IStandardUnitOfWork, StandardUnitOfWork>();

            // inject the services
            services.AddScoped<IPlanetService, PlanetService>();

            // configure the api controllers
            services
                .AddControllers()
                .AddNewtonsoftJson(
                    _ =>
                    _.SerializerSettings.Converters.Add(
                        new StringEnumConverter {
                            NamingStrategy = new SnakeCaseNamingStrategy()
                        }
                    )
                );

            // configure swagger
            services
                .AddSwaggerGen(c => {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "OpenPath.Standard.Api", Version = "v1" });
                    c.IncludeXmlComments($"{Directory.GetParent(Environment.CurrentDirectory).FullName}/OpenPath.Standard.Api.xml");
                    c.IncludeXmlComments($"{Directory.GetParent(Environment.CurrentDirectory).FullName}/OpenPath.Standard.Base.Data.xml");
                    c.IncludeXmlComments($"{Directory.GetParent(Environment.CurrentDirectory).FullName}/OpenPath.Standard.Base.Repository.xml");
                    c.IncludeXmlComments($"{Directory.GetParent(Environment.CurrentDirectory).FullName}/OpenPath.Standard.Base.Service.xml");
                    c.IncludeXmlComments($"{Directory.GetParent(Environment.CurrentDirectory).FullName}/OpenPath.Utility.Repository.xml");
                    c.UseInlineDefinitionsForEnums();
                }).AddSwaggerGenNewtonsoftSupport();

        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">
        /// Defines a class that provides the mechanisms to configure an application's request pipeline.
        /// </param>
        /// <param name="env">
        /// Provides information about the web hosting environment an application is running in.
        /// </param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {

            // if the application is in development mode set these attributes
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Standards REST API v1"));
            }

            // configure https redirection for http requests
            // TODO: Don't think we need UseHttpsRedirection.
            app.UseHttpsRedirection();

            // configure controller routing
            app.UseRouting();

            // TODO: Don't think we need UseAuthorization.
            //app.UseAuthorization();

            // configure end-point routing
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

        }

    }

}
