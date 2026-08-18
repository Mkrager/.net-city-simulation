using CitySimulation.Application.Contracts.Persistance;
using CitySimulation.Domain.Entities;
using CitySimulation.Domain.Enums;
using Microsoft.EntityFrameworkCore;
namespace CitySimulation.Persistence.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(CitySimulationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Person?> FindAvailablePartnerAsync(Person person, Gender partnerGender)
        {

            return await _dbContext.Persons
                .FirstOrDefaultAsync(
                p =>
                    p.Id != person.Id &&
                    p.CityId == person.CityId &&
                    p.Age >= 16 &&
                    p.PartnerId == null &&
                    p.Gender == partnerGender);
        }

        public async Task<int> GetPeopleCount()
        {
            return await _dbContext.Persons.CountAsync();
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