using DWEB514_Elie_Atamech.Models;
using DWEB514_Elie_Atamech.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DWEB514_Elie_Atamech.Controllers.Api
{
    public class SearchController : ApiController
    {
        private DoctorService doctorService;

        public SearchController()
        {
            doctorService = new DoctorService();
        }

        //GET api/search?....
        public IEnumerable<SearchDoctorDto> GetDoctor(SearchDto model)
        {
            return doctorService.Search(model.NameSubstring, model.SalaryFrom, model.SalaryTo, model.SpecialityCode, model.HospitalId);
        }
    }
}
