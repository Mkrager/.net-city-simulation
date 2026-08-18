using CitySimulation.Domain.Enums;

namespace CitySimulation.Application.Contracts.Infrastructure
{
    public interface INameGenerator
    {
        string Generate(Gender gender);
    }
}
