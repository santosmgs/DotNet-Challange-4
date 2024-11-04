using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using WorkerService1.Data;

namespace WorkerService1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<AppDbContext>(options =>
                options.UseOracle("User Id=rm551640;Password=140105;Data Source=oracle.fiap.com.br:1521/orcl>")); // Mantenha a conexão como está

            // Adicione serviços aqui, por exemplo, serviços para ML.NET
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "UpStyle API",
                    Version = "v1",
                    Description = "API da consultoria UpStyle"
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "UpStyle API v1");
                    c.RoutePrefix = string.Empty; // Define Swagger UI como a página inicial
                });
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}