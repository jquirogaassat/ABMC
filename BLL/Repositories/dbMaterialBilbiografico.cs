using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    internal class dbMaterialBilbiografico : ICRUD<BLL.MaterialBibliografico>
    {
        private List<BLL.MaterialBibliografico> materialBibliograficos1 = new List<MaterialBibliografico>();
        public void Add(MaterialBibliografico objAlta)
        {
            materialBibliograficos1.Add(objAlta);
        }

        public MaterialBibliografico Find (int isbn)
        {
            return materialBibliograficos1.SingleOrDefault(x => x.ISBN == isbn);
        }

        public bool Delete(MaterialBibliografico objBaja)
        {
            return materialBibliograficos1.Remove(objBaja);
        }

        public List<MaterialBibliografico> ListAll()
        {
            return materialBibliograficos1;
        }

        public bool Update(MaterialBibliografico objUpdate)
        {
            var mat = this.materialBibliograficos1.Find(x => x.ISBN == objUpdate.ISBN);
            if(mat!=null)
            {
                mat.ISBN = objUpdate.ISBN;
                mat.Hojas = objUpdate.Hojas;
                mat.Autor = objUpdate.Autor;
                mat.Estado = objUpdate.Estado;
                return true;

            }
            return false;
        }
    }
}
