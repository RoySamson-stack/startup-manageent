// Example: ProjectsController.cs
using Microsoft.AspNetCore.Mvc;
using Portfolio.Core;

namespace Portfolio.Web.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            // Retrieve projects from a data source (e.g., a database)
            var projects = new[]
            {
                new Project { Id = 1, Name = "Project 1", Description = "Description for Project 1", TechnologiesUsed = "Tech 1, Tech 2" },
                new Project { Id = 2, Name = "Project 2", Description = "Description for Project 2", TechnologiesUsed = "Tech 3, Tech 4" },
            };

            return View(projects);
        }
    }
}
