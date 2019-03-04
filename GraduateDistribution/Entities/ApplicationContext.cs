using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateDistribution.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base ("ApplicationContext") {}

        public DbSet<Distribution> Distributions { get; set; }
        public DbSet<Graduate> Graduates { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet <Organization> Organizations { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Specialty> Specialties { get; set; }

    }
}
