using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateDistribution.Entities
{
    public class Distribution
    {
        public int DistributionId { get; set; }
        public DateTime DistributionStart { get; set; }
        public DateTime DistributionEnd { get; set; }
        public decimal DistributionSalary { get; set; }
        public int GraduateId { get; set; }
        public int OrganizationId { get; set; }
        public int PositionId { get; set; }
        public Graduate Graduate { get; set; }
        public Organization Organization { get; set; }
        public Position Position { get; set; }
    }
}
