using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Projeto.Presentation.Mappings;
using Swashbuckle.AspNetCore.Swagger;

namespace Projeto.Presentation
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
            services.AddMvc();

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ViewModelToEntityMap>();
                cfg.AddProfile<EntityToViewModelMap>();
            });

            services.AddSwaggerGen(
                s =>
                {
                    s.SwaggerDoc("v1",
                        new Info
                        {
                            Title = "Projeto Controle de Clientes",
                            Description = "Curso c# WebDevelopment",
                            Version = "v1",
                            Contact = new Contact
                            {
                                Name = "Coti Informatica",
                                Email = "coti@informatica.com.br",
                                Url = "http://www.cotiinformatica.com.br"
                            }
                        });
                });

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
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(
                s =>
                {
                    s.SwaggerEndpoint("/swagger/v1/swagger.json", "projeto");
                });

}
    }
}
