using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CapaEntidades
{
    public class CE_Producto
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public PictureBox pbImagen { get; set; }
        public string estado  { get; set; }
        public int idcategoria { get; set; }
        public int idproveedor { get; set; }
        public string nombrecat { get; set; }
        public string nombreprov { get; set; }

    }
}
