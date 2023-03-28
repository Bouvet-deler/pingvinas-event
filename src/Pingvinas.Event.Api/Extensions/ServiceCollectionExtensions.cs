using Pingvinas.Event.Core.Features.PingvinEvent;
using Pingvinas.Event.Domain.Repositories;

namespace Pingvinas.Event.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPingvinasServices(this IServiceCollection services)
        => services.AddTransient<IEventService, EventService>()
            .AddTransient<IEventRepository, EventRepository>();
}