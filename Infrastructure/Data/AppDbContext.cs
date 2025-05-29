// ------------------------------------------------------------
// Infrastruktur (Infrastructure Layer)
// ------------------------------------------------------------
namespace CSharpRestfullAPI.Infrastructure.Data
{
  using CSharpRestfullAPI.Domain.Entities;
  using Microsoft.EntityFrameworkCore;

  public class AppDbContext(DbContextOptions options) : DbContext(options: options)
  {
    public DbSet<User> Users => Set<User>();
  }
}