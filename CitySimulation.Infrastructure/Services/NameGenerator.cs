using CitySimulation.Application.Contracts.Infrastructure;
using CitySimulation.Domain.Enums;

namespace CitySimulation.Infrastructure.Services
{
    public class NameGenerator : INameGenerator
    {
        private static readonly string[] MaleNames =
        {
            "Alexander", "James", "William", "Michael",
            "Daniel", "John", "Robert", "David",
            "Thomas", "Christopher", "Matthew", "Andrew",
            "Joseph", "Charles", "George", "Edward"
        };

        private static readonly string[] FemaleNames =
        {
            "Olivia", "Emma", "Charlotte", "Amelia",
            "Sophia", "Isabella", "Ava", "Mia",
            "Evelyn", "Luna", "Harper", "Ella",
            "Emily", "Elizabeth", "Sofia", "Camila"
        };

        public string Generate(Gender gender)
        {
            var names = gender == Gender.Male
                ? MaleNames
                : FemaleNames;

            return names[Random.Shared.Next(names.Length)];
        }
    }
}
