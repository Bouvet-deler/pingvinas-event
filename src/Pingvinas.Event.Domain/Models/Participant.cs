using Pingvinas.Event.Core.Features.User;

namespace Pingvinas.Event.Domain.Models;

public class Participant
{
    public Participant(string eventId, string userId)
    {
        PingvinEventId = eventId;
        UserId = userId;
    }

    public string Id { get; set; }
    public string PingvinEventId { get; set; }
    public virtual PingvinEvent PingvinEvent { get; set; }
    public string UserId { get; set; }
    public virtual User User { get; set; }
}