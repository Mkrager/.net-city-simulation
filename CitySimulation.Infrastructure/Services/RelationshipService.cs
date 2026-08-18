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
        public async Task FindPartnerAsync(IReadOnlyCollection<Person> people)
        {
            var cities = people
                .Where(p =>
                    p.Age >= 16 &&
                    !p.PartnerId.HasValue)
                .GroupBy(p => p.CityId);

            foreach (var city in cities)
            {
                var males = city
                    .Where(p =>
                        p.Gender == Gender.Male &&
                        WantsPartner(p))
                    .ToList();

                var females = city
                    .Where(p =>
                        p.Gender == Gender.Female &&
                        WantsPartner(p))
                    .ToList();

                Shuffle(males);
                Shuffle(females);

                var pairsCount = Math.Min(
                    males.Count,
                    females.Count);

                for (var i = 0; i < pairsCount; i++)
                {
                    var male = males[i];
                    var female = females[i];

                    await _personRepository.SetPartnersAsync(male, female);
                }
            }
        }

        private bool WantsPartner(Person person)
        {
            var probability = GetPartnerProbability(person.Age);

            return Random.Shared.NextDouble() <= probability;
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

        private void Shuffle(List<Person> people)
        {
            for (var i = people.Count - 1; i > 0; i--)
            {
                var j = Random.Shared.Next(i + 1);

                (people[i], people[j]) =
                    (people[j], people[i]);
            }
        }
    }
}
