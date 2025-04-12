using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SampleDataController : ControllerBase
{
    [HttpGet("public")]
    public IActionResult Public() => Ok("This is a public endpoint.");

    [Authorize]
    [HttpGet("private")]
    public IActionResult Private() => Ok("You are authenticated!");

    [Authorize]
    [HttpGet("profile")]
    public IActionResult Profile() => Ok(new { user = User.Identity?.Name });
}