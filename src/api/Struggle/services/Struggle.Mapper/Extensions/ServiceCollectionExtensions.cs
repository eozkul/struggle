using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Struggle.Mapper;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(config =>
        {
            config.AddProfile<MainProfile>();
        });
        return services;
    }
}
