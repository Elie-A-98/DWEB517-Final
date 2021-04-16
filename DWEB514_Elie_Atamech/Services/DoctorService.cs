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

        internal IEnumerable<SearchDoctorDto> Search(string nameSubstring, int salaryFrom, int salaryTo, string spcialityCode, int hospitalId)
        {
            IEnumerable<Doctor> doctors = new Doctor().List().Where(
                x => x.firstName.Equals(nameSubstring)
                || x.lastName.Equals(nameSubstring)
                || (x.salary < salaryTo && x.salary > salaryFrom)
                || x.speciality.Equals(spcialityCode)
                || x.hospital == hospitalId
                ).ToList();

            return doctors.Select(d => new SearchDoctorDto
            {
                FullName = d.firstName + " " + d.lastName,
                Email = d.email,
                HospitalName = d.Hospital1.nname,
                Phone = d.phone,
                Salary = d.salary,
                SpecialityName = d.Speciality1.nname
            });
        }

        public DoctorModel Find (int id)
        {
            return new DoctorModel().fromDAO(new Doctor().Find(id));
        }
        public DoctorModel CreateOrUpdate(DoctorModel model)
        {
            if (model.Id != 0)
            {
                new Doctor
                {
                    id = model.Id,
                    firstName = model.FirstName,
                    dateOfBirth = model.DateOfBirth,
                    email = model.Email,
                    hospital = model.HospitalId,
                    lastName = model.LastName,
                    phone = model.Phone,
                    salary = model.Salary,
                    speciality = model.SpecialityId,
                }
                .Update();

                return model;
            }
            else
            {
                Doctor x = new Doctor
                {
                    id = model.Id,
                    firstName = model.FirstName,
                    dateOfBirth = model.DateOfBirth,
                    email = model.Email,
                    hospital = model.HospitalId,
                    lastName = model.LastName,
                    phone = model.Phone,
                    salary = model.Salary,
                    speciality = model.SpecialityId,
                }
                .insert();

                return new DoctorModel().fromDAO(x);
            }
        }
    }
}