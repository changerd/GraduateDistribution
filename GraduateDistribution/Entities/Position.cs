using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateDistribution.Entities
{
    public class Position
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public virtual ICollection<Distribution> Distributions { get; set; }
        public Position()
        {
            Distributions = new List<Distribution>();
        }
    }
}
