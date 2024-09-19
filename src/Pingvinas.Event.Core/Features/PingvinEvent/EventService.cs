using Microsoft.Extensions.Logging;
using Pingvinas.Event.Core.DTOs;
using Pingvinas.Event.Domain.Models;
using Pingvinas.Event.Domain.Repositories;
using System.Data.Common;

namespace Pingvinas.Event.Core.Features.PingvinEvent;

public class EventService : IEventService
{
    private readonly IEventRepository _repository;
    private readonly ILogger<EventService> _logger;

    public EventService(IEventRepository repository, ILogger<EventService> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<bool> AttendEvent(string eventId)
    {
        try
        {
            // TODO: Should get this from claims.
            var userId = Guid.NewGuid().ToString();
            await _repository.AddParticipantAsync(new Participant(Guid.NewGuid().ToString(), eventId, userId!));
            return true;
        }
        catch (DbException e)
        {
            _logger.LogError(e, "Registering event attendance failed");
            return false;
        }
    }

    public Task<bool> CreateEvent(EventDto @event)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateEvent(EventDto @event, bool notifyParticipants)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CancelEvent(string eventId)
    {
        throw new NotImplementedException();
    }

    public Task<EventDto> GetEvent(string eventId)
    {
        throw new NotImplementedException();
    }

    public Task<IList<EventDto>> GetEvents()
    {
        throw new NotImplementedException();
    }
}