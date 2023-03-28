using Microsoft.AspNetCore.Mvc;
using Pingvinas.Event.Core.DTOs;

namespace Pingvinas.Event.Api.Controllers;

[ApiController]
[Route("api/{Controller}")]
public class UserController : ControllerBase
{
    [HttpGet("/me")]
    public async Task<ActionResult> GetMyDetails()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<ActionResult> AddUser([FromBody] UserDto user)
    {
        return Created(string.Empty,new {});
    }
    
    [HttpPut]
    public async Task<ActionResult> UpdateUser([FromBody] UserDto user)
    {
        return NoContent();
    }

    [HttpDelete("/{userId}")]
    public async Task<ActionResult> DeactivateUser(string userId)
    {
        return Ok();
    }
}