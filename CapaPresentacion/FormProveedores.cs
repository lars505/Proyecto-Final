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
    public partial class FormProveedores : Form
    {

        private CE_Proveedor _proveedor;
        private readonly CN_Proveedor CNProveedor = new CN_Proveedor();
        private bool Editar = false;
        private string idPoveedor = null;

        public FormProveedores()
        {
            InitializeComponent();
        }

        private void Guardar()
        {
            if (Editar == false)
            {
                //string idProveedor = "0";
                try
                {
                    if (_proveedor == null)
                        _proveedor = new CE_Proveedor();

                    _proveedor.id = Convert.ToInt32(idPoveedor);
                    _proveedor.nombre = txtnombre.Text;
                    _proveedor.email = txtemail.Text;
                    _proveedor.telefono = Convert.ToInt32(txttelefono.Text);
                    _proveedor.direccion = txtdireccion.Text;
                    _proveedor.ciudad = txtciudad.Text;

                    CNProveedor.Registrar(_proveedor);

                    if (CNProveedor.stringBuilder.Length != 0)
                    {
                        MessageBox.Show(CNProveedor.stringBuilder.ToString(), "Para continuar:");
                    }
                    else
                    {
                        MessageBox.Show("Proveedor registrado con éxito");

                        TraerTodos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
                }

            }

            if (Editar == true)
            {
                
                try
                {
                    if (_proveedor == null)
                        _proveedor = new CE_Proveedor();

                    _proveedor.id = Convert.ToInt32(txtid.Text);
                    _proveedor.nombre = txtnombre.Text;
                    _proveedor.email = txtemail.Text;
                    _proveedor.telefono = Convert.ToInt32(txttelefono.Text);
                    _proveedor.direccion = txtdireccion.Text;
                    _proveedor.ciudad = txtciudad.Text;

                    CNProveedor.Registrar(_proveedor);

                    if (CNProveedor.stringBuilder.Length != 0)
                    {
                        MessageBox.Show(CNProveedor.stringBuilder.ToString(), "Para continuar:");
                    }
                    else
                    {
                        MessageBox.Show("Proveedor actualizado con éxito");

                        TraerTodos();
                    }
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
                }



            }
        }


        private void TraerTodos()
        {
            List<CE_Proveedor> proveedor = CNProveedor.Todos();

            if (proveedor.Count > 0)
            {
                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.DataSource = proveedor;
                dgvDatos.Columns["ColumnId"].DataPropertyName = "id";
                dgvDatos.Columns["ColumnNombre"].DataPropertyName = "nombre";
                dgvDatos.Columns["ColumnEmail"].DataPropertyName = "email";
                dgvDatos.Columns["ColumnTelefono"].DataPropertyName = "telefono";
                dgvDatos.Columns["ColumnDireccion"].DataPropertyName = "direccion";
                dgvDatos.Columns["ColumnCiudad"].DataPropertyName = "ciudad";

            }
            else
                MessageBox.Show("No existen las Categorias Registradas");

        }

        private void TraerPorId(int id)
        {
            try
            {
                _proveedor = CNProveedor.TraerPorId(id);

                if (_proveedor != null)
                {
                    txtid.Text = Convert.ToString(_proveedor.id);
                    txtnombre.Text = _proveedor.nombre;
                    txtemail.Text = _proveedor.email;
                    txttelefono.Text = Convert.ToString(_proveedor.telefono);
                    txtdireccion.Text = _proveedor.direccion;
                    txtciudad.Text = _proveedor.ciudad;


                }
                else
                    MessageBox.Show("El Proveedor solicitado no existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        private void Eliminar(int id)
        {
            try
            {
                CNProveedor.Eliminar(id);

                MessageBox.Show("Proveedor eliminado satisfactoriamente");

                TraerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }






        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {

            TraerTodos();
            txtid.ReadOnly= true;
            txtnombre.ReadOnly = false;
            txttelefono.ReadOnly = true;
            txtemail.ReadOnly = true;
            txtdireccion.ReadOnly = true;
            txtciudad.ReadOnly = true;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
            TraerTodos();

            txtid.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtdireccion.Clear();
            txtciudad.Clear();
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(txtid.Text))
            {
                e.SuppressKeyPress = true;

                TraerPorId(Convert.ToInt32(txtid.Text));
            }
        }



        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            if (dgvDatos.SelectedRows.Count > 0)
            {
                txtid.Text = dgvDatos.CurrentRow.Cells["ColumnId"].Value.ToString();
                txtnombre.Text = dgvDatos.CurrentRow.Cells["ColumnNombre"].Value.ToString();
                txtemail.Text = dgvDatos.CurrentRow.Cells["ColumnEmail"].Value.ToString();
                txtdireccion.Text = dgvDatos.CurrentRow.Cells["ColumnDireccion"].Value.ToString();
                txtciudad.Text = dgvDatos.CurrentRow.Cells["ColumnCiudad"].Value.ToString();
                TraerPorId(Convert.ToInt32(txtid.Text));


            }
            else
            {
                MessageBox.Show("Seleccione el Proveedor a Editar");


            }

            if (!string.IsNullOrWhiteSpace(txtid.Text))
            {
                TraerPorId(Convert.ToInt32(txtid.Text));
            }

            //txtid.Clear();
            //txtnombre.Clear();
            //txttelefono.Clear();
            //txtemail.Clear();
            //txtdireccion.Clear();
            //txtciudad.Clear();
            txtid.Enabled = true;
            txtnombre.Enabled = true;
            txtid.ReadOnly = false;
            

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvDatos.SelectedRows.Count > 0)
            {
                txtid.Text = dgvDatos.CurrentRow.Cells["ColumnId"].Value.ToString();
                
                Eliminar(Convert.ToInt32(txtid.Text));
                MessageBox.Show("Eliminado Correctamente");
                TraerTodos();
            }
            else
            {
                MessageBox.Show("Seleccione el Proveedor a Eliminar");

            }



            //if (!string.IsNullOrWhiteSpace(txtid.Text))
            //{
            //    Eliminar(Convert.ToInt32(txtid.Text));
            //}
        }

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            txtid.ReadOnly = true;
            txtnombre.ReadOnly = false;
            txttelefono.ReadOnly = false;
            txtemail.ReadOnly = false;
            txtdireccion.ReadOnly = false;
            txtciudad.ReadOnly = false;
        }

        private void txtcancelar_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtdireccion.Clear();
            txtciudad.Clear();

            txtid.ReadOnly = true;
            txtnombre.ReadOnly = true;
            txttelefono.ReadOnly = true;
            txtemail.ReadOnly = true;
            txtdireccion.ReadOnly = true;
            txtciudad.ReadOnly = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
