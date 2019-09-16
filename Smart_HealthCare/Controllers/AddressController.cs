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


        public ActionResult ZilaInformation()
        {
            return View(db.Zilas.OrderBy(Zila=>Zila.Division.DivisionName).ToList());
        }


        [HttpGet]
        public ActionResult ZilaCreate()
        {
            ViewBag.DivisionId= new SelectList(db.Divisions, "DivisionId", "DivisionName");
            return View();
        }

        [HttpPost]
        public ActionResult ZilaCreate([Bind(Include = "ZilaId,ZilaName,DivisionId")] Zila zila, int? DivisionId)
        {
            int er = 0;
            if (DivisionId == null)
            {
                er++;
                ViewBag.erDivision = "Select one division name. ";
            }
            if (er > 0)
            {
                ViewBag.DivisionId = new SelectList(db.Divisions, "DivisionId", "DivisionName");
                return View();

            }
            if (ModelState.IsValid)
            {
                var Zila1 = db.Zilas.Where(x => x.ZilaName == zila.ZilaName ).FirstOrDefault();
                if (Zila1 == null)
                {
                    db.Zilas.Add(zila);
                    db.SaveChanges();
                    return RedirectToAction("ZilaInformation", "Address");
                }
                else
                {
                    ViewBag.DivisionId = new SelectList(db.Divisions, "DivisionId", "DivisionName");
                    ViewBag.ermessage = "This zila already here.";
                    return View(); 
                }
            }


            ViewBag.DivisionId = new SelectList(db.Divisions, "DivisionId", "DivisionName");
            return View();

        }

        [HttpGet]
        public ActionResult UpdateZila(int?id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            Zila zila = db.Zilas.Find(id);

            if (zila == null)
            {
                return HttpNotFound();
            }
            
            ViewBag.DivisionId = new SelectList(db.Divisions, "DivisionId", "DivisionName", zila.DivisionId);
            return View(zila);
        }

        [HttpPost]
        public ActionResult UpdateZila([Bind(Include = "ZilaId,ZilaName,DivisionId")] Zila zila, int? DivisionId)
        {
            int er = 0;
            if (DivisionId==null)
            {
                er++;
            }
            if (er > 0)
            {
                ViewBag.DivisionId = new SelectList(db.Divisions, "DivisionId", "DivisionName", zila.DivisionId);
                return View(zila);
            }
            if (ModelState.IsValid)
            {
               // zila.DivisionId = i DivisionId;
                db.Entry(zila).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ZilaInformation");
            }
            ViewBag.DivisionId = new SelectList(db.Divisions, "DivisionId", "DivisionName", zila.DivisionId);
            return View(zila);
        }


        [HttpGet]
        public ActionResult DeleteZila(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Zila zila = db.Zilas.Find(id);
            if (zila == null)
            {
                return HttpNotFound();
            }
            return View(zila);
        }

        [HttpPost]
        public ActionResult DeleteZila(int id)
        {

            Zila zila = db.Zilas.Find(id);
            db.Zilas.Remove(zila);
            db.SaveChanges();
            return RedirectToAction("ZilaInformation", "Address");
        }


        public ActionResult UpazilaInformation()
        {
            return View(db.Upazilas.ToList());
        }

        [HttpGet]
        public ActionResult UpazilaCreate()
        {
            ViewBag.ZilaId = new SelectList(db.Zilas, "ZilaId", "ZilaName");
            return View();
        }

        [HttpPost]
        public ActionResult UpazilaCreate(/*[Bind(Include = "UpazilaName,ZilaId")] */Upazila upazila, int? Zilaid)
        {
            int er = 0;
            if (Zilaid == null)
            {
                er++;
            }
            if (er > 0)
            {
                ViewBag.ZilaId = new SelectList(db.Zilas, "ZilaId", "ZilaName");
                return View();
            }

            if(ModelState.IsValid)
            {
                db.Upazilas.Add(upazila);
     
                db.SaveChanges();
                return RedirectToAction("UpazilaInformation", "Address");

            }
            ViewBag.ZilaId = new SelectList(db.Zilas, "ZilaId", "ZilaName");
            return View();

        }


    }
}