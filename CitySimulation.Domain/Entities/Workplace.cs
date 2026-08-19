using CitySimulation.Domain.Common;

namespace CitySimulation.Domain.Entities
{
    public class Workplace : BaseEntity
    {
        public string? Name { get; set; }
        public int Capacity { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; } = default!;

        public ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
