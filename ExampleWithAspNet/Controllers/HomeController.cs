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

        public HomeController(ISchoolService schoolService)
        {
            this.schoolService = schoolService;
        }

        public ActionResult Index()
        {          
            var schools = schoolService.GetSchools(x => x.Id >= 2);

            return View(schools);
        }
        
    }
}