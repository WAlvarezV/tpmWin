using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercaClick.ServicioInventario;
using MercaClick.Inicio;

namespace MercaClick.Inventario
{
    public partial class frmGestionProducto : Form
    {
        ServicioInventario.ServicioInventario servInventario;
        InitialData iData;
        InitialData.ComboBoxItem cbItem;
        public frmGestionProducto()
        {
            InitializeComponent();
        }

        public frmGestionProducto(InitialData iData)
        {
            InitializeComponent();
            txtCodigoBarras.Focus();
            servInventario = new ServicioInventario.ServicioInventario();
            this.iData = iData;
        }

        private void frmGestionProducto_Load(object sender, EventArgs e)
        {            
            loadDataCmb();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ServicioInventario.producto producto = new producto()
            {
                CODIGO_BARRAS = txtCodigoBarras.Text,
                MODELO = txtModelo.Text,
                DESCRIPCION = txtDescripcion.Text,
                VALOR = Double.Parse(txtValor.Text),
                IMPUESTO = Double.Parse(txtImpuesto.Text),
                SERIAL = txtSerial.Text,
                ANULADO = 0
            };

            producto = servInventario.crearProducto(producto);
            if (producto != null)
                MessageBox.Show("Producto: " + producto.ID_PRODUCTO + " Creado: " + producto.MODELO);
        }

        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtCodigoBarras.Enabled = false;
                loadData();
            }

        }

        private void loadDataCmb()
        {
            //llenar combobox categorias
            if (iData.listCategoria != null && iData.listCategoria.Length > 0)
                foreach (ServicioInventario.tipoDato item in iData.listCategoria)
                {
                    cbItem = new InitialData.ComboBoxItem();
                    cbItem.Value = item.ID_TIPO_DATO;
                    cbItem.Text = item.DESCRIPCION;
                    cmbCategoria.Items.Add(cbItem);
                }
            //llenar combobox subcategorias
            if (iData.listSubCategoria != null && iData.listSubCategoria.Length > 0)
                foreach (ServicioInventario.tipoDato item in iData.listSubCategoria)
                {
                    cbItem = new InitialData.ComboBoxItem();
                    cbItem.Value = item.ID_TIPO_DATO;
                    cbItem.Text = item.DESCRIPCION;
                    cmbCategoria.Items.Add(cbItem);
                }
        }

        private void loadData()
        {
            ServicioInventario.producto producto = new producto()
            {
                CODIGO_BARRAS = txtCodigoBarras.Text                
            };

            producto = servInventario.buscarProducto(producto);

            if (producto != null)
            {
                if (!Convert.ToBoolean(producto.ANULADO))
                {
                    txtModelo.Text = producto.MODELO;
                    txtDescripcion.Text = producto.DESCRIPCION;
                    txtValor.Text = ""+producto.VALOR;
                    txtImpuesto.Text = ""+producto.IMPUESTO;
                    txtSerial.Text = producto.SERIAL;
                }
            }

                
        }

        private void clearData()
        {

            txtCodigoBarras.Clear();
            txtModelo.Clear();
            txtDescripcion.Clear();
            txtValor.Clear();
            txtImpuesto.Clear();
            txtSerial.Clear();

            txtCodigoBarras.Enabled = true;
            txtCodigoBarras.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clearData();
        }
    }
}
