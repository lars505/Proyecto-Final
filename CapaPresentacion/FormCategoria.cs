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
    public partial class FormCategoria : Form
    {
        private CE_Categoria _categoria;
        private readonly CN_Categoria CNCategoria = new CN_Categoria();



        public FormCategoria()
        {
            InitializeComponent();
        }

        private void Guardar()
        {
            try
            {
                if (_categoria == null)
                    _categoria = new CE_Categoria();

                _categoria.id = Convert.ToInt32(txtid.Text);
                _categoria.nombre = txtnombre.Text;
                _categoria.descripcion = txtdescripcion.Text;

                CNCategoria.Registrar(_categoria);

                if (CNCategoria.stringBuilder.Length != 0)
                {
                    MessageBox.Show(CNCategoria.stringBuilder.ToString(), "Para continuar:");
                }
                else
                {
                    MessageBox.Show("Categoria registrado/actualizado con éxito");

                    TraerTodos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        private void TraerTodos()
        {
            List<CE_Categoria> categoria = CNCategoria.Todos();

            if (categoria.Count > 0)
            {
                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.DataSource = categoria;
                dgvDatos.Columns["ColumnId"].DataPropertyName = "id";
                dgvDatos.Columns["ColumnNombre"].DataPropertyName = "nombre";
                dgvDatos.Columns["ColumnDescripcion"].DataPropertyName = "descripcion";
                
            }
            else
                MessageBox.Show("No existen las Categorias Registradas");

        }

        private void TraerPorId(int id)
        {
            try
            {
                _categoria = CNCategoria.TraerPorId(id);

                if (_categoria != null)
                {
                    txtid.Text = Convert.ToString(_categoria.id);
                    txtnombre.Text = _categoria.nombre;
                    txtdescripcion.Text = _categoria.descripcion;
                   
                }
                else
                    MessageBox.Show("La categoria solicitado no existe");
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
                CNCategoria.Eliminar(id);

                MessageBox.Show("Categoria eliminada satisfactoriamente");

                TraerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
            TraerTodos();
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(txtid.Text))
            {
                e.SuppressKeyPress = true;

                TraerPorId(Convert.ToInt32(txtid.Text));
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtid.Text))
            {
                TraerPorId(Convert.ToInt32(txtid.Text));
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtid.Text))
            {
                Eliminar(Convert.ToInt32(txtid.Text));
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
