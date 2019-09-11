using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;

namespace CmdApi
{
  public class Startup
  {
    // Register your services
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new Info
        {
          Version = "v1",
          Title = "Commands API",
          Description = "My First ASP.NET Core Web API",
          TermsOfService = "None",
        });
      });
    }

    // Use this method to configure the HTTP request pipeline. (Use your services)
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      app.UseMvc();
      app.UseSwagger();
      app.UseSwaggerUI(e =>
      {
        e.SwaggerEndpoint("/swagger/v1/swagger.json", "My API");
      });
    }
  }
}
