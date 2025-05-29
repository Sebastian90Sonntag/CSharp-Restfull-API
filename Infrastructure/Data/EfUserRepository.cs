// ------------------------------------------------------------
// Infrastruktur (Infrastructure Layer)
// ------------------------------------------------------------

namespace CSharpRestfullAPI.Infrastructure.Data
{
  using Domain.Entities;
  using Domain.Interfaces;
  using Microsoft.EntityFrameworkCore;

  public class EfUserRepository(AppDbContext context) : IUserRepository
  {
    private readonly AppDbContext _context = context;

    public async Task<User?> GetByIdAsync(int id) => await _context.Users.FindAsync(id);
    public async Task<IEnumerable<User>> GetAllAsync() => await _context.Users.ToListAsync();
    public async Task AddAsync(User user)
    {
      _context.Users.Add(entity: user);
      await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(User user)
    {
      User? existingUser = await _context.Users.FindAsync(user.Id);
      if (existingUser == null) return;
      await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int userId)
    {
      User? user = await _context.Users.FindAsync(userId);
      if (user != null)
      {
        _context.Users.Remove(entity: user);
        await _context.SaveChangesAsync();
      }
    }
  }
}