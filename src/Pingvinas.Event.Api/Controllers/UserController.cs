using Microsoft.AspNetCore.Mvc;
using Pingvinas.Event.Core.DTOs;

namespace Pingvinas.Event.Api.Controllers;

[ApiController]
[Route("api/{Controller}")]
public class UserController : ControllerBase
{
    [HttpGet("/me")]
    public ActionResult<UserDto> GetMyDetails()
        => Ok();

    [HttpPost]
    public ActionResult<string> AddUser([FromBody] UserDto user)
        => Created(string.Empty,new {});
    
    [HttpPut]
    public ActionResult<bool> UpdateUser([FromBody] UserDto user)
        => NoContent();
    
    [HttpDelete("/{userId}")]
    public ActionResult<bool> DeactivateUser(string userId)
        => Ok();
}