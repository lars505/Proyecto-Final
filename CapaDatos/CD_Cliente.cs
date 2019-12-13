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
    public class CD_Cliente
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


        public List<CE_Cliente> GetAll()

        {
            List<CE_Cliente> Cliente = new List<CE_Cliente>();

            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "Select * from Clientes ORDER BY id_clientes ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        CE_Cliente Clientes = new CE_Cliente
                        {
                            id_clientes = Convert.ToInt32(dataReader["id_clientes"]),
                            nombrecliente = Convert.ToString(dataReader["nombrecliente"]),
                            apellidopaterno = Convert.ToString(dataReader["apellidopaterno"]),
                            apellidomaterno = Convert.ToString(dataReader["apellidomaterno"]),
                            direccion = Convert.ToString(dataReader["direccion"]),
                            telefono = Convert.ToInt32(dataReader["telefono"]),

                        };

                        Cliente.Add(Clientes);
                    }
                }
            }
            return Cliente;
        }

        public void Update(CE_Cliente Cliente)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                   " update clientes set nombrecliente = '@nombre',apellidopaterno = @apellidopaterno, apellidomaterno = @apellidomaterno, direccion = @direccion, telefono = @telefono where id_clientes = @id";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", Cliente.id_clientes);
                    cmd.Parameters.AddWithValue("@nombre", Cliente.nombrecliente);
                    cmd.Parameters.AddWithValue("@apellidopaterno", Cliente.apellidopaterno);
                    cmd.Parameters.AddWithValue("@apellidomaterno", Cliente.apellidomaterno);
                    cmd.Parameters.AddWithValue("@direccion", Cliente.direccion);
                    cmd.Parameters.AddWithValue("@telefono", Cliente.telefono);
                    //cmd.Parameters.AddWithValue("@foto", Vendedor.foto);


                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void Delete(int idcliente)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM clientes WHERE id_clientes = @id";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", idcliente);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public CE_Cliente GetByid(int idCliente)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM clientes WHERE id_clientes = @id";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    //
                    //Utilizamos el valor del parámetro idProducto para enviarlo al parámetro declarado en la consulta
                    //de selección SQL
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        CE_Cliente Cliente = new CE_Cliente
                        {
                            id_clientes = Convert.ToInt32(dataReader["id_Clientes"]),
                            nombrecliente = Convert.ToString(dataReader["nombre"]),
                            apellidopaterno = Convert.ToString(dataReader["apellidopaterno"]),
                            apellidomaterno = Convert.ToString(dataReader["apellidomaterno"]),
                            direccion = Convert.ToString(dataReader["direccion"]),
                            telefono = Convert.ToInt32(dataReader["telefono"]),
                        };

                        return Cliente;
                    }
                }
            }
            return null;
        }

        
    }
}

    
