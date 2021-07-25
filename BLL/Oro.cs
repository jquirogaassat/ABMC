using BLL.Enums.Direccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Oro : Socio
    {
        public Oro(int numero, string nombre, string apellido, int provincia) : base(numero, nombre, apellido, provincia)
        {
            this.DiasDePrestamo = 10;           

        }

        public Oro(int numero, string nombre, string apellido, Provincia provincia): base(numero, nombre, apellido, provincia)
        {
            this.DiasDePrestamo = 10;

        }

        public override int ObtenerDiasDePrestamoPermitido()
        {
            return this.DiasDePrestamo; 
        }
    }
}
