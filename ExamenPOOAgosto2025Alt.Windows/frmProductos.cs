using ExamenPOOAgosto2025Alt.Datos;
using ExamenPOOAgosto2025Alt.Entidades;
using System;
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
    public partial class frmProductos : Form
    {
        private RepositorioProducto repo;
        private List<Producto> productos;
        public frmProductos()
        {
            InitializeComponent();
            repo = new RepositorioProducto();
            productos = new List<Producto>();
            productos = repo.ObtenerTodos().Values.ToList();

        }

        private void TsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            //frmProductosAE frm = new frmProductosAE(productos);
            //DialogResult dr = frm.ShowDialog(this);
            //if (DialogResult.Cancel == dr)
            //{
            //    return;
            //}
            //var producto = frm.GetProducto();
            ////repo.
            ////MessageBox.Show("Se agrego el producto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////MostrarDatos();
        }

        private void TsbBorrar_Click(object sender, EventArgs e)
        {

        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {

        }
        private void MostrarDatos()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in productos)
            {
                var r = CrearCeldas(dataGridView1);
                SeteraFila(r, item);
                AgregarFila(r);
            }
            TxtCantidadFiguras.Text = productos.Count().ToString();
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dataGridView1.Rows.Add(r);
        }

        private void SeteraFila(DataGridViewRow r, Producto p)
        {
            r.Cells[0].Value = p.GetType().ToString();
            r.Cells[1].Value = p.Descripcion;
            r.Cells[2].Value = p.Precio.ToString();
            r.Cells[1].Value = p.Stock.ToString();
          
           
            r.Tag = p;
        }

        private DataGridViewRow CrearCeldas(DataGridView dataGridView1)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGridView1);
            return r;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
