using BLL.Enums.Direccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Platino : Socio
    {
        public Platino(int numero, string nombre, string apellido, int provincia):base(numero,nombre,apellido,provincia)
        {
            this.DiasDePrestamo = 20;
        }

        public Platino (int numero, string nombre, string apellido, Provincia provincia):base(numero, nombre, apellido, provincia)
        {
            this.DiasDePrestamo = 20;
        }
        public override int ObtenerDiasDePrestamoPermitido()
        {
            return this.DiasDePrestamo;
        }
    }
}
