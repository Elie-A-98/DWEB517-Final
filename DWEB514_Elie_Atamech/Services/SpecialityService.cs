using DWEB514_Elie_Atamech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DWEB514_Elie_Atamech.BLL.DAL.EF;

namespace DWEB514_Elie_Atamech.Services
{
    public class SpecialityService
    {
        public IEnumerable<SpecialityModel> List()
        {
            return new SpecialityModel().fromDAO(new Speciality().List());
        }
    }
}