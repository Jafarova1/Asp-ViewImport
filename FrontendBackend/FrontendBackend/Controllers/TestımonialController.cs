using FrontendBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontendBackend.Controllers
{
    public class TestımonialController : Controller
    {
        public IActionResult Index()
        {
            List<Testimonial> testimonials = GetAllTestimonials();
            return View(testimonials);
        }

        private static List<Testimonial> GetAllTestimonials()
        {
            Testimonial t1 = new()
            {
                Id = 1,
                Title = "Html",
                Description = "Html description",
                Image = "project-1.jpg"
            };
            Testimonial t2 = new()
            {
                Id = 2,
                Title = "Css",
                Description = "Css description",
                Image = "project-2.jpg"
            };
            Testimonial t3 = new()
            {
                Id = 3,
                Title = "Js",
                Description = "Js description",
                Image = "project-3.jpg"
            };
            Testimonial t4 = new()
            {
                Id = 4,
                Title = "Python",
                Description = "Python description",
                Image = "project-1.jpg"
            };

            List<Testimonial> testimonial = new List<Testimonial>() { t1, t2, t3, t4 };
            return testimonial;

        }
    }
}
