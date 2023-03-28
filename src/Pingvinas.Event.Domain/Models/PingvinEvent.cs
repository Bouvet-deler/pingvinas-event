using Pingvinas.Event.Core.Features.User;

namespace Pingvinas.Event.Domain.Models;

public class PingvinEvent
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string CreatorId { get; set; }
    public User Creator { get; set; }
    
    public virtual IEnumerable<Participant> Participants {get; set; }

    public virtual User Owner { get; set; }
    /// <summary>
    /// The name of the user that created the event.
    /// </summary>
    public string OwnerName { get; set; }
    public string Location { get; set; }
    public string Summary { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime ResponseDeadline { get; set; }
    public int NumberOfGuestsAllowed { get; set; }
    public bool RequireResponse { get; set; }
    public int MaxParticipants { get; set; }
    public int MinParticipants { get; set; }
    public int ParticipantCount { get; set; }
    public bool IsSocial { get; set; }
}