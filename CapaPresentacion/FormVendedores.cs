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
    public partial class FormVendedores : Form
    {
        private CE_Vendedor _vendedor;
        private readonly CN_Vendedor CNVendedor = new CN_Vendedor();
        private bool Editar = false;
        private string idVendedor = null;
        public FormVendedores()
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
                    if (_vendedor == null)
                        _vendedor = new CE_Vendedor();

                    _vendedor.id = Convert.ToInt32(idVendedor);
                    _vendedor.nombre = Txtnombre.Text;
                    _vendedor.apellidopaterno = TxtApellidopaterno.Text;
                    _vendedor.apellidomaterno = TxtApellidomaterno.Text;
                    _vendedor.email = TxtEmail.Text;
                    _vendedor.direccion = TxtDireccion.Text;
                    _vendedor.telefono = Convert.ToInt32(TxtTelefono.Text);
                    

                    CNVendedor.Registrar(_vendedor);

                    if (CNVendedor.stringBuilder.Length != 0)
                    {
                        MessageBox.Show(CNVendedor.stringBuilder.ToString(), "Para continuar:");
                    }
                    else
                    {
                        MessageBox.Show("Vendedor registrado con éxito");

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
                    if (_vendedor == null)
                        _vendedor = new CE_Vendedor();

                    _vendedor.id = Convert.ToInt32(Txtid.Text);
                    _vendedor.nombre = Txtnombre.Text;
                    _vendedor.apellidopaterno = TxtApellidopaterno.Text;
                    _vendedor.apellidomaterno = TxtApellidomaterno.Text;
                    _vendedor.email = TxtEmail.Text;
                    _vendedor.direccion = TxtDireccion.Text;
                    _vendedor.telefono = Convert.ToInt32(TxtTelefono.Text);

                    CNVendedor.Registrar(_vendedor);

                    if (CNVendedor.stringBuilder.Length != 0)
                    {
                        MessageBox.Show(CNVendedor.stringBuilder.ToString(), "Para continuar:");
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
            List<CE_Vendedor> vendedor = CNVendedor.Todos();

            if (vendedor.Count > 0)
            {
                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.DataSource = vendedor;
                dgvDatos.Columns["ColumnId"].DataPropertyName = "id";
                dgvDatos.Columns["ColumnNombre"].DataPropertyName = "nombre";
                dgvDatos.Columns["ColumnAP"].DataPropertyName = "apellidopaterno";
                dgvDatos.Columns["ColumnAM"].DataPropertyName = "apellidomaterno";
                dgvDatos.Columns["ColumnEmail"].DataPropertyName = "email";
                dgvDatos.Columns["ColumnDireccion"].DataPropertyName = "direccion";
                dgvDatos.Columns["ColumnTelefono"].DataPropertyName = "telefono";
                
                

            }
            else
                MessageBox.Show("No existen Vendedores Registradas");

        }

        private void TraerPorId(int id)
        {
            try
            {
                _vendedor = CNVendedor.TraerPorId(id);

                if (_vendedor != null)
                {
                    lavel.Text = Convert.ToString(_vendedor.id);
                    Txtnombre.Text = _vendedor.nombre;
                    TxtApellidopaterno.Text = _vendedor.apellidomaterno;
                    TxtApellidomaterno.Text = _vendedor.apellidopaterno;
                    TxtEmail.Text = _vendedor.email;
                    TxtTelefono.Text = Convert.ToString(_vendedor.telefono);
                    TxtDireccion.Text = _vendedor.direccion;
                  


                }
                else
                    MessageBox.Show("El Vendedor solicitado no existe");
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
                CNVendedor.Eliminar(id);

                MessageBox.Show("Vendedor eliminado satisfactoriamente");

                TraerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }





        private void FormVendedores_Load(object sender, EventArgs e)
        {
            TraerTodos();
            Txtid.ReadOnly = true;
            Txtnombre.ReadOnly = true;
            TxtApellidopaterno.ReadOnly = true;
            TxtApellidomaterno.ReadOnly = true;
            TxtTelefono.ReadOnly = true;
            TxtEmail.ReadOnly = true;
            TxtDireccion.ReadOnly = true;
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            Guardar();
            TraerTodos();

            Txtid.Clear();
            Txtnombre.Clear();
            TxtApellidopaterno.Clear();
            TxtApellidomaterno.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtDireccion.Clear();
            

        }

        private void Txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(Txtid.Text))
            {
                e.SuppressKeyPress = true;

                TraerPorId(Convert.ToInt32(Txtid.Text));
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            if (!string.IsNullOrWhiteSpace(Txtid.Text))
            {
                TraerPorId(Convert.ToInt32(Txtid.Text));
            }

            Txtid.Clear();
            Txtnombre.Clear();
            TxtApellidopaterno.Clear();
            TxtApellidomaterno.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtDireccion.Clear();
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                Txtid.Text = dgvDatos.CurrentRow.Cells["ColumnId"].Value.ToString();

                Eliminar(Convert.ToInt32(Txtid.Text));
                MessageBox.Show("Eliminado Correctamente");
                TraerTodos();
            }
            else
            {
                MessageBox.Show("Seleccione el Vendedor a Eliminar");

            }



            //if (!string.IsNullOrWhiteSpace(txtid.Text))
            //{
            //    Eliminar(Convert.ToInt32(txtid.Text));
            //}
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Txtid.Clear();
            Txtnombre.Clear();
            TxtApellidopaterno.Clear(); 
            TxtApellidomaterno.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtDireccion.Clear();
            

            Txtid.ReadOnly = true;
            Txtnombre.ReadOnly = true;
            TxtApellidopaterno.ReadOnly = true;
            TxtApellidomaterno.ReadOnly = true;
            TxtTelefono.ReadOnly = true;
            TxtEmail.ReadOnly = true;
            TxtDireccion.ReadOnly = true;
            
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Txtid.ReadOnly = true;
            Txtnombre.ReadOnly = false;
            TxtApellidopaterno.ReadOnly = false;
            TxtApellidomaterno.ReadOnly = false;
            TxtTelefono.ReadOnly = false;
            TxtEmail.ReadOnly = false;
            TxtDireccion.ReadOnly = false;
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
