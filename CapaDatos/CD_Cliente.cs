using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using CapaEntidades;
using System.Configuration;


namespace CapaDatos
{
    class CD_Cliente
    {
        public void Insert(CE_Cliente cliente)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "insert into clientes (nombrecliente,apellidopaterno,apellidomaterno,direccion,telefono) values (@nombre,@apellidopaterno,@apellidomaterno,@direccion,@telefono) ";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@nombre", cliente.nombrecliente);
                    cmd.Parameters.AddWithValue("@apellidopaterno", cliente.apellidopaterno);
                    cmd.Parameters.AddWithValue("@apellidomaterno", cliente.apellidomaterno);
                  
                    cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                    cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                    //cmd.Parameters.AddWithValue("@foto", vendedor.foto);

                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
