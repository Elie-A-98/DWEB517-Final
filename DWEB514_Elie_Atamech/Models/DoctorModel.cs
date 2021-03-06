using DWEB514_Elie_Atamech.BLL.DAL.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DWEB514_Elie_Atamech.Models
{
    public class DoctorModel
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string FullName { get; set; }

        [Required]
        public string Phone { get; set; }
        public System.DateTime? DateOfBirth { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public int Salary { get; set; }

        [Required]
        public string SpecialityId { get; set; }
        [Required]
        public int HospitalId { get; set; }
        public string SpecialityName { get; set; }

        public DoctorModel fromDAO (Doctor dao)
        {
            return new DoctorModel
            {
                Id = dao.id,
                FullName = dao.firstName + " " + dao.lastName,
                FirstName = dao.firstName,
                LastName = dao.lastName,
                Phone = dao.phone,
                DateOfBirth = dao.dateOfBirth,
                Email = dao.email,
                Salary = dao.salary,
                SpecialityId = dao.speciality,
                HospitalId = dao.hospital,
                SpecialityName = dao.Speciality1!=null ? dao.Speciality1.nname : "",
            };
        }

        public IEnumerable<DoctorModel> fromDAO(IEnumerable<Doctor> dao)
        {
            return dao.Select(x => new DoctorModel().fromDAO(x));
        }
    }
}