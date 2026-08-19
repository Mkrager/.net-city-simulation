using CitySimulation.Domain.Common;

namespace CitySimulation.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; } = null!;

        public Guid CityId { get; set; }
        public City City { get; set; } = default!;

        public decimal Money { get; set; }

        public ICollection<Workplace> Workplaces { get; set; } 
            = new List<Workplace>();
    }
}
