using CitySimulation.Domain.Common;
using CitySimulation.Domain.Enums;

namespace CitySimulation.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string? Name { get; set; } 
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public Guid CityId { get; set; }
        public City City { get; set; } = default!;

        public Guid? JobId { get; set; }
        public Job Job { get; set; } = default!;
    }
}
