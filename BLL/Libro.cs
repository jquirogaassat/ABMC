using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Enums.MaterialBibliografico;

namespace BLL
{
    public class Libro : MaterialBibliografico
    {
        public Libro(int isbn, string autor, int hojas, Estado estado):base(isbn, autor,hojas, estado)
        {

        }

        public Libro(int isbn, string autor, int hojas, int estado):base(isbn,autor,hojas,estado)
        { 
        
        }
    }
}
