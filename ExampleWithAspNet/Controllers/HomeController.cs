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
        private readonly ILocationServise locationServise;

        public HomeController(
            ISchoolService schoolService,
            IPersonService personService,
            ILocationServise locationServise)
        {
            this.schoolService = schoolService;
            this.personService = personService;
            this.locationServise = locationServise;
        }

        public ActionResult Index()
        {
            var people = personService.GetPersones();
            return View(people.ToList());
        }

        public ActionResult Second()
        {
            var schools = schoolService.GetSchoolById(1);
            

            return View(schools);
        }    

        [HttpGet]
        public ActionResult Make()
        {
            SelectList items = new SelectList(locationServise.GetLocations(), "Id", "Name");
            ViewBag.Location = items;
            return View();
        }

        [HttpPost]
        public ActionResult Make(Person person)
        {
            personService.InsertPerson(person);   
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var item = personService.GetPersonById(id);

            if (item == null)
            {
                return HttpNotFound();
            }

            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var item = personService.GetPersonById(id);

            if (item == null)
            {
                return HttpNotFound();
            }

            personService.Remove(item);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            //if (id == null)
            //{
            //    return HttpNotFound();
            //}

            var person = personService.GetPersonById(id);

            if (person != null)
            {
                var locations = locationServise.GetLocations();

                
                ViewBag.Locations = new SelectList(locations, "Id", "Name", person.LocationId);
                return View(person);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            personService.Update(person);
            return RedirectToAction("Index");
        }
    }
}