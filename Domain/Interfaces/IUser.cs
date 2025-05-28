// ------------------------------------------------------------
// Domäne (Domain Layer)
// ------------------------------------------------------------

using CSharpRestfullAPI.Domain.Entities;

namespace CSharpRestfullAPI.Domain.Interfaces
{
  public interface IUserRepository
  {
    Task<User?> GetByIdAsync(int id);
    Task<IEnumerable<User>> GetAllAsync();
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(int userId);
  }
}