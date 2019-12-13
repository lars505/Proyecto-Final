using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
    
{
    public class CN_Cliente
    {
        private CD_Cliente CDcliente = new CD_Cliente();
        public readonly
             StringBuilder stringBuilder = new StringBuilder();

        public List<CE_Cliente> Todos()
        {
            return  CDcliente.GetAll();

        }


        public void Registrar(CE_Cliente Cliente)
        {
            if (ValidarCliente(Cliente))
            {
                if (CDcliente.GetByid(Cliente.id_clientes) == null)
                {
                    CDcliente.Insert(Cliente);
                }
                else
                    CDcliente.Update(Cliente);

            }
        }

        public CE_Cliente TraerPorId(int idCliente)
        {
            stringBuilder.Clear();

            if (idCliente == 0)
                stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                return CDcliente.GetByid(idCliente);
            }
            return null;
        }

        public void Eliminar(int idcliente)
        {
            stringBuilder.Clear();

            if (idcliente == 0)
                stringBuilder.Append("Por favor proporcione un valor de Id valido");

            if (stringBuilder.Length == 0)
            {
                CDcliente.Delete(idcliente);
            }
        }

        private bool ValidarCliente(CE_Cliente cliente)
        {
            stringBuilder.Clear();

            if (string.IsNullOrEmpty(cliente.nombrecliente))
                stringBuilder.Append("El campo nombre es obligatorio");
            if (string.IsNullOrEmpty(cliente.apellidopaterno))
                stringBuilder.Append(Environment.NewLine + "El campo Apellido Paterno es obligatorio");
            if (string.IsNullOrEmpty(cliente.apellidomaterno))
                stringBuilder.Append(Environment.NewLine + "El campo Apellido Materno es obligatorio");

            return stringBuilder.Length == 0;
        }


    }



}
