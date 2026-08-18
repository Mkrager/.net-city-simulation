using CitySimulation.Application.Contracts.Infrastructure;
using CitySimulation.Application.Contracts.Persistance;

namespace CitySimulation.Infrastructure.Services
{
    public class SimulationService : ISimulationService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMortalityService _mortalityService;
        private readonly IRelationshipService _relationshipService;
        private readonly IBirthService _birthService;
        public SimulationService(
            IPersonRepository personRepository, 
            IMortalityService mortalityService,
            IRelationshipService relationship,
            IBirthService birthService)
        {
            _personRepository = personRepository;
            _mortalityService = mortalityService;
            _relationshipService = relationship;
            _birthService = birthService;
        }
        public async Task TickAsync(CancellationToken cancellationToken)
        {
            var people = await _personRepository.ListAllAsync();

            var processedPairs = new HashSet<Guid>();

            await _personRepository.IncrementAgeAsync(cancellationToken);

            foreach (var person in people)
            {
                if (_mortalityService.ShoudDie(person.Age))
                {
                    await _personRepository.DeleteAsync(person);
                }

                await _relationshipService.FindPartnerAsync(person);

                if (!person.PartnerId.HasValue)
                    continue;

                if (processedPairs.Contains(person.PartnerId.Value))
                    continue;

                await _birthService.ProcessBirthAsync(person);

                processedPairs.Add(person.Id);

                Console.WriteLine($"People count:{await _personRepository.GetPeopleCount()}");
            }   
        }
    }
}
