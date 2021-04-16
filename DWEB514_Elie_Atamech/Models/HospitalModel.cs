using DWEB514_Elie_Atamech.BLL.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWEB514_Elie_Atamech.Models
{
    public class HospitalModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }

        public HospitalModel fromDAO (Hospital dao)
        {
            return new HospitalModel
            {
                Id = dao.id,
                Name = dao.nname,
                Location = dao.location,
                Phone = dao.phone
            };
        }

        public IEnumerable<HospitalModel> fromDAO (IEnumerable<Hospital> dao)
        {
            return dao.Select(x => new HospitalModel().fromDAO(x));
        }
    }
}