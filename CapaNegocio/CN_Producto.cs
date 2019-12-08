using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
   public class CN_Producto
    {

        private CD_Producto _productoDal = new CD_Producto();
        //
        //El uso de la clase StringBuilder nos ayudara a devolver los mensajes de las validaciones
        public readonly StringBuilder stringBuilder = new StringBuilder();

        //
        //Creamos nuestro método para Insertar un nuevo Producto, observe como este método tampoco valida los el contenido
        //de las propiedades, sino que manda a llamar a una Función que tiene como tarea única hacer esta validación
        //
        public void Registrar(CE_Producto producto)
        {
            if (ValidarProducto(producto))
            {
                if (_productoDal.GetByid(producto.id) == null)
                {
                    _productoDal.Insert(producto);
                }
                else
                    _productoDal.Update(producto);

            }
        }

        public List<CE_Producto> Todos()
        {
            return _productoDal.GetAll();
        }

        public CE_Producto TraerPorId(int idProduct)
        {
            stringBuilder.Clear();

            if (idProduct == 0)
                stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return _productoDal.GetByid(idProduct);
            }
            return null;
        }

        public void Eliminar(int idProduct)
        {
            stringBuilder.Clear();

            if (idProduct == 0)
                stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                _productoDal.Delete(idProduct);
            }
        }

        private bool ValidarProducto(CE_Producto producto)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(producto.descripcion))
                stringBuilder.Append("El campo Descripción es obligatorio");
            if (string.IsNullOrEmpty(producto.nombre))
                stringBuilder.Append(Environment.NewLine + "El campo Marca es obligatorio");
            
            return stringBuilder.Length == 0;
        }






    }
}
