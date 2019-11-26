using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticateService.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using AuthenticateService.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AuthenticateService
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
            services.AddDbContext<LoginContext>(opts => opts.UseSqlServer(Configuration["ConnectionStrings:MOD_Db1"]));
            services.AddTransient<ILoginInterface,LoginRepository>();
            
            services.AddControllers();
            services.AddAuthentication
(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options =>
{
   options.TokenValidationParameters = new TokenValidationParameters
   {
       ValidateIssuer = true,
       ValidateAudience = true,
       ValidateLifetime = true,
       ValidateIssuerSigningKey = true,
       ValidIssuer = Configuration["Jwt:Issuer"],
       ValidAudience = Configuration["Jwt:Audience"],
       IssuerSigningKey = new SymmetricSecurityKey
 (Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
   };
});
            services.AddCors(options =>
            {
                options.AddPolicy("SabKaSwagat", builder =>
                 builder.AllowAnyOrigin()
                 .AllowAnyHeader()
                 .AllowAnyMethod()
                );
            }
           );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("SabKaSwagat");
//            services.AddAuthentication
//(JwtBearerDefaults.AuthenticationScheme)
//.AddJwtBearer(options =>
//{
//    options.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateIssuer = true,
//        ValidateAudience = true,
//        ValidateLifetime = true,
//        ValidateIssuerSigningKey = true,
//        ValidIssuer = Configuration["Jwt:Issuer"],
//        ValidAudience = Configuration["Jwt:Audience"],
//        IssuerSigningKey = new SymmetricSecurityKey
//  (Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
//    };
//});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
