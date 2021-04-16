using DWEB514_Elie_Atamech.Models;
using DWEB514_Elie_Atamech.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DWEB514_Elie_Atamech.Controllers
{
    public class SearchController : Controller
    {
        private DoctorService doctorService;
        private SpecialityService specialityService;
        private HospitalService hospitalService;
        public SearchController()
        {
            this.doctorService = new DoctorService();
            this.specialityService = new SpecialityService();
            this.hospitalService = new HospitalService();
        }
        // GET: Search
        public ActionResult Index()
        {
            SearchModel model = new SearchModel
            {
                Specialities = specialityService.List(),
                Hospitals = hospitalService.List(),
            };
            return View(model);
        }

    }
}