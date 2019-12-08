using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CapaEntidades;
using CapaNegocio;



namespace CapaPresentacion
{
   
    public partial class GredProductos : Form
    {

        private readonly CN_Ventas CNventas = new CN_Ventas();
        private FormVentas FVentas = new FormVentas();

        public GredProductos()
        {
            InitializeComponent();
        }

        private void GredProductos_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        private void TraerTodos()
        {
            List<CE_Ventas> productos = CNventas.Todos();

            if (productos.Count > 0)
            {
                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.DataSource = productos;
                dgvDatos.Columns["columnId"].DataPropertyName = "id";
                dgvDatos.Columns["columnProducto"].DataPropertyName = "nombreprod";
                dgvDatos.Columns["columnExistencia"].DataPropertyName = "stock";
                dgvDatos.Columns["columnPrecioventa"].DataPropertyName = "precio";
                //dgvDatos.Columns["columncategoria"].DataPropertyName = "nombrecat";
                //dgvDatos.Columns["columnIdcategoria"].DataPropertyName = "idcategoria";
                //dgvDatos.Columns["columnProveedor"].DataPropertyName = "nombreprov";
                //dgvDatos.Columns["columnIdproveedor"].DataPropertyName = "idproveedor";
            }
            else
                MessageBox.Show("No existen producto Registrado");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (dgvDatos.SelectedRows.Count > 0)
            {
                FormVentas ventas = new FormVentas();

                ventas.TxtId.Text = dgvDatos.CurrentRow.Cells["ColumnId"].Value.ToString();
                ventas.TxtProducto.Text = dgvDatos.CurrentRow.Cells["columnProducto"].Value.ToString();
                ventas.TxtExistencia.Text = dgvDatos.CurrentRow.Cells["columnExistencia"].Value.ToString();
                ventas.TxtPrecio.Text = dgvDatos.CurrentRow.Cells["columnPrecioventa"].Value.ToString();
                ////ddlCategoria = dgvDatos.CurrentRow.Cells["ColumnDireccion"].Value.ToString();
                //TraerPorId(Convert.ToInt32(TxtId.Text));
                
                 Close();


            }
            else
            {
                MessageBox.Show("Seleccione una fila para Editar");
            }


            
            




        }
    }
}
