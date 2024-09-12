namespace Pingvinas.Event.Core.DTOs;

public class UserDto
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public string? Email { get; set; }
}