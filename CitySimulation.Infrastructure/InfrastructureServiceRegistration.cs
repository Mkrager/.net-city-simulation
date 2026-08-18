using Microsoft.Extensions.DependencyInjection;
using CitySimulation.Application.Contracts.Infrastructure;
using CitySimulation.Infrastructure.Services;

namespace CitySimulation.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddHostedService<SimulationBackgroundService>();
            services.AddScoped<ISimulationService, SimulationService>();
            services.AddScoped<IMortalityService, MortalityService>();
            services.AddScoped<IRelationshipService, RelationshipService>();

            return services;
        }
    }
}
