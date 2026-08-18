using CitySimulation.Domain.Entities;
using CitySimulation.Domain.Enums;

namespace CitySimulation.Application.Contracts.Persistance
{
    public interface IPersonRepository : IAsyncRepository<Person>
    {
        Task IncrementAgeAsync(CancellationToken cancellationToken);
        Task SetPartnersAsync(Person firstPerson, Person secoundPerson);
        Task<Person?> FindAvailablePartnerAsync(Person person, Gender partnerGender);
        Task<int> GetPeopleCount();
    }
}