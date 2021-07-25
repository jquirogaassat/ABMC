using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Devolver : Form
    {
        public Devolver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = listPmo.SelectedItem.ToString();
            var prestamoID = item.Split('-');
            int.TryParse(prestamoID[0], out int id);

            var prestamo = Program.dbBiblioteca.BuscarPmo(id);

            Program.dbBiblioteca.GenerarDevolucion(prestamo);
            MessageBox.Show("se ha completado la devolucion");

            actList();

        }

        private void Devolver_Load(object sender, EventArgs e)
        {
            actList();
        }

        private void actList()
        {
            listPmo.Items.Clear();
            listPmo.Items.Add("ID-ISBN-Nombre-Apellido-Fecha de prestamo");
            foreach(var item in Program.dbBiblioteca.ListarPmo())
            {
                listPmo.Items.Add($"{item.PrestamoId}-{item.MaterialesBibliograficos.ISBN}-{item.Socio.Nombre}- {item.Socio.Apellido}-{item.FechaPrestamo.ToString("dd/MM/yyyy ")}");
            }
        }

        private void listPmo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
