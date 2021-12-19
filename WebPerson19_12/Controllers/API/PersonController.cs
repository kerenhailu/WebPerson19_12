using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPerson19_12.Models;

namespace WebPerson19_12.Controllers.API
{
    public class PersonController : Controller
    {
        [EnableCors("*,*,*,*")]
        // GET: Person
        public ActionResult Index()
        {
            Person person1 = new Person("keren","hailu",23,"keren@");
            return Json(person1.Name,JsonRequestBehavior.AllowGet);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // Put: Person/Edit/5
        [HttpPut]
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

        // Delete: Person/Delete/5
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
