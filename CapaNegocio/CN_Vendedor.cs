using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Vendedor
    {

        private CD_Vendedor CDvendedor = new CD_Vendedor();

        public readonly
            StringBuilder stringBuilder = new StringBuilder();


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



        public void Registrar(CE_Vendedor vendedor)
        {
            if (ValidarVendedor(vendedor))
            {
                if (CDvendedor.GetByid(vendedor.id) == null)
                {
                    CDvendedor.Insert(vendedor);
                }
                else
                    CDvendedor.Update(vendedor);

            }
        }

        public List<CE_Vendedor> Todos()
        {
            return CDvendedor.GetAll();
        }

        public CE_Vendedor TraerPorId(int idVendedor)
        {
            stringBuilder.Clear();

            if (idVendedor == 0)
                stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return CDvendedor.GetByid(idVendedor);
            }
            return null;
        }

        public void Eliminar(int idVendedor)
        {
            stringBuilder.Clear();

            if (idVendedor == 0)
                stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                CDvendedor.Delete(idVendedor);
            }
        }

        private bool ValidarVendedor(CE_Vendedor vendedor)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(vendedor.nombre))
                stringBuilder.Append("El campo nombre es obligatorio");
            if (string.IsNullOrEmpty(vendedor.apellidopaterno))
                stringBuilder.Append(Environment.NewLine + "El campo Apellido Paterno es obligatorio");
            if (string.IsNullOrEmpty(vendedor.apellidomaterno))
                stringBuilder.Append(Environment.NewLine + "El campo Apellido Materno es obligatorio");

            return stringBuilder.Length == 0;
        }








    }
}
