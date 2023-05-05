using FrontendBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontendBackend.Controllers
{
    public class ExpertsController : Controller
    {
        public IActionResult Index()
        {
            List<Experts> experts = GetAllExperts();
            return View(experts);
        }
        private static List<Experts> GetAllExperts()
        {
            Experts e1 = new()
            {
                Id = 1,
                Title = "Novreste",
                Description = "Novreste description",
                Image = "project-1.jpg"
            };
            Experts e2 = new()
            {
                Id = 2,
                Title = "Lale",
                Description = "Lale description",
                Image = "project-2.jpg"
            };
            Experts e3 = new()
            {
                Id = 3,
                Title = "Gultac",
                Description = "Gultac description",
                Image = "project-3.jpg"
            };
            Experts e4 = new()
            {
                Id = 4,
                Title = "Fatime",
                Description = "Fatime description",
                Image = "project-1.jpg"
            };

            List<Experts> experts = new List<Experts>() { e1, e2, e3, e4 };
            return experts;

        }
    }
}
