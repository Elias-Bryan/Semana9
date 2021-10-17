using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Semana9.Models;

namespace Semana9.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            
            if (Session["Person"]== null)
            {
                List<Person> persons = new List<Person>();
                persons.Add(new Person { ID = 1, FirstName = "Bryan", LastName = "Bautista", BirthDay = DateTime.Today, isTecsup = true });
                persons.Add(new Person { ID = 2, FirstName = "Elias", LastName = "Bautista", BirthDay = DateTime.Today, isTecsup = false });
                Session["Person"] = persons;
            }
            
            
            return View(Session["Person"]);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            var model = ((List<Person>)Session["Person"]).Where(x => x.ID == id).FirstOrDefault();
            return View(model);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person model)
        {
            try
            {
                // TODO: Add insert logic here
                if (Session["Person"] == null)
                    Session["Person"] = new List<Person>();

                ((List<Person>)Session["Person"]).Add(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            var model = ((List<Person>)Session["Person"]).Where(x => x.ID == id).FirstOrDefault();
            return View(model);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            var model = ((List<Person>)Session["Person"]).Where(x => x.ID == id).FirstOrDefault();
            return View(model);
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Person model)
        {
            try
            {
                // TODO: Add delete logic here
                ((List<Person>)Session["Person"]).Remove(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
