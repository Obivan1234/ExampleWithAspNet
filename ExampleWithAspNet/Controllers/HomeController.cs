using ExampleWithAspNet.Infrastructure;
using ExampleWithAspNet.Models;
using ExampleWithAspNet.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleWithAspNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISchoolService schoolService;
        private readonly IPersonService personService;

        public HomeController(
            ISchoolService schoolService,
            IPersonService personService)
        {
            this.schoolService = schoolService;
            this.personService = personService;

        }

        public ActionResult Index()
        {
            var people = personService.GetPersones();
            return View(people);
        }

        public ActionResult Second()
        {
            var schools = schoolService.GetSchoolById(1);
            

            return View(schools);
        }    

        [HttpGet]
        public ActionResult Make()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Make(Person person)
        {
            personService.InsertPerson(person);   
            return RedirectToAction("Index");
        }
    }
}