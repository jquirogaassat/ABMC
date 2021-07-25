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
    public partial class MaterialBilbiografico : Form
    {    
        public MaterialBilbiografico()
        {
            InitializeComponent();
            
        }

        private void MaterialBilbiografico_Load(object sender, EventArgs e)
        {
            comBoxEs.Text = "-SELECCIONAR-";
            comBoxTip.Text = "-SELECCIONAR-";
            comBoxTip.Items.Add("Libro");
            comBoxTip.Items.Add("Revista");

            var a = Enum.GetValues(typeof(BLL.Enums.MaterialBibliografico.Estado));
            foreach(var item in a)
            {
                comBoxEs.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtBoxIsbn.Text, out int isbn);
                int.TryParse(txtBoxHojas.Text, out int hojas);

                if (isbn == 0 && hojas == 0)
                {
                    throw new Exception("error!!");
                }
                else if  (comBoxTip.SelectedItem.ToString() == "Revista")
                {   
                    Program.dbBiblioteca.agregarMatBib(new BLL.Revista(isbn, txtBoxAutor.Text, hojas, comBoxEs.SelectedIndex));
                    MessageBox.Show(" se agrgego una revista");
                }
                else if (comBoxTip.SelectedItem.ToString() == "Libro")
                {
                    Program.dbBiblioteca.agregarMatBib(new BLL.Libro(isbn, txtBoxAutor.Text, hojas, comBoxEs.SelectedIndex));
                    MessageBox.Show("Se agrego un libro");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("no se puede dar de alta, verifique que haya completado todos los campos", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            cargarListMatBib();
            txtBoxAutor.Text = "";
            txtBoxHojas.Text = "";
            txtBoxIsbn.Text = "";


               }

        private void listMatBib_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargarListMatBib()
        {
            listMatBib.Items.Clear();
            foreach (var matBib in Program.dbBiblioteca.ListarMatBilbiografico())
            {
                listMatBib.Items.Add($"{matBib.ISBN}-{matBib.Autor}-{matBib.Hojas}-{matBib.Estado}- {comBoxTip.Text}");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                var item = listMatBib.SelectedItem.ToString();
                var matBibId = item.Split('-');
                int.TryParse(matBibId[0], out int isbn);

                var matBib = Program.dbBiblioteca.buscarMatBib(isbn);

                var elMatBib = Program.dbBiblioteca.BorrarMatBib(matBib);

                if(elMatBib)
                {
                    listMatBib.Items.Remove(item);
                }
            }catch(Exception)
            {
                MessageBox.Show("no se puede eliminar, asegurese de seleccionar material de la lista", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarListMatBib();
        }

        private void txtBoxIsbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxHojas_TextChanged(object sender, EventArgs e)
        {
            //this.txtBoxHojas;
        }
    }
    }

