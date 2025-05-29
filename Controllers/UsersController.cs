// ------------------------------------------------------------
// API / Presentation Layer
// ------------------------------------------------------------

namespace CSharpRestfullAPI.Controllers
{
  using CSharpRestfullAPI.Services;
  using CSharpRestfullAPI.Domain.Entities;
  using Microsoft.AspNetCore.Mvc;

  [ApiController]
  [Route(template: "api/[controller]")]
  public class UsersController : ControllerBase
  {
    private readonly UserService _service;

    public UsersController(UserService service)
    {
      _service = service;
    }

    [HttpGet(template: "{id}")]
    public async Task<IActionResult> Get(int id)
    {
      User? user = await _service.GetUserAsync(id: id);
      return user is not null ? Ok(value: user) : NotFound();
    }

    [HttpGet]
    public async Task<IEnumerable<User>> GetAll() => await _service.GetUsersAsync();

    [HttpPost]
    public async Task<IActionResult> Create(User user)
    {
      await _service.AddUserAsync(user: user);
      return CreatedAtAction(actionName: nameof(Get), routeValues: new { id = user.Id }, value: user);
    }
  }
}