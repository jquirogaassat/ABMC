using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Repositories;

namespace UI
{
    public partial class Vencimientos : Form
    {
        public Vencimientos()
        {
            InitializeComponent();
        }

        public BLL.Prestamo prestamo1;// declaro pmo
        private void Vencimientos_Load(object sender, EventArgs e)
        {
            prestamo1 = new BLL.Prestamo(); // instancio
            // actList();
            cargarListPmo();
        }

        private void cargarListPmo()
        {
            list_vencimientos.Items.Clear();
            foreach (var pmoVen in Program.dbBiblioteca.ListarPmo())
            {
                list_vencimientos.Items.Add($"{pmoVen.PrestamoId}-{pmoVen.MaterialesBibliograficos}-{pmoVen.Socio.Apellido}-{pmoVen.FechaPrestamo}- {pmoVen.FechaDevolucion}");
            }
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            //var item = list_vencimientos.SelectedItem.ToString();
           

           // BLL.Prestamo prestamo1 = new BLL.Prestamo(); // instancio
            prestamo1.PrestamoVencidoEvent += Prestamo1_PrestamoVencidoEvent; // funcion con nombre

           // prestamo1.PrestamoVencidoEvent += delegate (int m)  
           // { MessageBox.Show($"Evento disparado con funcion anonima {m}"); };

            prestamo1.CantidadDeDiasParaVencer();

        }

      
        private void Prestamo1_PrestamoVencidoEvent(int diasVencido)
        {
            MessageBox.Show($"Dias vencido{diasVencido}");
        }
    }
}
