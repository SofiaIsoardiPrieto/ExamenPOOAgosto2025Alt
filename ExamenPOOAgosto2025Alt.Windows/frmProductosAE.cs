using ExamenPOOAgosto2025Alt.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPOOAgosto2025Alt.Windows
{

    public partial class frmProductosAE : Form
    {
        private Producto producto;
        List<Producto> _lista;
        public frmProductosAE(List<Producto> lista)
        {
            InitializeComponent();
            _lista = lista;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //if (producto == null //y el combo que no se cargar)
                //{
                //    producto = new Diario();
                //    ((Diario)producto).FechaPublicacion = DateTime.Now.Date;
                //}
                //producto.Descripcion = txtDescripcion.Text;
                //producto.Stock = int.Parse(txtStock.Text);
                //producto.Precio = decimal.Parse(txtPrecio.Text);
                //if (//segun combo)
                //{
                   
                //}
             
                DialogResult = DialogResult.OK;
            }

        }
        private bool ValidarDatos()
        {
            bool valido = true;
            if (!int.TryParse(txtPrecio.Text, out int i) || i <= 0)
            {
                valido = false;
                MessageBox.Show("La cantidad debe ser un número mayor a 0", "Advertencia", MessageBoxButtons.OK);
            }
           
            if (!int.TryParse(txtStock.Text, out int e) || e <= 0)
            {
                valido = false;
                MessageBox.Show("El número de venta debe ser un número mayor a 0", "Advertencia", MessageBoxButtons.OK);
            }
            return valido;
        }
        internal Producto GetProducto()
        {
            return producto;
        }

        private void frmProductosAE_Load(object sender, EventArgs e)
        {
           // CargarCombo(ref comboTipo);
        }
        private void CargarCombo(ref ComboBox comboProductos)
        {
           
            //_lista.Insert(0, TipoProducto.Revista);
            //comboProductos.DataSource = _lista;
            //comboProductos.DisplayMember = "Descripcion";
            //comboProductos.ValueMember = "Codigo";
            //comboProductos.SelectedIndex = 0;
        }
    }
}
