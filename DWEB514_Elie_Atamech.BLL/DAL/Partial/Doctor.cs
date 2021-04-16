using AspNetFinal.BLL.Utility;
using DWEB514_Elie_Atamech.BLL.DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWEB514_Elie_Atamech.BLL.DAL.EF
{
    public partial class Doctor : IdbObject<Doctor>
    {
        public void Delete(int Id)
        {
            using (mophEntities ctx = new mophEntities())
            {
                Doctor x = ctx.Doctors.Find(Id);
                if (x != null)
                {
                    ctx.Doctors.Remove(x);
                    ctx.SaveChanges();
                }
            }
        }

        public Doctor Find(int id)
        {
            using (mophEntities ctx = new mophEntities())
            {
                return ctx.Doctors.Include(d => d.Speciality1).Include(d => d.Hospital1).FirstOrDefault(x=>x.id == id);
            }
        }

        public Doctor insert()
        {
            using (mophEntities ctx = new mophEntities())
            {
                var res = ctx.Doctors.Add(this);
                ctx.SaveChanges();
                return res;
            }
        }

        public List<Doctor> List()
        {
            using (mophEntities ctx = new mophEntities())
            {
                return ctx.Doctors.Include(d => d.Speciality1).Include(d => d.Hospital1).ToList();
            }
        }

        public void Update()
        {
            using (mophEntities ctx = new mophEntities())
            {
                ctx.Entry(this).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
