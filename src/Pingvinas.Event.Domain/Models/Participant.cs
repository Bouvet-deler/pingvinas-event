namespace Pingvinas.Event.Domain.Models;

public record Participant(
  string Id,
  string PingvinEventId,
  string UserId)
{
  public virtual PingvinEvent? PingvinEvent { get; set; }
  public virtual User? User { get; set; }
}