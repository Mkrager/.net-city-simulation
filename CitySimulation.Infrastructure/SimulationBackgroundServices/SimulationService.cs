using CitySimulation.Application.Contracts.Infrastructure;
using CitySimulation.Application.Contracts.Persistance;

namespace CitySimulation.Infrastructure.SimulationBackgroundServices
{
    public class SimulationService : ISimulationService
    {
        private readonly IPersonRepository _personRepository;
        public SimulationService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public async Task TickAsync(CancellationToken cancellationToken)
        {
            await _personRepository.IncrementAgeAsync(cancellationToken);
        }
    }
}
