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
    public partial class Hospital : IdbObject<Hospital>
    {
        public void Delete(int Id)
        {
            using (mophEntities ctx = new mophEntities())
            {
                Hospital x = ctx.Hospitals.Find(Id);
                if (x != null)
                {
                    ctx.Hospitals.Remove(x);
                    ctx.SaveChanges();
                }
            }
        }

        public Hospital Find(int id)
        {
            using (mophEntities ctx = new mophEntities())
            {
                return ctx.Hospitals.FirstOrDefault(x=>x.id == id);
            }
        }

        public Hospital insert()
        {
            using (mophEntities ctx = new mophEntities())
            {
                var res = ctx.Hospitals.Add(this);
                ctx.SaveChanges();
                return res;
            }
        }

        public List<Hospital> List()
        {
            using (mophEntities ctx = new mophEntities())
            {
                return ctx.Hospitals.ToList();
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
