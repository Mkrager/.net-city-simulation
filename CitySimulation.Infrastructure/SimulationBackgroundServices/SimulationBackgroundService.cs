using CitySimulation.Application.Contracts.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CitySimulation.Infrastructure.SimulationBackgroundServices
{
    public class SimulationBackgroundService : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public SimulationBackgroundService(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(
            CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using var scope = _scopeFactory.CreateScope();

                var simulationService =
                    scope.ServiceProvider
                        .GetRequiredService<ISimulationService>();

                await simulationService.TickAsync(stoppingToken);

                await Task.Delay(
                    TimeSpan.FromSeconds(1),
                    stoppingToken);
            }
        }
    }
}
