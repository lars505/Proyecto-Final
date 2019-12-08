using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CapaEntidades
{
    public class CE_Vendedor
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidopaterno{ get; set; }
        public string apellidomaterno{ get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public PictureBox foto { get; set; }

    }
}
