using DWEB514_Elie_Atamech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DWEB514_Elie_Atamech.BLL.DAL.EF;

namespace DWEB514_Elie_Atamech.Services
{
    public class HospitalService
    {
        public IEnumerable<HospitalModel> List()
        {
            return new HospitalModel().fromDAO(new Hospital().List());
        }
    }
}