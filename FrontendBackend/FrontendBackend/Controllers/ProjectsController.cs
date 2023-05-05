using FrontendBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontendBackend.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            List<Projects> projects = GetAllProjects();
            return View(projects);
        }
        private static List<Projects> GetAllProjects()
        {
            Projects p1 = new()
            {
                Id = 1,
                Title = "Bdu",
                Description = "Bdu description",
                Image = "project-1.jpg"
            };
            Projects p2 = new()
            {
                Id = 2,
                Title = "Ada",
                Description = "Ada description",
                Image = "project-2.jpg"
            };
            Projects p3 = new()
            {
                Id = 3,
                Title = "Bmu",
                Description = "Bmu description",
                Image = "project-3.jpg"
            };
            Projects p4 = new()
            {
                Id = 4,
                Title = "Adnsu",
                Description = "Adnsu description",
                Image = "project-1.jpg"
            };

            List<Projects> projects = new List<Projects>() { p1, p2, p3, p4 };
            return projects;

        }
    }
}
