using CitySimulation.Application.Contracts.Infrastructure;

namespace CitySimulation.Infrastructure.Services
{
    public class MortalityService : IMortalityService
    {
        private readonly Random _random = new();
        public bool ShoudDie(int age)
        {
            var probability = age switch
            {
                < 18 => 0.001,
                < 40 => 0.002,
                < 60 => 0.005,
                < 70 => 0.02,
                < 80 => 0.05,
                < 90 => 0.15,
                _ => 0.30
            };

            return _random.NextDouble() < probability;
        }
    }
}
