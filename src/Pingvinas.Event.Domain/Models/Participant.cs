using Pingvinas.Event.Core.Features.User;

namespace Pingvinas.Event.Domain.Models;

public class Participant(string eventId, string userId)
{
  public string? Id { get; set; }
  public string PingvinEventId { get; set; } = eventId;
  public virtual PingvinEvent? PingvinEvent { get; set; }
  public string? UserId { get; set; } = userId;
  public virtual User? User { get; set; }
}