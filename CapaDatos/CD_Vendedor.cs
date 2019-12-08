using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using System.Configuration;
using System.Windows.Forms;


namespace CapaDatos
{
   public class CD_Vendedor
    {

        public void Insert(CE_Vendedor vendedor)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "insert into vendedores (nombre,apellidopaterno,apellidomaterno,email,direccion,telefono) values (@nombre,@apellidopaterno,@apellidomaterno,@email,@direccion,@telefono)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@nombre", vendedor.nombre);
                    cmd.Parameters.AddWithValue("@apellidopaterno", vendedor.apellidopaterno);
                    cmd.Parameters.AddWithValue("@apellidomaterno", vendedor.apellidomaterno);
                    cmd.Parameters.AddWithValue("@email", vendedor.email);
                    cmd.Parameters.AddWithValue("@direccion", vendedor.direccion);
                    cmd.Parameters.AddWithValue("@telefono", vendedor.telefono);
                    //cmd.Parameters.AddWithValue("@foto", vendedor.foto);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public List<CE_Vendedor> GetAll()
        {
            //Declaramos una lista del objeto EProducto la cual será la encargada de
            //regresar una colección de los elementos que se obtengan de la BD
            //
            //La lista substituye a DataTable utilizado en el proyecto de ejemplo
            List<CE_Vendedor> vendedor = new List<CE_Vendedor>();

            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlQuery = "SELECT * FROM vendedores ORDER BY id_vendedor ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //
                    //Preguntamos si el DataReader fue devuelto con datos
                    while (dataReader.Read())
                    {
                        //
                        //Instanciamos al objeto Eproducto para llenar sus propiedades
                        CE_Vendedor vendedores = new CE_Vendedor
                        {
                            id = Convert.ToInt32(dataReader["id_vendedor"]),
                            nombre = Convert.ToString(dataReader["nombre"]),
                            apellidopaterno = Convert.ToString(dataReader["apellidopaterno"]),
                            apellidomaterno = Convert.ToString(dataReader["apellidomaterno"]),
                            email = Convert.ToString(dataReader["email"]),
                            direccion = Convert.ToString(dataReader["direccion"]),
                            telefono = Convert.ToInt32(dataReader["telefono"]), 
                            

                        };
                        //
                        //Insertamos el objeto Producto dentro de la lista Productos
                        vendedor.Add(vendedores);
                    }
                }
            }
            return vendedor;
        }

        public CE_Vendedor GetByid(int idVendedor)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM vendedores WHERE id_vendedor = @id";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    //
                    //Utilizamos el valor del parámetro idProducto para enviarlo al parámetro declarado en la consulta
                    //de selección SQL
                    cmd.Parameters.AddWithValue("@id", idVendedor);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        CE_Vendedor vendedor = new CE_Vendedor
                        {
                            id = Convert.ToInt32(dataReader["id_vendedor"]),
                            nombre = Convert.ToString(dataReader["nombre"]),
                            apellidopaterno = Convert.ToString(dataReader["apellidopaterno"]),
                            apellidomaterno = Convert.ToString(dataReader["apellidomaterno"]),
                            email = Convert.ToString(dataReader["email"]),
                            direccion = Convert.ToString(dataReader["direccion"]),
                            telefono = Convert.ToInt32(dataReader["telefono"]),
                        };

                        return vendedor;
                    }
                }
            }

            return null;
        }

        public void Update(CE_Vendedor Vendedor)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE vendedores SET nombre = @nombre,apellidopaterno = @apellidopaterno,apellidomaterno=@apellidomaterno,email = @email,direccion=@direccion,telefono=telefono WHERE id_vendedor = @id";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", Vendedor.id);
                    cmd.Parameters.AddWithValue("@nombre", Vendedor.nombre);
                    cmd.Parameters.AddWithValue("@apellidopaterno", Vendedor.apellidopaterno);
                    cmd.Parameters.AddWithValue("@apellidomaterno", Vendedor.apellidomaterno);
                    cmd.Parameters.AddWithValue("@email", Vendedor.email);
                    cmd.Parameters.AddWithValue("@direccion", Vendedor.direccion);
                    cmd.Parameters.AddWithValue("@telefono", Vendedor.telefono);
                    //cmd.Parameters.AddWithValue("@foto", Vendedor.foto);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int idVendedor)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM vendedores WHERE id_vendedor = @id";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", idVendedor);

                    cmd.ExecuteNonQuery();
                }
            }
        }




    }
}
