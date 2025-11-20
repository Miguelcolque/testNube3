using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using conectarNuve1.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<conectarNuve1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("conectarNuve1Context") ?? throw new InvalidOperationException("Connection string 'conectarNuve1Context' not found.")));

// Add services to the container.
builder.WebHost.UseUrls("http://0.0.0.0:8080");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
