using Microsoft.AspNetCore.Mvc;
using Pingvinas.Event.Core.DTOs;
using Pingvinas.Event.Core.Features.PingvinEvent;

namespace Pingvinas.Event.Api.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class EventController(IEventService service, ILogger<EventController> logger) : ControllerBase
{ 
    private readonly IEventService _service = service;
    private readonly ILogger<EventController> _logger = logger;

    // TODO: Should be able to filter this on events that are still possible to attend.
    [HttpGet]
    public async Task<ActionResult<List<EventDto>>> Get()
        => Ok(await _service.GetEvents());

    [HttpGet("/{id}")]
    public async Task<ActionResult<EventDto>> Get(string id)
    {
        return Ok(await _service.GetEvent(id));
    }

    [HttpPost]
    public async Task<ActionResult> CreateEvent([FromBody] EventDto @event)
    {
        return await Task.Run(() =>
        {
            return Created(string.Empty, new { });
        });
    }

    [HttpPut]
    public async Task<ActionResult> UpdateEvent([FromBody] EventDto @event)
    {
        return await Task.Run(() =>
        {
            return NoContent();
        });
    }

    /// <summary>
    /// Cancels the specified event.
    /// </summary>
    /// <param name="eventId"></param>
    /// <returns></returns>
    [HttpDelete("/{eventId}")]
    public async Task<ActionResult> CancelEvent(string eventId) 
        => Ok(await _service.CancelEvent(eventId));
}