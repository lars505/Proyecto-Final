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
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FormVentas : Form
    {
        private CE_Ventas _ventas;
        private readonly CN_Ventas CNVenta = new CN_Ventas();
        private readonly CN_Vendedor CNvendedor = new CN_Vendedor();


        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            TxtFecha.Text = Convert.ToString(DateTime.Today);
            LLenarComboVendedor();
            
        }

        

        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BrnAprod_Click_1(object sender, EventArgs e)
        {
            GredProductos nuevo = new GredProductos();

            nuevo.Show();
            //GredProductos.Select();
            

        }

        private void LLenarComboVendedor()
        {
            List<CE_Vendedor> proveedor = CNvendedor.Todos();

            if (proveedor.Count > 0)
            {
                ddlVendedor.DataSource = proveedor;
                ddlVendedor.DisplayMember = "nombre";
                ddlVendedor.ValueMember = "id";
            }
            else
                MessageBox.Show("No existen Proveedores Registradas");
        }

























































        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtFecha_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
