using MercaClick.Inicio;
using MercaClick.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercaClick
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitialData iData = new InitialData();
            Application.Run(new frmGestionProducto(iData));
        }
    }
}
