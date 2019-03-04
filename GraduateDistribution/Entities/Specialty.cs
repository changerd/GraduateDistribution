using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateDistribution.Entities
{
    public class Specialty
    {
        public int SpecialtyId { get; set; }
        public string SpecialtyCode { get; set; }
        public string SpecialtyTime { get; set; }
        public string SpecialtyFormStudy { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public Specialty()
        {
            Groups = new List<Group>();
        }
    }
}
