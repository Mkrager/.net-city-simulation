using CitySimulation.Application.Contracts.Infrastructure;
using CitySimulation.Application.Contracts.Persistance;
using CitySimulation.Domain.Entities;
using CitySimulation.Domain.Enums;

namespace CitySimulation.Infrastructure.Services
{
    public class BirthService : IBirthService
    {
        private readonly IPersonRepository _personRepository;
        private readonly INameGenerator _nameGenerator;
        public BirthService(IPersonRepository personRepository, INameGenerator nameGenerator)
        {
            _personRepository = personRepository;
            _nameGenerator = nameGenerator;
        }
        public async Task ProcessBirthAsync(Person person,Person partner)
        {
            if (!person.PartnerId.HasValue)
                return;

            if (person.Age < 18)
                return;

            if (person.Age > 50)
                return;

            if (partner == null) 
                return;

            if (partner.Age < 18 || partner.Age > 50)
                return;

            var mother = person.Gender == Gender.Female
                ? person
                : partner;

            var father = person.Gender == Gender.Male
                ? person
                : partner;

            var childGender = Random.Shared.Next(2) == 0
                        ? Gender.Male
                        : Gender.Female;

            var child = new Person
            {
                    Id = Guid.NewGuid(),
                    Age = 0,
                    Gender = childGender,
                    Name = _nameGenerator.Generate(childGender),
                    CityId = mother.CityId,
                    JobId = null
            };

            await _personRepository.AddAsync(child);
        }
    }
}
