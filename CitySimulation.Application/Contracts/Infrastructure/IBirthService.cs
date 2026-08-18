using CitySimulation.Domain.Entities;

namespace CitySimulation.Application.Contracts.Infrastructure
{
    public interface IBirthService
    {
        Task ProcessBirthAsync(Person person, Person partner);
    }
}
