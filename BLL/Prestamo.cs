using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Prestamo
    {
        //internal int PrestamoId;

        public delegate void PrestamoVencidoDelegate(int diasVencido);
        public event PrestamoVencidoDelegate PrestamoVencidoEvent;
        public Prestamo()
        {

            
        }
       
        public MaterialBibliografico MaterialesBibliograficos { get; set; }
        public int PrestamoId { get; set; }
        public Socio Socio { get; set; }

        public DateTime FechaPrestamo { get; set; }

        public DateTime FechaDevolucion { get; set; }

        public void CantidadDeDiasParaVencer()
        {

           // var diasVencidos = "";
           // diasVencidos = int.TryParse(this.FechaDevolucion.ToString()) - this.FechaPrestamo.ToString());
            


            /* 
             FechaPrestamo = DateTime.Now,
                 FechaDevolucion = DateTime.Now.AddDays(socio.DiasDePrestamo),
                 MaterialesBibliograficos = Program.dbBiblioteca.buscarMatBib(isbn),

             DateTime a = FechaDevolucion;
             DateTime b = FechaPrestamo;
             if(a>b)
             {
                 DateTime diasVencido;
                 diasVencido = a-b;
                 return diasVencido;
             }*/

            PrestamoVencidoEvent?.Invoke(5);
           // throw new NotImplementedException();


        }

       
    }
}
