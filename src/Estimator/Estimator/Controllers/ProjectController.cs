using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estimator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estimator.Controllers
{
    public class ProjectController : Controller
    {
        private EstimatorContext _context;

        public ProjectController(EstimatorContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var projects = _context.ProjectEstimations.ToList();
            return View(projects);
        }
    }
}