using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria CDcategoria = new CD_Categoria();

        public readonly
            StringBuilder stringBuilder = new StringBuilder();

        public static bool sForprin1;
        public  bool FormOneInstancia(System.Windows.Forms.Form Xformular, string xnombre)
        {
            bool retorn = false;

            for (int f = 0; f < Xformular.MdiChildren.Length; f++)
            {   
                if (Xformular.MdiChildren[f].Text == xnombre)
                {
                    Xformular.MdiChildren[f].Activate();
                    Xformular.MdiChildren[f].WindowState = System.Windows.Forms.FormWindowState.Normal ;
                    retorn = true;
                }
                
            }
             
            return retorn;
        }



        public void Registrar(CE_Categoria categoria)
        {
            if (ValidarProducto(categoria))
            {
                if (CDcategoria.GetByid(categoria.id) == null)
                {
                    CDcategoria.Insert(categoria);
                }
                else
                    CDcategoria.Update(categoria);

            }
        }


        public List<CE_Categoria> Todos()
        {
            return CDcategoria.GetAll();
        }

        public CE_Categoria TraerPorId(int idCategoria)
        {
            stringBuilder.Clear();

            if (idCategoria == 0)
                stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return CDcategoria.GetByid(idCategoria);
            }
            return null;
        }

        public void Eliminar(int idCategoria)
        {
            stringBuilder.Clear();

            if (idCategoria == 0)
                stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                CDcategoria.Delete(idCategoria);
            }
        }

        private bool ValidarProducto(CE_Categoria categoria)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(categoria.nombre))
                stringBuilder.Append("El campo nombre es obligatorio");
            if (string.IsNullOrEmpty(categoria.descripcion))
                stringBuilder.Append(Environment.NewLine + "El campo descripcion es obligatorio");
            
            return stringBuilder.Length == 0;
        }














    }
}
