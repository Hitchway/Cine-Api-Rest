using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using AccessData;
using AccessData.Commands;
using Application.Services;
using Domain.Commands;
using System.Text.Json.Serialization;

namespace Api
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
            services.AddCors(c => {
                c.AddPolicy("AllowOrigin", options => options
                                                            .AllowAnyOrigin()
                                                            .AllowAnyMethod()
                                                            .AllowAnyHeader());
            });
            
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api", Version = "v1" });
            });
            var connectionString = Configuration.GetSection("ConnectionString").Value;
            services.AddDbContext<CineContext>(options => options.UseSqlServer(connectionString));
            services.AddAutoMapper(typeof(Startup));
            services.AddTransient<IGenericRepository, GenericRepository>();
            services.AddTransient<IPeliculasRepository, PeliculasRepository>();
            services.AddTransient<IFuncionesRepository, FuncionesRepository>();
            services.AddTransient<ITicketsRepository, TicketsRepository>();
            services.AddTransient<ISalasRepository, SalasRepository>();

            services.AddTransient<ITicketsService, TicketsService>();
            services.AddTransient<IPeliculasService,PeliculasService> ();
            services.AddTransient<IFuncionesService, FuncionesService>();
            services.AddTransient<ISalasService, SalasService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"));
            }

            app.UseCors(options => options.AllowAnyOrigin()
                                         .AllowAnyHeader()
                                         .AllowAnyHeader());
            app.UseRouting();

            //app.UseAuthorization();
            //app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
