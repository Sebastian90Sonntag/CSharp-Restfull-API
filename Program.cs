// RESTful UserService in C# .NET 8
// Fokus: Moderne Softwarearchitektur (Schichten, SOLID, Clean Architecture)

// ------------------------------------------------------------
// Startup / Dependency Injection (Program.cs in .NET 8)
// ------------------------------------------------------------

using CSharpRestfullAPI.Services;
using CSharpRestfullAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using CSharpRestfullAPI.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. -> configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

if(builder.Environment.IsDevelopment())
{
  builder.Services.AddDbContext<AppDbContext>(opt =>
      opt.UseInMemoryDatabase("TestDb"));
}
else
{
  // Beispiel für echte Datenbank (z.B. SQLite)
  // builder.Services.AddDbContext<AppDbContext>(opt =>
  //     opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
}

builder.Services.AddScoped<IUserRepository, EfUserRepository>();
builder.Services.AddScoped<UserService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
// MapControllers sollte immer aufgerufen werden
app.MapControllers();

app.UseHttpsRedirection();

app.Run();