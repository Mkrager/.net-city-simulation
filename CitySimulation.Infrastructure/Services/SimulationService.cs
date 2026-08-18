using CitySimulation.Application.Contracts.Infrastructure;
using CitySimulation.Application.Contracts.Persistance;

namespace CitySimulation.Infrastructure.Services
{
    public class SimulationService : ISimulationService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMortalityService _mortalityService;
        public SimulationService(IPersonRepository personRepository, IMortalityService mortalityService)
        {
            _personRepository = personRepository;
            _mortalityService = mortalityService;
        }
        public async Task TickAsync(CancellationToken cancellationToken)
        {
            var people = await _personRepository.ListAllAsync();

            await _personRepository.IncrementAgeAsync(cancellationToken);

            foreach (var person in people)
            {
                if (_mortalityService.ShoudDie(person.Age))
                {
                    await _personRepository.DeleteAsync(person);
                }
            }
        }
    }
}
