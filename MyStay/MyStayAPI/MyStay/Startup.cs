using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using MyStay.Infra;
using MyStay.Core.IDomainServices;
using MyStay.Core.ApplicationServices.Services;
using MyStay.Infra.Repositories;
using MyStay.Core.ApplicationServices.IServices;
using Swashbuckle.AspNetCore.Swagger;

namespace MyStay
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
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<ILoginServices, LoginServices>();

            services.AddScoped<IRegisteredUsersRepository, RegisteredUsersRepository>();
            services.AddScoped<IRegisteredUsersServices, RegisteredUsersServices>();

            services.AddScoped<IHotelInfoRepository, HotelInfoRepository>();
            services.AddScoped<IHotelInfoServices, HotelInfoServices>();

            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IRoomServices, RoomServices>();

            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IBookingServices, BookingServices>();

            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IPaymentServices, PaymentServices>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();


            services.AddDbContext<HotelDbContext>(options =>
          options.UseSqlServer(Configuration.GetConnectionString("HotelDatabase")));

            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My Stay API", Version = "v1" });
            }
               );

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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

            //Swagger
            app.UseSwagger();
            app.UseSwaggerUI(
                c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyStay API version 1");
                });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
