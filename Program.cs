using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using WorkerService1.Data;
using WorkerService1.Services;

var builder = WebApplication.CreateBuilder(args);

// API
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection")));

// Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "UpStyle API",
        Version = "v1",
        Description = "API da consultoria UpStyle"
    });
});

// Singleton
builder.Services.AddSingleton<ConfigurationService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "UpStyle API v1");
        c.RoutePrefix = string.Empty; // Define Swagger UI como a página inicial
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();