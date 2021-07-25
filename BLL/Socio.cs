using BLL.Enums.Direccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Socio : IComparable<BLL.Socio> , ICloneable
    {
        private int diasDePrestamo;
        public Socio(int numero, string nombre, string apellido, int provincia)
        {
            Numero = numero;
            Nombre = nombre;
            Apellido = apellido;
            this.Provincia = (Provincia)provincia;

        }

        public Socio(int numero, string nombre, string apellido, Provincia provincia)
        {
            Numero = numero;
            Nombre = nombre;
            Apellido = apellido;
            Provincia = provincia;

        }
        public int DiasDePrestamo
        {
            get { return diasDePrestamo; }
            protected set { diasDePrestamo = value; }
        }

        public  int Numero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public BLL.Enums.Direccion.Provincia Provincia { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Socio other)
        {
            return (string.Compare(Numero.ToString(), other.Numero.ToString()) * -1);
            //throw new NotImplementedException();
        }

        public abstract int ObtenerDiasDePrestamoPermitido();

          
             
        

    }

  
}
