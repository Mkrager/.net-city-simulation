namespace CitySimulation.Application.Contracts.Infrastructure
{
    public interface IMortalityService
    {
        bool ShoudDie(int age);
    }
}
