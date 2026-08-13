using CitySimulation.Domain.Common;

namespace CitySimulation.Domain.Entities
{
    public class Workplace : BaseEntity
    {
        public string? Name { get; set; }
        public int Capacity { get; set; }
    }
}
