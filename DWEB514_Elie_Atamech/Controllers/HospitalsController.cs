using DWEB514_Elie_Atamech.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DWEB514_Elie_Atamech.Controllers
{
    public class HospitalsController : Controller
    {
        //TODO: add DI

        private HospitalService hospitalService;
     
        public HospitalsController()
        {
            this.hospitalService = new HospitalService();
        }

        // GET: Hospitals
        public ActionResult Index()
        {
            return View(hospitalService.List());
        }
    }
}