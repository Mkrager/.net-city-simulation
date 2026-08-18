using CitySimulation.Domain.Entities;

namespace CitySimulation.Application.Contracts.Infrastructure
{
    public interface IRelationshipService
    {
        Task FindPartnerAsync(Person person);
    }
}
