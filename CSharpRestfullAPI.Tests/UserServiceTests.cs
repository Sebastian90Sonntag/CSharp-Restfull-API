using CSharpRestfullAPI.Domain.Entities;
using CSharpRestfullAPI.Domain.Interfaces;
using CSharpRestfullAPI.Services;
using Moq;

namespace CSharpRestfullAPI.Tests;

public class UserServiceTests
{
    private readonly Mock<IUserRepository> _repoMock;
    private readonly UserService _service;

    public UserServiceTests()
    {
        _repoMock = new Mock<IUserRepository>();
        _service = new UserService(_repoMock.Object);
    }

    [Fact]
    public async Task GetUserAsync_ExistingId_ReturnsUser()
    {
        var user = new User { Id = 1, Name = "Test", Email = "test@test.com" };
        _repoMock.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(user);

        var result = await _service.GetUserAsync(1);

        Assert.NotNull(result);
        Assert.Equal("Test", result!.Name);
    }

    [Fact]
    public async Task GetUserAsync_NonExistingId_ReturnsNull()
    {
        _repoMock.Setup(r => r.GetByIdAsync(99)).ReturnsAsync((User?)null);

        var result = await _service.GetUserAsync(99);

        Assert.Null(result);
    }

    [Fact]
    public async Task GetUsersAsync_ReturnsAllUsers()
    {
        var users = new List<User>
        {
            new() { Id = 1, Name = "A", Email = "a@test.com" },
            new() { Id = 2, Name = "B", Email = "b@test.com" }
        };
        _repoMock.Setup(r => r.GetAllAsync()).ReturnsAsync(users);

        var result = await _service.GetUsersAsync();

        Assert.Equal(2, result.Count());
    }

    [Fact]
    public async Task AddUserAsync_CallsRepository()
    {
        var user = new User { Id = 1, Name = "Test", Email = "test@test.com" };

        await _service.AddUserAsync(user);

        _repoMock.Verify(r => r.AddAsync(user), Times.Once);
    }

    [Fact]
    public async Task DeleteUserAsync_CallsRepository()
    {
        await _service.DeleteUserAsync(1);

        _repoMock.Verify(r => r.DeleteAsync(1), Times.Once);
    }
}
