using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using System.Configuration;

namespace CapaDatos
{
    public class CD_Proveedor
    {

        public void Insert(CE_Proveedor proveedor)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "insert into Proveedores (nombre,email,telefono,direccion,ciudad) values (@nombre,@email,@telefono,@direccion,@ciudad)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@nombre", proveedor.nombre);
                    cmd.Parameters.AddWithValue("@email", proveedor.email);
                    cmd.Parameters.AddWithValue("@telefono", proveedor.telefono);
                    cmd.Parameters.AddWithValue("@direccion", proveedor.direccion);
                    cmd.Parameters.AddWithValue("@ciudad", proveedor.ciudad);

                    cmd.ExecuteNonQuery();
                }
            }


        }

        public List<CE_Proveedor> GetAll()
        {
            
            List<CE_Proveedor> proveedor = new List<CE_Proveedor>();

            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlQuery = "SELECT * FROM proveedores ORDER BY id_proveedor ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //
                    //Preguntamos si el DataReader fue devuelto con datos
                    while (dataReader.Read())
                    {
                        //
                        //Instanciamos al objeto Eproducto para llenar sus propiedades
                        CE_Proveedor proveedores = new CE_Proveedor
                        {
                            id = Convert.ToInt32(dataReader["id_proveedor"]),
                            nombre = Convert.ToString(dataReader["nombre"]),
                            email = Convert.ToString(dataReader["email"]),
                            telefono = Convert.ToInt32(dataReader["telefono"]),
                            direccion = Convert.ToString(dataReader["direccion"]),
                            ciudad = Convert.ToString(dataReader["ciudad"]),

                        };
                        //
                        //Insertamos el objeto Producto dentro de la lista Productos
                        proveedor.Add(proveedores);
                    }
                }
            }
            return proveedor;
        }

        public CE_Proveedor GetByid(int idProveedor)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM proveedores WHERE id_proveedor = @id";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    //
                    cmd.Parameters.AddWithValue("@id", idProveedor);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        CE_Proveedor proveedor = new CE_Proveedor
                        {
                            id = Convert.ToInt32(dataReader["id_proveedor"]),
                            nombre = Convert.ToString(dataReader["nombre"]),
                            email = Convert.ToString(dataReader["email"]),
                            telefono = Convert.ToInt32(dataReader["telefono"]),
                            direccion = Convert.ToString(dataReader["direccion"]),
                            ciudad = Convert.ToString(dataReader["ciudad"]),

                        };

                        return proveedor;
                    }
                }
            }

            return null;
        }

        public void Update(CE_Proveedor Proveedor)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE proveedores SET nombre = @nombre,email = @email, telefono = @telefono,direccion = @direccion, ciudad = @ciudad WHERE id_proveedor = @id";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", Proveedor.id);
                    cmd.Parameters.AddWithValue("@nombre", Proveedor.nombre);
                    cmd.Parameters.AddWithValue("@email", Proveedor.email);
                    cmd.Parameters.AddWithValue("@telefono", Proveedor.telefono);
                    cmd.Parameters.AddWithValue("@direccion", Proveedor.direccion);
                    cmd.Parameters.AddWithValue("@ciudad", Proveedor.ciudad);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int idProveedor)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM proveedores WHERE id_proveedor = @id";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", idProveedor);

                    cmd.ExecuteNonQuery();
                }
            }
        }











    }
}
