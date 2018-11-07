using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Estimator.Models
{
    public class EstimatorContext : DbContext
    {
        public EstimatorContext (DbContextOptions<EstimatorContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<ProjectEstimation> ProjectEstimations { get; set; }
        public DbSet<Story> Stories { get; set; }
    }
}
