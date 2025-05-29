// ------------------------------------------------------------
// Anwendung (Application Layer)
// ------------------------------------------------------------

namespace CSharpRestfullAPI.Services
{
  using CSharpRestfullAPI.Domain.Entities;
  using CSharpRestfullAPI.Domain.Interfaces;

  public class UserService(IUserRepository repository)
  {
    private readonly IUserRepository _repository = repository;

    public Task<User?> GetUserAsync(int id) => _repository.GetByIdAsync(id: id);
    public Task<IEnumerable<User>> GetUsersAsync() => _repository.GetAllAsync();
    public async Task AddUserAsync(User user) => await _repository.AddAsync(user: user);
    public async Task UpdateUserAsync(User user) => await _repository.UpdateAsync(user: user);
    public async Task DeleteUserAsync(int id) => await _repository.DeleteAsync(userId: id);
  }
}