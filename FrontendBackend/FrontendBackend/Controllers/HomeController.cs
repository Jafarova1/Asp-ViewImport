using FrontendBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Service> services = GetALLServices();
            return View(services);
            //List<Testimonial> testimonials = GetAllTestimonials();
            //return View(testimonials);
            //List<Experts> experts = GetAllExperts();
            //return View(experts);
            //List<Projects> projects = GetAllProjects();
            //return View(projects);
            //List<Features> features = GetAllFeatures();
            //return View(features);

        }



        private static List<Service> GetALLServices()
        {
            Service s1 = new()
            {
                Id = 1,
                Title = "Resul",
                Description = "Resul description",
                Icon = "icon-1.png"
            };
            Service s2 = new()
            {
                Id = 2,
                Title = "Musa",
                Description = "Musa description",
                Icon = "icon-2.png"
            };
            Service s3 = new()
            {
                Id = 3,
                Title = "Mahir",
                Description = "Mahir description",
                Icon = "icon-3.png"
            };
            Service s4 = new()
            {
                Id = 4,
                Title = "Ramil",
                Description = "Ramil description",
                Icon = "icon-4.png"
            };
            Service s5 = new()
            {
                Id = 5,
                Title = "Nicat",
                Description = "Nicat description",
                Icon = "icon-5.png"
            };
            Service s6 = new()
            {
                Id = 6,
                Title = "Novreste",
                Description = "Novreste description",
                Icon = "icon-6.png"
            };
            List<Service> services = new List<Service>() { s1, s2, s3, s4, s5, s6 };
            return services;

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