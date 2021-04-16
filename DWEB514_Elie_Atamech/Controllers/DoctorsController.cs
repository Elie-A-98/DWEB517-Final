using DWEB514_Elie_Atamech.Services;
using DWEB514_Elie_Atamech.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DWEB514_Elie_Atamech.Models;

namespace DWEB514_Elie_Atamech.Controllers
{
    public class DoctorsController : Controller
    {
        private DoctorService doctorService;
        private SpecialityService specialityService;
        private HospitalService hospitalService;
        public DoctorsController()
        {
            this.doctorService = new DoctorService();
            this.specialityService = new SpecialityService();
            this.hospitalService = new HospitalService();
        }
        // GET: Doctors
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(DoctorModel doctor)
        {
            doctorService.CreateOrUpdate(doctor);
            return RedirectToAction("Index", "Doctors");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            int doctorId = 0;
            if (id.HasValue)
            {
                doctorId = (int)id;
            }

            DoctorFormViewModel viewModel = new DoctorFormViewModel();
            if (doctorId == 0)
            {
                // new
                viewModel = new DoctorFormViewModel
                {
                    Doctor = new DoctorModel(),
                    Specialities = specialityService.List(),
                    Hospitals = hospitalService.List()
                };
            }
            else
            {
                DoctorModel doctor = doctorService.Find(doctorId);
                viewModel = new DoctorFormViewModel
                {
                    Doctor = doctor,
                    Specialities = specialityService.List(),
                    Hospitals = hospitalService.List()
                };
            }
            return View("DoctorForm", viewModel);
        }
    }
}