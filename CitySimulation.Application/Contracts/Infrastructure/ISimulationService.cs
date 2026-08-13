namespace CitySimulation.Application.Contracts.Infrastructure
{
    public interface ISimulationService
    {
        Task TickAsync(CancellationToken cancellationToken);
    }
}
