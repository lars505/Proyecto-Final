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
    public partial class FormCliente : Form
    {
        private readonly CN_Cliente CNCliente = new CN_Cliente();
        public FormCliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        private void TraerTodos()
        {
            List<CE_Cliente> Cliente = CNCliente.Todos();

            if (Cliente.Count > 0)

            {
                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.DataSource = Cliente;
                dgvDatos.Columns["ColumnId"].DataPropertyName = "id_clientes";
                dgvDatos.Columns["ColumnNombre"].DataPropertyName = "nombrecliente";
                dgvDatos.Columns["ColumnApellidoP"].DataPropertyName = "apellidopaterno";
                dgvDatos.Columns["ColumnApellidoM"].DataPropertyName = "apellidomaterno";
                dgvDatos.Columns["ColumnDireccion"].DataPropertyName = "direccion";
                dgvDatos.Columns["ColumnTelefono"].DataPropertyName = "telefono";

            }
            else
                MessageBox.Show("No existen Clientes Registrados");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
