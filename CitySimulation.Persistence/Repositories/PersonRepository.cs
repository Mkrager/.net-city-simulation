using CitySimulation.Application.Contracts.Persistance;
using CitySimulation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace CitySimulation.Persistence.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(CitySimulationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task IncrementAgeAsync(CancellationToken cancellationToken)
        {
            await _dbContext.Persons.ExecuteUpdateAsync(
                setters => setters.SetProperty(
                    p => p.Age,
                    p => p.Age + 1),
                cancellationToken);
        }

        public async Task SetPartnersAsync(Person firstPerson, Person secondPerson)
        {
            firstPerson.PartnerId = secondPerson.Id;
            secondPerson.PartnerId = firstPerson.Id;

            await _dbContext.SaveChangesAsync();
        }
    }
}