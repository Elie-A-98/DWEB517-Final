using DWEB514_Elie_Atamech.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DWEB514_Elie_Atamech.Controllers
{
    public class DoctorsController : Controller
    {
        private DoctorService doctorService;
        public DoctorsController()
        {
            this.doctorService = new DoctorService();
        }
        // GET: Doctors
        public ActionResult Index()
        {
            return View();
        }
    }
}