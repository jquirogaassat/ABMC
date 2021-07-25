using BLL.Enums.MaterialBibliografico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class MaterialBibliografico
    {
               

        public MaterialBibliografico(int isbn, string autor, int hojas, Estado estado)
        {
            this.ISBN = isbn;
            this.Autor = autor;
            this.Hojas = hojas;
            this.Estado = estado;
        }
        public MaterialBibliografico(int isbn, string autor, int hojas, int estado)
        {
            this.ISBN = isbn;
            this.Autor = autor;
            this.Hojas = hojas;
            this.Estado = (Estado)estado;
        }

        public Estado Estado { get; set; }

        public int ISBN { get; set; }
        public string Autor { get; set; }

        public int Hojas { get; set; }
      

        

    }

  
}
