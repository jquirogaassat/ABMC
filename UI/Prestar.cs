using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Prestar : Form
    {
       

        public Prestar()
        {
            InitializeComponent();
        }

        private void Prestar_Load(object sender, EventArgs e)
        {
            comBoxIsbn.Text = "-Seleccionar-";
            comBoxSoc.Text = "-Seleccionar-";
            
             foreach (var item in Program.dbBiblioteca.ListarMatBilbiografico())
             {
               comBoxIsbn.Items.Add(item.ISBN);
             }
             foreach (var item in Program.dbBiblioteca.ListarSocio())
            {
                comBoxSoc.Items.Add(item.Numero);
            }
        }

        private void btn_prestar_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_id.Text, out int id);
            int.TryParse(comBoxIsbn.Text, out int isbn);
            int.TryParse(comBoxSoc.Text, out int numero);
            var socio = Program.dbBiblioteca.BuscarSocio(numero);

            var prestar = new BLL.Prestamo
            {
                FechaPrestamo = DateTime.Now,
                FechaDevolucion = DateTime.Now.AddDays(socio.DiasDePrestamo),
                MaterialesBibliograficos = Program.dbBiblioteca.buscarMatBib(isbn),
                PrestamoId = id,
                Socio = socio
            };
            Program.dbBiblioteca.GenerarPrestamo(prestar);
            MessageBox.Show("ok prestamo hecho");

            comBoxIsbn.Text = " ";
            txt_id.Text = " ";
            comBoxSoc.Text = " ";
            comBoxIsbn.Text = "-Seleccionar-";
            comBoxSoc.Text = "-Seleccionar-";
            
        }

        private void comBoxSoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(comBoxSoc.Text, out int numero);
            var socio = Program.dbBiblioteca.BuscarSocio(numero);
            date_dev.Value = DateTime.Now.AddDays(socio.DiasDePrestamo);
           

        }
     

        private void date_pmo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_dev_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
