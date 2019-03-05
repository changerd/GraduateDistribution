using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateDistribution.Entities
{
    public class Group
    {
        public int GroupId { get; set; }        
        public int GroupQuantity { get; set; }
        public int GroupEndStudy { get; set; }
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
        public virtual ICollection<Graduate> Graduates { get; set; }
        public Group()
        {
            Graduates = new List<Graduate>();
        }
    }
}
