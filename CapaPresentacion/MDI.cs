using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MDI : Form
    {
     
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategoria nuevo = new FormCategoria();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedores nuevo = new FormProveedores();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVendedores nuevo = new FormVendedores();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos nuevo = new FormProductos();
            nuevo.MdiParent = this;
            nuevo.Show();
            
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
    }
}
