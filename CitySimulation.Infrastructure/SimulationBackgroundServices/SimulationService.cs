using CitySimulation.Application.Contracts;

namespace CitySimulation.Infrastructure.SimulationBackgroundServices
{
    public class SimulationService : ISimulationService
    {
        public Task TickAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Simulation tick: {DateTime.Now:HH:mm:ss}");

            return Task.CompletedTask;
        }
    }
}
