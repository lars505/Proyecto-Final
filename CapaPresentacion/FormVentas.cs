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


        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            TxtFecha.Text = Convert.ToString(DateTime.Today);
        }

        private void BrnAprod_Click(object sender, EventArgs e)
        {
            GredProductos nuevo = new GredProductos();

            nuevo.Show();
            //GredProductos.Select();
            
            GredP.Select();


           
        }

        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
