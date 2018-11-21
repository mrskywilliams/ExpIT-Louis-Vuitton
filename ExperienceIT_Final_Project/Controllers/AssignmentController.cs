using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExperienceIT_Final_Project.Models;

namespace ExperienceIT_Final_Project.Controllers
{
    public class AssignmentController : Controller
    {
        // GET: Assignment
        public ActionResult Random()
        {
            var assignments = new Assignments() {Name = "Module A"};

            return View();
        }
    }
}