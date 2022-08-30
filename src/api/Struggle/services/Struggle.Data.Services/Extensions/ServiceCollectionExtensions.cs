using MediatR;
using Struggle.Data.Services.Abstractions;
using Struggle.Data.Services.Concretes;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataServices(this IServiceCollection services)
    {
        services.AddScoped<ICarService, CarService>();
        services.AddScoped<IBoatService, BoatService>();
        services.AddScoped<IBusService, BusService>();
        var queriesAssembly = AppDomain.CurrentDomain.Load("Struggle.Data.Management.Queries");
        var commandsAssembly = AppDomain.CurrentDomain.Load("Struggle.Data.Management.Commands");
        services.AddMediatR(queriesAssembly, commandsAssembly);
        return services;
    }
}