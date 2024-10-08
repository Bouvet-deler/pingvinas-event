﻿namespace Pingvinas.Event.Core.DTOs;
public class EventDto
{
    public required string Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    
    /// <summary>
    /// The name of the user that created the event.
    /// </summary>
    public required string OwnerName { get; set; }
    public required string Location { get; set; }
    public required string Summary { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public required DateTime ResponseDeadline { get; set;}
    public required int NumberOfGuestsAllowed { get; set; }
    public required bool RequireResponse { get; set; }
    public required int MaxParticipants { get; set; }
    public int MinParticipants { get; set; }
    public int ParticipantCount { get; set;}
    public required bool IsSocial { get; set; }
}