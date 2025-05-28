// ------------------------------------------------------------
// API / Presentation Layer
// ------------------------------------------------------------

namespace CSharpRestfullAPI.Controllers
{
  using CSharpRestfullAPI.Services;
  using CSharpRestfullAPI.Domain.Entities;
  using Microsoft.AspNetCore.Mvc;

  [ApiController]
  [Route("api/[controller]")]
  public class UsersController : ControllerBase
  {
    private readonly UserService _service;

    public UsersController(UserService service)
    {
      _service = service;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
      var user = await _service.GetUserAsync(id);
      return user is not null ? Ok(user) : NotFound();
    }

    [HttpGet]
    public async Task<IEnumerable<User>> GetAll() => await _service.GetUsersAsync();

    [HttpPost]
    public async Task<IActionResult> Create(User user)
    {
      await _service.AddUserAsync(user);
      return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
    }
  }
}