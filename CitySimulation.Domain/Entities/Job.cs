using CitySimulation.Domain.Common;

namespace CitySimulation.Domain.Entities
{
    public class Job : BaseEntity
    {
        public string? Title { get; set; }
        public decimal AnnualSalary { get; set; }

        public Guid WorkplaceId { get; set; }
        public Workplace Workplace { get; set; } = default!;
    }
}
