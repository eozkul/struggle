using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Struggle.Common;
using Struggle.Data.Abstractions;
using Struggle.Data.Concretes;
using Struggle.Data.Context;
namespace Struggle.Data.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddData(this IServiceCollection services,IConfiguration configuration)
        {
            var section = configuration.GetSection($"{nameof(Settings)}:Database");
            var settings = section.Get<Settings.DatabaseConfiguration>();
            services.AddDbContext<StruggleDbContext>(builder =>
            {
                builder.UseSqlServer(settings.ConnectionString);
            });
            services.AddScoped<DbContext, StruggleDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }

    }
}
