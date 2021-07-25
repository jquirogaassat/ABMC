using BLL.Enums.MaterialBibliografico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Revista : MaterialBibliografico
    {

        
        public Revista(int isbn, string autor, int hojas, Estado estado):base(isbn, autor, hojas, estado)
        {

        }
        public Revista(int isbn, string autor, int hojas, int estado) : base(isbn, autor, hojas, estado)
        {

        }
    }
}
