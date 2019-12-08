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
    public partial class FormProductos : Form
    {

        private CE_Producto _producto;
        private readonly CN_Producto CNproducto = new CN_Producto();
        private CE_Categoria _Categoria;
        private readonly CN_Categoria CNcategoria = new CN_Categoria();
        private readonly CN_Proveedor CNproveedor = new CN_Proveedor();
        private string Estado = "No Disponible" ;
        private string idProducto = null;
        private bool Editar = false;
        private string idtemp;



        public FormProductos()
        {
            InitializeComponent();
        }


        private void Guardar()
        {
            if(Editar == false)
            { 
                try
                {
                    if (_producto == null)
                        _producto = new CE_Producto();

                    _producto.id = Convert.ToInt32(idProducto);
                    _producto.nombre = TxtNombreProducto.Text;
                    _producto.descripcion = TxtDescripcion.Text;
                    //_producto.pbImagen = PBImagen;

                    if (CkEstado.Checked == true)
                    {
                        Estado = "Disponible";
                    }
              
                    if (CkEstado.Checked == false)
                        {
                            Estado = "No Disponible";
                        }

                    _producto.estado = Estado;
                    _producto.idcategoria = Convert.ToInt32(ddlCategoria.SelectedValue);
                    _producto.idproveedor = Convert.ToInt32(ddlProveedor.SelectedValue);

                    CNproducto.Registrar(_producto);

                    if (CNproducto.stringBuilder.Length != 0)
                    {
                        MessageBox.Show(CNproducto.stringBuilder.ToString(), "Para continuar:");
                    }
                    else
                    {
                        MessageBox.Show("Producto registrado/actualizado con éxito");

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
                    if (_producto == null)
                        _producto = new CE_Producto();

                    _producto.id = Convert.ToInt32(TxtId.Text);
                    _producto.nombre = TxtNombreProducto.Text;
                    _producto.descripcion = TxtDescripcion.Text;
                    //_producto.pbImagen = PBImagen;

                    if (CkEstado.Checked == true)
                    {
                        Estado = "Disponible";
                    }

                    if (CkEstado.Checked == false)
                    {
                        Estado = "No Disponible";
                    }

                    _producto.estado = Estado;
                    _producto.idcategoria = Convert.ToInt32(ddlCategoria.SelectedValue);
                    _producto.idproveedor = Convert.ToInt32(ddlProveedor.SelectedValue);

                    CNproducto.Registrar(_producto);

                    if (CNproducto.stringBuilder.Length != 0)
                    {
                        MessageBox.Show(CNproducto.stringBuilder.ToString(), "Para continuar:");
                    }
                    else
                    {
                        MessageBox.Show("Producto registrado/actualizado con éxito");

                        TraerTodos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
                }

            }
        }
        
        


        private void TraerTodos()
        {
            List<CE_Producto> productos = CNproducto.Todos();

            if (productos.Count > 0)
            {
                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.DataSource = productos;
                dgvDatos.Columns["columnId"].DataPropertyName = "id";
                dgvDatos.Columns["columnProducto"].DataPropertyName = "nombre";
                dgvDatos.Columns["columnDescripcion"].DataPropertyName = "Descripcion";
                dgvDatos.Columns["columnEstado"].DataPropertyName = "Estado";
                dgvDatos.Columns["columncategoria"].DataPropertyName = "nombrecat";
                dgvDatos.Columns["columnIdcategoria"].DataPropertyName = "idcategoria";
                dgvDatos.Columns["columnProveedor"].DataPropertyName = "nombreprov";
                dgvDatos.Columns["columnIdproveedor"].DataPropertyName = "idproveedor";
            }
            else
                MessageBox.Show("No existen producto Registrado");
        }


        private void LLenarComboCategoria()
        {
            List<CE_Categoria> categorias = CNcategoria.Todos();

            if (categorias.Count > 0)
            {
                ddlCategoria.DataSource = categorias;
                ddlCategoria.DisplayMember = "nombre";
                ddlCategoria.ValueMember = "id";
            }
            else
                MessageBox.Show("No existen categorias Registradas");
        }

        private void LLenarComboProveedores()
        {
            List<CE_Proveedor> proveedor = CNproveedor.Todos();

            if (proveedor.Count > 0)
            {
                ddlProveedor.DataSource = proveedor;
                ddlProveedor.DisplayMember = "nombre";
                ddlProveedor.ValueMember = "id";
            }
            else
                MessageBox.Show("No existen Proveedores Registradas");
        }


        private void TraerPorId(int id)
        {
            try
            {
                _producto = CNproducto.TraerPorId(id);

                if (_producto != null)
                {
                    TxtId.Text = Convert.ToString(_producto.id);
                    TxtNombreProducto.Text = _producto.nombre;
                    TxtDescripcion.Text = _producto.descripcion;
                    string E = Convert.ToString(_producto.estado);
                    if (E == "Disponible")
                    {
                        CkEstado.Checked = true;

                    }
                    if (E == "No Disponible")
                    {
                        CkEstado.Checked = false;

                    }


                    ddlCategoria.Text = Convert.ToString(_producto.nombrecat);
                }
                else
                    MessageBox.Show("El Producto solicitado no existe");
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
                CNproducto.Eliminar(id);

                MessageBox.Show("Producto eliminado satisfactoriamente");

                TraerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }







        private void FormProductos_Load(object sender, EventArgs e)
        {
            TraerTodos();
            LLenarComboCategoria();
            LLenarComboProveedores();

            TxtId.ReadOnly = true;
            TxtNombreProducto.ReadOnly = true;
            TxtDescripcion.ReadOnly = true;
            CkEstado.Enabled = false;
            ddlCategoria.Enabled = false;
            ddlProveedor.Enabled = false;

            BtnEliminar.Enabled = true;
            BtnAgreagr.Enabled = false;
            BtnCancelar.Enabled = false;
        }

        private void BtnAgreagr_Click(object sender, EventArgs e)
        {
            Guardar();
            TraerTodos();
            TxtId.ReadOnly = true;
            TxtNombreProducto.ReadOnly = true;
            TxtDescripcion.ReadOnly = true;
            CkEstado.Enabled = false;
            ddlCategoria.Enabled = false;
            ddlProveedor.Enabled = false;

            TxtId.Clear();
            TxtNombreProducto.Clear();
            TxtDescripcion.Clear();
            CkEstado.Checked = false;

            BtnEliminar.Enabled = true;
            BtnAgreagr.Enabled = false;
            BtnCancelar.Enabled = false;



        }


        private void TxtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(TxtId.Text))
            {
                e.SuppressKeyPress = true;

                TraerPorId(Convert.ToInt32(TxtId.Text));
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;

            if (dgvDatos.SelectedRows.Count > 0)
            {
                TxtId.Text = dgvDatos.CurrentRow.Cells["ColumnId"].Value.ToString();
                TxtNombreProducto .Text = dgvDatos.CurrentRow.Cells["columnProducto"].Value.ToString();
                TxtDescripcion.Text = dgvDatos.CurrentRow.Cells["columnDescripcion"].Value.ToString();
                //ddlCategoria = dgvDatos.CurrentRow.Cells["ColumnDireccion"].Value.ToString();
                TraerPorId(Convert.ToInt32(TxtId.Text));

                TxtNombreProducto.ReadOnly = false;
                TxtDescripcion.ReadOnly = false;
                ddlCategoria.Enabled = true;
                ddlProveedor.Enabled = true;
                BtnAgreagr.Enabled = true;
                CkEstado.Enabled = true;
                TxtId.ReadOnly = false;

            }
            else
            {
                MessageBox.Show("Seleccione una fila para Editar");
            }

            
            //if (!string.IsNullOrWhiteSpace(TxtId.Text))
            //{
            //    TraerPorId(Convert.ToInt32(TxtId.Text));
            //}
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
            if (dgvDatos.SelectedRows.Count > 0)
            {
                
                idtemp = dgvDatos.CurrentRow.Cells["ColumnId"].Value.ToString();

                Eliminar(Convert.ToInt32(idtemp));
                MessageBox.Show("Eliminado Correctamente");
                TraerTodos();
            }
            else
            {
                MessageBox.Show("Seleccione el Producto a Eliminar");

            }


            //if (!string.IsNullOrWhiteSpace(TxtId.Text))
            //{
            //    Eliminar(Convert.ToInt32(TxtId.Text));
            //}
        }

        private void ddlProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtId.ReadOnly = true;
            TxtNombreProducto.ReadOnly= false;
            TxtDescripcion.ReadOnly = false;
            CkEstado.Enabled = true;
            ddlCategoria.Enabled = true;
            ddlProveedor.Enabled = true;

            BtnEliminar.Enabled = false;
            BtnAgreagr.Enabled = true;
            BtnCancelar.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCategoria nuevo = new FormCategoria();
            nuevo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProveedores nuevo = new FormProveedores();
            nuevo.Show();

        }

        private void BtnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    PBImagen.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtId.ReadOnly = true;
            TxtNombreProducto.ReadOnly = true;
            TxtDescripcion.ReadOnly = true;
            CkEstado.Enabled = false;
            ddlCategoria.Enabled = false;
            ddlProveedor.Enabled = false;

            TxtId.Clear();
            TxtNombreProducto.Clear();
            TxtDescripcion.Clear();
            CkEstado.Checked = false;

            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnAgreagr.Enabled = false;
            BtnCancelar.Enabled = false;
        }

        private void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
