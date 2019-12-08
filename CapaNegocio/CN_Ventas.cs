using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Ventas
    {

        private CD_Ventas CDVenta = new CD_Ventas();
        public readonly StringBuilder stringBuilder = new StringBuilder();

        

        public List<CE_Ventas> Todos()
        {
            return CDVenta.GetAll();
        }

    }
}
