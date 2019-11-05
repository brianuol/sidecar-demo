using Serilog;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Steeltoe.Management.Endpoint.CloudFoundry;
using Steeltoe.Management.Endpoint.Health;
using Steeltoe.Management.Endpoint.Info;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using System.Reflection;
namespace Petstore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IContainer ApplicationContainer { get; private set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            services
                .AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(opts =>
                  {
                      opts.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                      opts.SerializerSettings.Converters.Add(new StringEnumConverter
                      {
                          CamelCaseText = true
                      });
                  })
                .AddXmlSerializerFormatters();

            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Petstore",
                    Description = "A simple example ASP.NET Core Web API (generated based on Open-API spec)",
                    TermsOfService = new Uri("https://mastercard.com/terms"),
                    Contact = new OpenApiContact()
                    {
                        Name = "John Q. Dev",
                        Email = string.Empty,
                        Url = new Uri("https://github.com/"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT",
                        Url = new Uri("https://opensource.org/licenses/MIT"),
                    }
                });

                c.DescribeAllEnumsAsStrings();

            });

            services.AddCloudFoundryActuator(Configuration);
            services.AddInfoActuator(Configuration);
            services.AddHealthActuator(Configuration);

            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                    .Where(t=>t.Name.EndsWith("Service"))
                    .AsImplementedInterfaces();
            this.ApplicationContainer = builder.Build();
            return new AutofacServiceProvider(this.ApplicationContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Petstore v1");
            });

            //app.UseHttpsRedirection();
            app.UseSerilogRequestLogging();
            app.UseMvc();

            app.UseCloudFoundryActuator();
            app.UseInfoActuator();
            app.UseHealthActuator();
        }
    }
}
