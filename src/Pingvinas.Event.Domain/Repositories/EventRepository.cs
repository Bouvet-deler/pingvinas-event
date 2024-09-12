using Bogus.DataSets;
using Pingvinas.Event.Core.Features.User;
using Pingvinas.Event.Domain.Models;

namespace Pingvinas.Event.Domain.Repositories;

public class EventRepository : IEventRepository
{
    private readonly Random _rng;

    public EventRepository()
    {
        _rng = new Random();
    }

    public Task AddParticipantAsync(Participant participant)
    {
        return Task.Delay(100);
    }

    public Task RemoveParticipantAsync(Participant participant)
    {
        return Task.Delay(100);
    }

    public async Task<PingvinEvent> CreateEvent(PingvinEvent @event)
    {
        await Task.Delay(100);
        @event.Id = Guid.NewGuid().ToString();
        return @event;
    }

    public async Task<PingvinEvent> UpdateEvent(PingvinEvent @event)
    {
        await Task.Delay(100);
        return @event;
    }

    public async Task<PingvinEvent> GetEvent(string eventId)
    {
        await Task.Delay(100);
        return CreatePingvinEvent();
    }

    private PingvinEvent CreatePingvinEvent()
    {
        var maxParticipants = _rng.Next(10, 100);
        var participantCount = _rng.Next(10, maxParticipants);
        var startDate = DateTime.Now.AddDays(_rng.Next(-10, 10));
        var eventId = Guid.NewGuid().ToString();
        var commerceData = new Commerce();
        var nameData = new Name();
        return new PingvinEvent
        {
            CreatorId = Guid.NewGuid().ToString(),
            Creator = new User
            {
                Name = nameData.FullName(),
                Active = true,
                Id = Guid.NewGuid().ToString()
            },
            Id = eventId,
            Description = commerceData.ProductDescription(),
            EndDate = startDate.AddDays(1),
            IsSocial = true,
            ResponseDeadline = startDate.AddDays(-2),
            MaxParticipants = maxParticipants,
            MinParticipants = 10,
            NumberOfGuestsAllowed = 100,
            Owner = new User
            {
                Name = nameData.FullName(),
                Active = true,
                Id = Guid.NewGuid().ToString()
            },
            Summary = commerceData.ProductDescription(),
            RequireResponse = true,
            Title = commerceData.Product(),
            StartDate = startDate,
            Location = new Company().CompanyName(),
            OwnerName = nameData.FullName(),
            ParticipantCount = participantCount,
            Participants = CreateParticipantList(eventId, participantCount)
        };
    }

    private IEnumerable<Participant> CreateParticipantList(string eventId, int participantCount)
    {
        for (var i = 0; i < participantCount; i++)
        {
            yield return new Participant(eventId,Guid.NewGuid().ToString());
        }
    }

    public Task<IEnumerable<PingvinEvent>> GetEvents()
    {
        List<PingvinEvent> events = [];
        for (var i = 0; i < 10; i++)
        {
            events.Add(CreatePingvinEvent());
        }
        return Task.Run(() => events.AsEnumerable());
    }
}