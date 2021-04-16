using DWEB514_Elie_Atamech.BLL.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWEB514_Elie_Atamech.Models
{
    public class SearchModel
    {
        public string NameSubstring { get; set; }
        public int SalaryFrom { get; set; }
        public int SalaryTo { get; set; }
        public string SpecialityCode { get; set; }
        public int HospitalId { get; set; }
        public IEnumerable<SpecialityModel> Specialities { get; set; }
        public IEnumerable<HospitalModel> Hospitals { get; set; }

        //public SpecialityModel fromDAO(Speciality dao)
        //{
        //    return new SpecialityModel
        //    {
        //        Code = dao.code,
        //        Name = dao.nname,
        //    };
        //}

        //public IEnumerable<SpecialityModel> fromDAO(IEnumerable<Speciality> dao)
        //{
        //    return dao.Select(x => new SpecialityModel().fromDAO(x));
        //}
    }
}