using CitySimulation.Application.Contracts.Infrastructure;
using CitySimulation.Application.Contracts.Persistance;
using CitySimulation.Domain.Entities;
using CitySimulation.Domain.Enums;

namespace CitySimulation.Infrastructure.Services
{
    public class RelationshipService : IRelationshipService
    {
        private readonly IPersonRepository _personRepository;
        public RelationshipService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public async Task FindPartnerAsync(Person person)
        {
            if (person.Age < 16 || person.PartnerId.HasValue)
                return;

            var probability = GetPartnerProbability(person.Age);

            if (Random.Shared.NextDouble() > probability)
                return;

            var partnerGender = person.Gender == Gender.Male
                ? Gender.Female
                : Gender.Male;

            var partner = await _personRepository
                .FindAvailablePartnerAsync(person, partnerGender);

            if (partner is null)
                return;

            await _personRepository.SetPartnersAsync(person, partner);
        }

        private double GetPartnerProbability(int age)
        {
            return age switch
            {
                >= 16 and <= 19 => 0.10,
                >= 20 and <= 24 => 0.25,
                >= 25 and <= 29 => 0.20,
                >= 30 and <= 39 => 0.10,
                >= 40 and <= 49 => 0.03,
                >= 50 => 0.01,
                _ => 0
            };
        }
    }
}
