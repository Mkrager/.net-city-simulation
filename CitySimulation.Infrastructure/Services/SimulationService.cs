using CitySimulation.Application.Contracts.Infrastructure;
using CitySimulation.Application.Contracts.Persistance;

namespace CitySimulation.Infrastructure.Services
{
    public class SimulationService : ISimulationService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMortalityService _mortalityService;
        private readonly IRelationshipService _relationshipService;
        public SimulationService(
            IPersonRepository personRepository, 
            IMortalityService mortalityService,
            IRelationshipService relationship)
        {
            _personRepository = personRepository;
            _mortalityService = mortalityService;
            _relationshipService = relationship;
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

                await _relationshipService.FindPartnerAsync(person);


            }   
        }
    }
}
