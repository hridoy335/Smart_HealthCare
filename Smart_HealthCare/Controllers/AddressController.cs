using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Smart_HealthCare.Models;

namespace Smart_HealthCare.Controllers
{
    public class AddressController : Controller
    {

        Smart_HealthCareEntities1 db = new Smart_HealthCareEntities1();
        // GET: Address
        public ActionResult DivisionInformation()
        {
            return View(db.Divisions.OrderBy(Division => Division.DivisionName).ToList());
        }

        [HttpGet]
        public ActionResult DivisionCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DivisionCreate(Division division)
        {
            if (ModelState.IsValid)
            {
                db.Divisions.Add(division);
                db.SaveChanges();
                return RedirectToAction("DivisionInformation", "Address");
            }
            return View();
        }

        [HttpGet]
        public ActionResult DivisionUpdate(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Division division = db.Divisions.Find(id);

            if (division == null)
            {
                return HttpNotFound();
            }
            return View(division);

        }

        [HttpPost]
        public ActionResult DivisionUpdate([Bind (Include = "DivisionId,DivisionName")]Division division)
        {

            if (ModelState.IsValid)
            {
                db.Entry(division).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DivisionInformation");
            }
            return View(division);
        }

        [HttpGet]
        public ActionResult DivisionDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Division division = db.Divisions.Find(id);
            if (division == null)
            {
                return HttpNotFound();
            }
            return View(division);
        }   
        
        [HttpPost]
        public ActionResult DivisionDelete(int id)
        {
            Division division = db.Divisions.Find(id);
            db.Divisions.Remove(division);
            db.SaveChanges();
            return RedirectToAction("DivisionInformation","Address");
        }
    }
}