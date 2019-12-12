using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class CE_Cliente
    {
        public int id_clientes { get; set; }
        public string nombrecliente { get; set; }
        public string apellidopaterno { get; set; }
        public string apellidomaterno { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
    }
}
