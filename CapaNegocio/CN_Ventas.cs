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

        public static bool sForprin1;
        public bool FormOneInstancia(System.Windows.Forms.Form Xformular, string xnombre)
        {
            bool retorn = false;

            for (int f = 0; f < Xformular.MdiChildren.Length; f++)
            {
                if (Xformular.MdiChildren[f].Text == xnombre)
                {
                    Xformular.MdiChildren[f].Activate();
                    Xformular.MdiChildren[f].WindowState = System.Windows.Forms.FormWindowState.Normal;
                    retorn = true;
                }

            }

            return retorn;
        }

        public List<CE_Ventas> Todos()
        {
            return CDVenta.GetAll();
        }

    }
}
