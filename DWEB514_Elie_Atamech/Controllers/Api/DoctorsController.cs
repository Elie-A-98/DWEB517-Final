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
    public class DoctorsController : ApiController
    {
        private DoctorService doctorService;

        public DoctorsController()
        {
            doctorService = new DoctorService();
        }

        //GET api/customers
        public IEnumerable<DoctorDto> GetCustomers()
        {
            return doctorService.DtosList();
        }

        [HttpDelete]
        public void DeleteDoctor(int id)
        {
            doctorService.Delete(id);
        }
    }
}
