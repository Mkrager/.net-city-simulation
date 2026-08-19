using CitySimulation.Domain.Common;
using CitySimulation.Domain.Enums;

namespace CitySimulation.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public decimal Money { get; set; }

        public Guid CityId { get; set; }
        public City City { get; set; } = default!;

        public Guid? JobId { get; set; }
        public Job Job { get; set; } = default!;
        
        public Guid? PartnerId { get; set; }
        public Person? Partner {  get; set; }   
    }
}
