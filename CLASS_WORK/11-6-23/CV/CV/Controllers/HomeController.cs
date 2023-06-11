using CV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Education = "Education";
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult References()
        {
            ViewBag.Ref = "References";
            return View();
        }

        public ActionResult Projects_MOD()
        {
            ViewBag.Project = "Projects";


            var p1 = new Models.Projects()
            {
                Name = "Fletch–Flee",
                Type = "Java",
                Link = "www.github.com/yaarian-om"

            };

            var p2 = new Models.Projects()
            {
                Name = "Voyager - A Tour Management System",
                Type = "C#",
                Link = "www.github.com/yaarian-om"

            };
            var p3 = new Models.Projects()
            {
                Name = "Orphanage Management System",
                Type = "Web",
                Link = "www.github.com/yaarian-om"

            };

            var p4 = new Models.Projects()
            {
                Name = "Fletch–Flee",
                Type = "Android",
                Link = "www.github.com/yaarian-om"

            };

            var p5 = new Models.Projects()
            {
                Name = "Next World Champion Prediction",
                Type = "ML",
                Link = "www.github.com/yaarian-om"

            };

            var p6 = new Models.Projects()
            {
                Name = "Java Simplica Book",
                Type = "Latex",
                Link = "www.github.com/yaarian-om"

            };

            Projects[] projects = new Projects[] { p1, p2, p3, p4, p5, p6 };


            return View(projects);
        }


    }
}