using DWEB514_Elie_Atamech.BLL.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWEB514_Elie_Atamech.Models
{
    public class SpecialityModel
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public SpecialityModel fromDAO(Speciality dao)
        {
            return new SpecialityModel
            {
                Code = dao.code,
                Name = dao.nname,
            };
        }

        public IEnumerable<SpecialityModel> fromDAO(IEnumerable<Speciality> dao)
        {
            return dao.Select(x => new SpecialityModel().fromDAO(x));
        }
    }
}