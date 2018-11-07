using Estimator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estimator
{
    public static class DbInitializer
    {
        public static void Initialize(EstimatorContext context)
        {
            if (!context.User.Any())
            {
                AddExampleUsers(context);
            }

            if(!context.ProjectEstimations.Any())
            {
                AddExampleEstimationProjects(context);
            }

            context.SaveChanges();

        }

        private static void AddExampleEstimationProjects(EstimatorContext context)
        {
            var projects = new ProjectEstimation[]
            {
                new ProjectEstimation {Name="Contoso ELearning", Description="ELearning environment of Contoso Oy"},
                new ProjectEstimation{Name="Example Oy Web Banking", Description="Web banking portal for Example Oy"}
            };

            context.AddRange(projects.ToList());
        }

        private static void AddExampleUsers(EstimatorContext context)
        {
            var users = new User[]
            {
                new User{ Name="User 1"},
                new User{ Name="User 2"}
            };

            foreach (User user in users)
            {

                context.Add(user);

            }
        }
    }
}
