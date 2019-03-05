using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateDistribution.Entities
{
    public class Graduate
    {
        public int GraduateId { get; set; }
        public string GraduateSurName { get; set; }
        public string GraduateLastName { get; set; }
        public string GraduateSecondName { get; set; }
        public string GraduateBirthDate { get; set; }
        public string GraduateGender { get; set; }
        public string GraduateAdress { get; set; }
        public string GraduateTelephone { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public virtual ICollection<Distribution> Distributions { get; set; }
        public Graduate()
        {
            Distributions = new List<Distribution>();
        }

    }
}
