using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
namespace CapaPresentacion
{
    public partial class MDI : Form
    {
        CN_Producto llamarfun = new CN_Producto();
        CN_Categoria categoria = new CN_Categoria();
        CN_Proveedor proveedor = new CN_Proveedor();
        CN_Vendedor vendedor = new CN_Vendedor();

        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormCategoria nuevo = new FormCategoria();
            
            //if (categoria.FormOneInstancia(this, "Categorias"))
            //{
            //    return;
            //}
            FormCategoria fcategoria = new FormCategoria();
            fcategoria.MdiParent = this;
            //fcategoria.Text = "Categorias";
            fcategoria.Show();
           
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //if (FormOneInstancia(this, "Proveedores"))
            //{
            //    return;
            //}
            FormProveedores fproveedores = new FormProveedores();
            fproveedores.MdiParent = this;
            //fproveedores.Text = "Proveedores";
            fproveedores.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVendedores nuevo = new FormVendedores();
            //if (llamarfun.FormOneInstancia(this, "Usuarios"))
            //{
            //    return;
            //}

            nuevo.MdiParent = this;
            //nuevo.Text = "Usuarios";
            nuevo.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //nuevo.MdiParent = this;
            //nuevo.Show();
            
            
            
            if (llamarfun.FormOneInstancia(this,"Productos"))
            {
                return;
            }
            FormProductos fproductos = new FormProductos();
            fproductos.MdiParent = this;
            fproductos.Text = "Productos";
            fproductos.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abouthToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentas nuevo = new FormVentas();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente nuevo = new FormCliente();
            nuevo.MdiParent = this;
            nuevo.Show();
        }
    }
}
