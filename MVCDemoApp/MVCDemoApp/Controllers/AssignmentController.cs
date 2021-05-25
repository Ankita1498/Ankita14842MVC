using Microsoft.AspNetCore.Mvc;
using MVCDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PersonForm()
        {
            return View(new Person());
        }

        public IActionResult DisplayPersonData(Person person)
        {
            ViewBag.Default = "Thank You " + person.Name;
            if (person.WillAttend == "Yes")
            {
                ViewBag.Message = "Thank you for coming  ";
            }
            if (person.WillAttend == "No")
            {
                ViewBag.Message = "Sorry to hear you cant come,see you next time!  ";
            }

            return View();

        }
    }
}
