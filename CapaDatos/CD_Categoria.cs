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
    public class CD_Categoria
    {
        public void Insert(CE_Categoria categoria)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "insert into categorias (nombre, descripcion) values (@nombre,@descripcion)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@nombre", categoria.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", categoria.descripcion);

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public List<CE_Categoria> GetAll()
        {
            //Declaramos una lista del objeto EProducto la cual será la encargada de
            //regresar una colección de los elementos que se obtengan de la BD
            //
            //La lista substituye a DataTable utilizado en el proyecto de ejemplo
            List<CE_Categoria> categoria = new List<CE_Categoria>();

            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlQuery = "SELECT * FROM categorias ORDER BY id_categoria ASC";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //
                    //Preguntamos si el DataReader fue devuelto con datos
                    while (dataReader.Read())
                    {
                        //
                        //Instanciamos al objeto Eproducto para llenar sus propiedades
                        CE_Categoria categorias = new CE_Categoria
                        {
                            id = Convert.ToInt32(dataReader["id_categoria"]),
                            nombre = Convert.ToString(dataReader["nombre"]),
                            descripcion = Convert.ToString(dataReader["descripcion"]),

                        };
                        //
                        //Insertamos el objeto Producto dentro de la lista Productos
                        categoria.Add(categorias);
                    }
                }
            }
            return categoria;
        }



        public CE_Categoria GetByid(int idCategoria)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                const string sqlGetById = "SELECT * FROM categorias WHERE id_categoria = @id";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    //
                    //Utilizamos el valor del parámetro idProducto para enviarlo al parámetro declarado en la consulta
                    //de selección SQL
                    cmd.Parameters.AddWithValue("@id", idCategoria);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        CE_Categoria categoria = new CE_Categoria
                        {
                            id = Convert.ToInt32(dataReader["id_categoria"]),
                            nombre = Convert.ToString(dataReader["nombre"]),
                            descripcion = Convert.ToString(dataReader["descripcion"]),

                        };

                        return categoria;
                    }
                }
            }

            return null;
        }

        public void Update(CE_Categoria categoria)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE categorias SET nombre = @nombre, descripcion = @descripcion WHERE id_categoria = @id";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", categoria.id);
                    cmd.Parameters.AddWithValue("@nombre", categoria.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", categoria.descripcion);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Elimina un registro coincidente con el Id Proporcionado
        /// </summary>
        /// <param name="idproducto">Id del registro a Eliminar</param>
        /// <autor>José Luis García Bautista</autor>
        public void Delete(int idproducto)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM categorias WHERE id_categoria = @id";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", idproducto);

                    cmd.ExecuteNonQuery();
                }
            }
        }







    }



}
