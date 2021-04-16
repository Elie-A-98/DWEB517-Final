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
    public partial class Speciality : IdbObject<Speciality>
    {
        public void Delete(int Id)
        {
            using (mophEntities ctx = new mophEntities())
            {
                Speciality x = ctx.Specialities.Find(Id);
                if (x != null)
                {
                    ctx.Specialities.Remove(x);
                    ctx.SaveChanges();
                }
            }
        }

        public Speciality Find(int id)
        {
            throw new NotImplementedException();
        }
        public Speciality Find(string code)
        {
            using (mophEntities ctx = new mophEntities())
            {
                return ctx.Specialities.FirstOrDefault(x => x.code == code);
            }
        }

        public Speciality insert()
        {
            using (mophEntities ctx = new mophEntities())
            {
                var res = ctx.Specialities.Add(this);
                ctx.SaveChanges();
                return res;
            }
        }

        public List<Speciality> List()
        {
            using (mophEntities ctx = new mophEntities())
            {
                return ctx.Specialities.ToList();
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
