using Microsoft.Extensions.DependencyInjection;
using CitySimulation.Infrastructure.SimulationBackgroundServices;
using CitySimulation.Application.Contracts;

namespace CitySimulation.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddHostedService<SimulationBackgroundService>();
            services.AddScoped<ISimulationService, SimulationService>();

            return services;
        }
    }
}
