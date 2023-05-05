using FrontendBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontendBackend.Controllers
{
    public class FeaturesController : Controller
    {
        public IActionResult Index()
        {
            List<Features> features = GetAllFeatures();
            return View(features);
           
        }
        private static List<Features> GetAllFeatures()
        {
            Features f1 = new()
            {
                Id = 1,
                Title = "Azerbaijan",
                Description = "Azerbaijan description",
                Icon = "icon-1.png"
            };
            Features f2 = new()
            {
                Id = 2,
                Title = "Turkey",
                Description = "Turkey description",
                Icon = "icon-2.png"
            };
            Features f3 = new()
            {
                Id = 3,
                Title = "Italy",
                Description = "Italy description",
                Icon = "icon-3.png"
            };
            Features f4 = new()
            {
                Id = 4,
                Title = "China",
                Description = "China description",
                Icon = "icon-4.png"
            };

            List<Features> features = new List<Features>() { f1, f2, f3, f4 };
            return features;

        }
    }
}
