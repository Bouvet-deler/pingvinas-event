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
        return await Task.Run(() =>
        {
            return Ok();
        });
    }

    [HttpPost]
    public async Task<ActionResult> AddUser([FromBody] UserDto user)
    {
        return await Task.Run(() =>
        {
            return Created(string.Empty,new {});
        });
    }
    
    [HttpPut]
    public async Task<ActionResult> UpdateUser([FromBody] UserDto user)
    {
        return await Task.Run(() =>
        {
            return NoContent();
        });
    }

    [HttpDelete("/{userId}")]
    public async Task<ActionResult> DeactivateUser(string userId)
    {
        return await Task.Run(() =>
        {
            return Ok();
        });
    }
}