using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ajax.data;

namespace ajax.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View("Index" );
        }

        public IActionResult FillCountry()
        {
            PatientContext context = new PatientContext();
            List<Country> li = (from x in context.country1 select x).ToList();
            
            return Json(li);
        }

        public IActionResult SaveData(pateint p)
        {
            PatientContext context = new PatientContext();
            context.patient1.Add(p);
            context.SaveChanges();

            return Content("success called!");
        }
    }
}
