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
       
        private readonly CN_Ventas CNVenta = new CN_Ventas();
        private readonly CN_Vendedor CNvendedor = new CN_Vendedor();
        




        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            LblFecha.Text = Convert.ToString(Convert.ToDateTime( DateTime.Today));
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


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Add(TxtId.Text,TxtProducto.Text, TxtPrecio.Text, TxtCantidad.Text, TxtDescuento.Text, TxtTotal.Text).ToString();
                
        }


        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {

            }
            else
            {
             MessageBox.Show("Seleccione el Proveedor a Eliminar");
            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }






















































        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtFecha_TextChanged_1(object sender, EventArgs e)
        {

        }

        
    }
}
