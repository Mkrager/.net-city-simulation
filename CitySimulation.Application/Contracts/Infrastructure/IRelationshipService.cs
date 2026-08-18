using CitySimulation.Domain.Entities;

namespace CitySimulation.Application.Contracts.Infrastructure
{
    public interface IRelationshipService
    {
        Task FindPartnerAsync(IReadOnlyCollection<Person> people);
    }
}
