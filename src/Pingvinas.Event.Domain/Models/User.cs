namespace Pingvinas.Event.Core.Features.User;

public class User
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public string? Email { get; set; }
    public required bool Active { get; set; }
}