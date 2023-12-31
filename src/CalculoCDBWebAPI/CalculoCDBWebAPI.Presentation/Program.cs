using CalculoCDBWebAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using CalculoCDBWebAPI.Infrastructure.CrossCutting.IOC;
//using Autofac;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("database");
builder.Services.AddDbContext<SqlContext>(options => options.UseSqlServer(connectionString));

//builder.RegisterModule(new ModuloIOC());
builder.Services.DependencyMap();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
