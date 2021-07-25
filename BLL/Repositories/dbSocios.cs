using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    internal class dbSocios : ICRUD<BLL.Socio>
    {
        private List<BLL.Socio> Socios = new List<Socio>();
        public void Add(Socio objAlta)
        {
            Socios.Add(objAlta);
        }

        public bool Delete(Socio objBaja)
        {
             return Socios.Remove(objBaja);
        }

        public Socio Find(int num)
        {
            return Socios.Single(x => x.Numero == num);
        }

        public List<Socio> ListAll()
        {
            return Socios;
        }

        public bool Update(Socio objUpdate)
        {
            var cat = this.Socios.Find(c => c.Numero == objUpdate.Numero);
            if(cat!=null)
            {
                cat.Numero = objUpdate.Numero;
                cat.Nombre = objUpdate.Nombre;
                cat.Direccion = objUpdate.Direccion;
                cat.Apellido = objUpdate.Apellido;
                return true;
            }
            return false;
        }
    }
}
