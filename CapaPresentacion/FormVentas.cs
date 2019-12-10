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


        public static int cont_fila = 0;
        public static double totalneto;

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            bool existe = false;
            int num_fila = 0;

            LblDescuento.Text = TxtDescuento.Text.ToString() + "%";
            //LblTotal.Text = (totalneto * ( Convert.ToDouble(TxtDescuento.Text) /100)).ToString();

            //LblTotal.Text = Convert.ToString((Convert.ToDouble(LblTotalneto.Text) - Convert.ToDouble(LblDescuento.Text)) * Convert.ToDouble(LblIva.Text));

            if (cont_fila == 0)
            {
                dgvDatos.Rows.Add(TxtId.Text, TxtProducto.Text, TxtPrecio.Text, TxtCantidad.Text, TxtDescuento.Text);
                double total = Convert.ToDouble(dgvDatos.Rows[cont_fila].Cells[2].Value) *  Convert.ToDouble(dgvDatos.Rows[cont_fila].Cells[3].Value);
                dgvDatos.Rows[cont_fila].Cells[5].Value = total;
                cont_fila++;
            }
            else
            {
                
                foreach (DataGridViewRow fila in dgvDatos.Rows)
                {
                    if(fila.Cells[0].Value.ToString() == TxtId.Text)
                    {
                        existe = true;
                        num_fila = fila.Index;
                    }
                }


                if ( existe == true)
                {
                    dgvDatos.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(TxtCantidad.Text) + Convert.ToDouble(dgvDatos.Rows[num_fila].Cells[3].Value)).ToString();
                    double total = Convert.ToDouble(dgvDatos.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dgvDatos.Rows[num_fila].Cells[3].Value);
                    dgvDatos.Rows[num_fila].Cells[5].Value = total;

                }
                else
                {
                    dgvDatos.Rows.Add(TxtId.Text, TxtProducto.Text, TxtPrecio.Text, TxtCantidad.Text, TxtDescuento.Text);
                    double total = Convert.ToDouble(dgvDatos.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgvDatos.Rows[cont_fila].Cells[3].Value);
                    dgvDatos.Rows[cont_fila].Cells[5].Value = total;
                    cont_fila++;
                }
            }

            totalneto = 0;
            foreach (DataGridViewRow fila in dgvDatos.Rows)
            {
                totalneto += Convert.ToDouble(fila.Cells[5].Value);
            }
            LblTotalneto.Text = "C$" + totalneto.ToString();


        }


        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                totalneto = totalneto - (Convert.ToDouble(dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[5].Value));
                LblTotalneto.Text = "C$" + totalneto.ToString();
                dgvDatos.Rows.RemoveAt(dgvDatos.CurrentRow.Index);
                cont_fila--;
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
