using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateDistribution.Entities
{
    public class Organization
    {
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationAdress { get; set; }
        public string OrganizationTelephone { get; set; }
        public string OrganizationSphere { get; set; }
        public virtual ICollection<Distribution> Distributions { get; set; }
        public Organization()
        {
            Distributions = new List<Distribution>();
        }
    }
}
