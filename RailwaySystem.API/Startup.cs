using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using RailwaySystem.API.Data;
using RailwaySystem.API.Repository;
using RailwaySystem.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API
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
            services.AddDbContext<TrainDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlConnection")));

            services.AddTransient<IUserRepo, UserRepo>();
            services.AddTransient<UserServices, UserServices>();
            services.AddTransient<ITransactionRepo, TransactionRepo>();
            services.AddTransient<TransactionServices, TransactionServices>();
            services.AddTransient<ISeatRepo, SeatRepo>();
            services.AddTransient<SeatServices, SeatServices>();
            services.AddTransient<IBankCredRepo, BankCredRepo>();
            services.AddTransient<BankCredServices, BankCredServices>();
            services.AddTransient<ITicketRepo, TicketRepo>();
            services.AddTransient<TicketServices, TicketServices>();
            services.AddTransient<IBookingRepo, BookingRepo>();
            services.AddTransient<BookingServices, BookingServices>();
            services.AddTransient<IQuotaRepo, QuotaRepo>();
            services.AddTransient<QuotaServices, QuotaServices>();
            services.AddTransient<IRouteRepo, RouteRepo>();
            services.AddTransient<RouteServices, RouteServices>();
            services.AddTransient<ITicketRepo, TicketRepo>();
            services.AddTransient<TicketServices, TicketServices>();
            services.AddTransient<ITrainRepo, TrainRepo>();
            services.AddTransient<TrainServices, TrainServices>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RailwaySystem.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RailwaySystem.API v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
