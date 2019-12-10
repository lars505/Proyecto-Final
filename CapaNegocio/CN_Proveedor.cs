using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Proveedor
    {


        private CD_Proveedor CDproveedor = new CD_Proveedor();

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


        public void Registrar(CE_Proveedor proveedor)
        {
            if (ValidarProveedor(proveedor))
            {
                if (CDproveedor.GetByid(proveedor.id) == null)
                {
                    CDproveedor.Insert(proveedor);
                }
                else
                    CDproveedor.Update(proveedor);

            }
        }



        public List<CE_Proveedor> Todos()
        {
            return CDproveedor.GetAll();
        }

        public CE_Proveedor TraerPorId(int idProveedor)
        {
            stringBuilder.Clear();

            if (idProveedor == 0)
                stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return CDproveedor.GetByid(idProveedor);
            }
            return null;
        }

        public void Eliminar(int idProveedor)
        {
            stringBuilder.Clear();

            if (idProveedor == 0)
                stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                CDproveedor.Delete(idProveedor);
            }
        }

        private bool ValidarProveedor(CE_Proveedor proveedor)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(proveedor.nombre))
                stringBuilder.Append("El campo nombre es obligatorio");
            if (string.IsNullOrEmpty(proveedor.ciudad))
                stringBuilder.Append(Environment.NewLine + "El campo descripcion es obligatorio");

            return stringBuilder.Length == 0;
        }









    }
}
