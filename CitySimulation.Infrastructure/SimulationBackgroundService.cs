using CitySimulation.Application.Contracts.Infrastructure;
using CitySimulation.Application.Contracts.Persistance;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CitySimulation.Infrastructure
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
            int age = 1;

            while (!stoppingToken.IsCancellationRequested)
            {
                using var scope = _scopeFactory.CreateScope();

                var simulationService =
                    scope.ServiceProvider
                        .GetRequiredService<ISimulationService>();

                await simulationService.TickAsync(stoppingToken);

                var personRepository =
                    scope.ServiceProvider
                        .GetRequiredService<IPersonRepository>();

                Console.WriteLine(
                    $"Age: {age}, People count: {await personRepository.GetPeopleCount()}");

                age++;

                await Task.Delay(
                    TimeSpan.FromSeconds(1),
                    stoppingToken);
            }
        }
    }
}
