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
    public partial class Socio : Form
    {
        public Socio()
        {
            InitializeComponent();
        }

        private void Socio_Load(object sender, EventArgs e)
        {
            comb_cat.Text = "Seleccionar";
            comb_cat.Items.Add("Platino");
            comb_cat.Items.Add("Oro");
            comb_cat.Items.Add("Plata");
            comb_prov.Text = "Seleccionar";

            var s = Enum.GetValues(typeof(BLL.Enums.Direccion.Provincia));
                foreach (var item in s)
            {
                comb_prov.Items.Add(item);
            }

        }

       

        private void btn_alta_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txt_nrosoc.Text, out int numero);

               // foreach(var num in Program.dbBiblioteca.ListarSocio())
                //{
                  //  if(numero==)
                   // { MessageBox.Show("El numero de socio ya existe"); }
                //}
                
                if(comb_cat.SelectedItem.ToString()=="Platino")
                {
                    Program.dbBiblioteca.AgregarSocio(new BLL.Platino(numero, txt_nom.Text, txt_ape.Text, comb_prov.SelectedIndex));                   
                    MessageBox.Show("Socio PLATINO agregado exitosamente");
                }
                if(comb_cat.SelectedItem.ToString()=="Oro")
                {
                    Program.dbBiblioteca.AgregarSocio(new BLL.Oro(numero, txt_nom.Text, txt_ape.Text, comb_prov.SelectedIndex));
                    MessageBox.Show("Socio ORO agregado exitosamente");
                }
                if(comb_cat.SelectedItem.ToString()=="Plata")
                {
                    Program.dbBiblioteca.AgregarSocio(new BLL.Plata(numero, txt_nom.Text, txt_ape.Text, comb_prov.SelectedIndex));
                    MessageBox.Show("Socio PLATA agregado exitosamente");
                }



            }catch(Exception)
            {
                MessageBox.Show("no se puede dar de alta, verifique que haya completado todos los campos", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            cargarListSocio();
            txt_nrosoc.Text = "";
            txt_nom.Text = "";
            txt_ape.Text = "";
            comb_cat.Text = "Seleccionar";
            comb_prov.Text = "Seleccionar";
        }

        private void cargarListSocio()
        {
            list_soc.Items.Clear();
            foreach (var soc in Program.dbBiblioteca.ListarSocio())
            {
                list_soc.Items.Add($"{soc.Numero}-{soc.Nombre}-{soc.Apellido}-{soc.Provincia}-{comb_cat.Text}");
            }
        }
        private void txt_nrosoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            try
            {
                var item = list_soc.SelectedItem.ToString();
                var socId = item.Split('-');
                int.TryParse(socId[0], out int numero);

                var soc = Program.dbBiblioteca.BuscarSocio(numero);
                var deleteSoc = Program.dbBiblioteca.EliminarSocio(soc);

                if(deleteSoc)
                {
                    list_soc.Items.Remove(item);
                }
                MessageBox.Show("El socio ha sido eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception)
            {
                MessageBox.Show("Por favor seleccione un socio de la lista");
                throw;
            }
        }
    }
}
