// ------------------------------------------------------------
// Infrastruktur (Infrastructure Layer)
// ------------------------------------------------------------
namespace CSharpRestfullAPI.Infrastructure.Data
{
  using CSharpRestfullAPI.Domain.Entities;
  using CSharpRestfullAPI.Domain.Interfaces;
  using Microsoft.EntityFrameworkCore;

  public class AppDbContext(DbContextOptions options) : DbContext(options)
  {
    public DbSet<User> Users => Set<User>();
  }
}