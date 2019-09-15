using System;
using System.Collections.Generic;
using System.Linq;
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
            return View(db.Divisions.ToList());
        }

        [HttpGet]
        public ActionResult DivisionCreate()
        {
            return View();
        }

        
    }
}