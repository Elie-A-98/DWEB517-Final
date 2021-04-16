using DWEB514_Elie_Atamech.BLL.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWEB514_Elie_Atamech.Models
{
    public class SearchDoctorDto
    {
        public string FullName { get; set; }
        public string SpecialityName { get; set; }
        public string HospitalName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

        //public SearchDoctorDto fromDAO (Doctor dao)
        //{
        //    return new DoctorDto
        //    {
        //        Id = dao.id,
        //        FullName = dao.firstName + " " + dao.lastName,
        //        //FirstName = dao.firstName,
        //        //LastName = dao.lastName,
        //        //Phone = dao.phone,
        //        //DateOfBirth = dao.dateOfBirth,
        //        //Email = dao.email,
        //        //Salary = dao.salary,
        //        //SpecialityId = dao.speciality,
        //        //HospitalId = dao.hospital,
        //        SpecialityName = dao.Speciality1.nname
        //    };
        //}

        //public IEnumerable<DoctorDto> fromDAO(IEnumerable<Doctor> dao)
        //{
        //    return dao.Select(x => new DoctorDto().fromDAO(x));
        //}
    }
}