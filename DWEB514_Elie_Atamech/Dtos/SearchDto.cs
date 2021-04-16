using DWEB514_Elie_Atamech.BLL.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWEB514_Elie_Atamech.Models
{
    public class SearchDto
    {
        public string NameSubstring { get; set; }
        public int SalaryFrom { get; set; }
        public int SalaryTo { get; set; }
        public string SpecialityCode { get; set; }
        public int HospitalId { get; set; }
        public IEnumerable<SpecialityDto> Specialities { get; set; }
        public IEnumerable<HospitalDto> Hospitals { get; set; }
    }
}