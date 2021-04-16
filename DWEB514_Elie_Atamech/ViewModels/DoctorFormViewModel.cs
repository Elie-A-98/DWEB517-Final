using DWEB514_Elie_Atamech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWEB514_Elie_Atamech.ViewModels
{
    public class DoctorFormViewModel
    {
        public DoctorModel Doctor { get; set; }
        public IEnumerable<SpecialityModel> Specialities { get; set; }
        public IEnumerable<HospitalModel> Hospitals { get; set; }
    }
}