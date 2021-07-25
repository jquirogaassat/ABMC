using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Repositories
{
    public class dbBliblioteca
    {
        private List<BLL.Prestamo> prestamos1 = new List<Prestamo>();
        private dbSocios dbSocios1 = new dbSocios();
        private dbMaterialBilbiografico materialBilbiografico1 = new dbMaterialBilbiografico();
        
        
        public void GenerarPrestamo(BLL.Prestamo prestamo)
        {
            var buscar = prestamos1.Find(x => x.MaterialesBibliograficos.ISBN == prestamo.MaterialesBibliograficos.ISBN && 
                                        x.Socio == prestamo.Socio);
            if(buscar == null)
            {
                prestamos1.Add(prestamo);
            }

             
        }
        public List<BLL.Prestamo> ListarPmo()
        {
            return prestamos1;
        
        }

        public BLL.Prestamo BuscarPmo(int id)
        {
            return this.prestamos1.Single(p1 => p1.PrestamoId == id);
        }

        public void AgregarSocio(Socio socio)
        {
            this.dbSocios1.Add(socio);
        }


        public BLL.Socio BuscarSocio(int nroSoc)    
        {

            return this.dbSocios1.Find( nroSoc);
        }

        public bool EliminarSocio (Socio socio)
        {
            return this.dbSocios1.Delete(socio);
        }

        public List<BLL.Socio> ListarSocio()
        {
            return this.dbSocios1.ListAll();
        }
        public BLL.Prestamo BuscarPorMaterialBibliografico(BLL.MaterialBibliografico materialBibliografico)
        {
            throw new NotImplementedException();
            //return this.materialBilbiografico1.Find(materialBibliografico);

        }

        public void GenerarDevolucion(BLL.Prestamo prestamo)
        {
            this.prestamos1.Remove(prestamo);
        }

        public List<BLL.MaterialBibliografico> ListarMatBilbiografico()
        {
            //BLL.Repositories.dbMaterialBilbiografico materialBilbiografico = new dbMaterialBilbiografico();
            return materialBilbiografico1.ListAll();
        
        }

        public BLL.MaterialBibliografico buscarMatBib(int isbn)
        {
            return materialBilbiografico1.Find(isbn);
        }

        public void agregarMatBib(MaterialBibliografico matBib)
        {
            this.materialBilbiografico1.Add(matBib);
        }

        public bool BorrarMatBib (MaterialBibliografico matBib)
        {
            return  this.materialBilbiografico1.Delete(matBib);
            
        }

    }
}
