using CitySimulation.Domain.Entities;

namespace CitySimulation.Application.Contracts.Persistance
{
    public interface IPersonRepository : IAsyncRepository<Person>
    {
        Task IncrementAgeAsync(CancellationToken cancellationToken);
    }
}