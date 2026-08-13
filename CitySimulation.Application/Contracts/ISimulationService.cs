namespace CitySimulation.Application.Contracts
{
    public interface ISimulationService
    {
        Task TickAsync(CancellationToken cancellationToken);
    }
}
