using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Company.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {

            var s1 = new Services()
            {
                Name = "Subscription",
                Description = "People can have Subscription Bonus"
            };

            var s2 = new Services()
            {
                Name = "Installment",
                Description = "Test"
            };


            Services[] services = new Services[] { s1, s2 };



            return View(services);
        }

        public ActionResult Teams()
        {
            var m1 = new Member() { Name = "Sudipta Kumar", Designation = "Developing Lead" };
            var m2 = new Member() { Name = "Yash Roy", Designation = "Project Manager" };
            var m3 = new Member() { Name = "Tamim Ishraq", Designation = "Junior Developer" };
            var m4 = new Member() { Name = "Salman Hossain", Designation = "Junior Developer" };
            var m5 = new Member() { Name = "Ritu Das", Designation = "Junior Developer" };
            var m6 = new Member() { Name = "Chondrima Borsha", Designation = "Senior Developer" };
            var m7 = new Member() { Name = "Fatema Islam", Designation = "Senior Developer" };

            var m8 = new Member() { Name = "Era Hasan", Designation = "Junior Tester" };
            var m9 = new Member() { Name = "Abdul Kalam", Designation = "Junior Tester" };
            var m10 = new Member() { Name = "Afroza Islam", Designation = "Junior Tester" };
            var m11 = new Member() { Name = "Sajid Hasan", Designation = "Testing Lead" };
            var m12 = new Member() { Name = "Iftekar Ahmed", Designation = "Senior Tester" };

            Member[] Dev_Members = new Member[] {m1,m2,m3,m4,m5,m6,m7};
            Member[] Test_Members = new Member[] {m8,m9,m10,m11,m12};



            var t1 = new Team(){Name = "Developer Team",Members = Dev_Members};

            var t2 = new Team(){Name = "Testing Team",Members = Test_Members};

            Team[] teams = new Team[] { t1, t2 };

            return View(teams);
        }

        public ActionResult Contact()
        {
            return View();
        }


    }
}