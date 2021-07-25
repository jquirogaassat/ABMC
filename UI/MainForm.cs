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
    public partial class MainForm : Form
    {

        public BLL.Repositories.dbBliblioteca Biblioteca { get; set; }
        public MainForm()
        {
            InitializeComponent();
            Biblioteca = new BLL.Repositories.dbBliblioteca();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialBilbiografico materialBilbiografico = new MaterialBilbiografico();
            // Con esto lo transformamos en SDI ( contenido dentro  del MDI MainForm )
            materialBilbiografico.MdiParent = this;
            materialBilbiografico.Show();
        }

        private void aBMCToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            Socio socio = new Socio();
            // Con esto lo transformamos en SDI ( contenido dentro  del MDI MainForm )
            socio.MdiParent = this;
            socio.Show();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrestamoParam prestamoParam = new PrestamoParam();
            // Con esto lo transformamos en SDI ( contenido dentro  del MDI MainForm )
            prestamoParam.MdiParent = this;
            prestamoParam.Show();
        }

        private void consultarVencimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vencimientos vencimientos = new Vencimientos();
            // Con esto lo transformamos en SDI ( contenido dentro  del MDI MainForm )
            vencimientos.MdiParent = this;
            vencimientos.Show();
        }

        private void prestarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestar prestar = new Prestar();
            prestar.MdiParent = this;
            prestar.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void devolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolver devolver = new Devolver();
            devolver.MdiParent = this;
            devolver.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
