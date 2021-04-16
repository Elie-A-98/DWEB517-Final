using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetFinal.BLL.Utility
{
    interface IdbObject<T>
    {
        T insert();
        void Delete(int Id);
        T Find(int id);
        List<T> List();
        void Update();
    }
}
