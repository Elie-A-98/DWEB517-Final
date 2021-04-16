using DWEB514_Elie_Atamech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DWEB514_Elie_Atamech.BLL.DAL.EF;

namespace DWEB514_Elie_Atamech.Services
{
    public class DoctorService
    {
        public IEnumerable<DoctorModel> List()
        {
            return new DoctorModel().fromDAO(new Doctor().List());
        }
        public IEnumerable<DoctorDto> DtosList()
        {
            return new DoctorDto().fromDAO(new Doctor().List());
        }
        public void Delete(int id)
        {
            new Doctor().Delete(id);
        }
    }
}