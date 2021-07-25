using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface ICRUD<T>
    {
        void Add(T objAlta);
        bool Delete(T objBaja);

        bool Update(T objUpdate);

        List<T> ListAll();
    }
}
