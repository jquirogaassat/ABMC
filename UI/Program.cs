using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Repositories;

namespace UI
{
    public static class Program
    {
        internal static BLL.Repositories.dbBliblioteca dbBiblioteca = new dbBliblioteca();
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //dbBiblioteca = new dbBliblioteca();

        }
    }
}
