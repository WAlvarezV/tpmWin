using MercaClick.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercaClick
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void smiGestiónProductos_Click(object sender, EventArgs e)
        {
            loadForm(new frmGestionProducto());
        }

        #region Métodos Propios

        private void loadForm(Form unForm)
        {
            unForm.MdiParent = this;
            unForm.WindowState = FormWindowState.Maximized;
            unForm.BringToFront();
            unForm.Show();
        }
        #endregion
    }
}
