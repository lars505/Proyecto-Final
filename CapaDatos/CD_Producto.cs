using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using CapaEntidades;
using System.Windows.Forms;
using System.Configuration;
using System.IO;


namespace CapaDatos
{
    public class CD_Producto
    {
        DataRow dr;

        public void Insert(CE_Producto producto)
        {
            
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "Insert into productos (nombreproducto,Descripcion,estado,id_categoria,id_proveedor) VALUES (@nombre,@descripcion,@estado,@idcategoria,@idproveedor)";
                
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                    //cmd.Parameters.Add("@imagen", SqlDbType.Image);

                    //MemoryStream ms = new MemoryStream();
                    //producto.pbImagen.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                    //cmd.Parameters["@imagen"].Value = ms.GetBuffer();

                
                    cmd.Parameters.AddWithValue("@estado", producto.estado);
                    cmd.Parameters.AddWithValue("@idcategoria", producto.idcategoria);
                    cmd.Parameters.AddWithValue("@idproveedor", producto.idproveedor);

                    cmd.ExecuteNonQuery();
                }
                //const string sqlQuery2 = "Insert into productoos_proveedores(id_proveedores) values (@idproveedor)";
                //using (SqlCommand cmd = new SqlCommand(sqlQuery2, cnx))
                //{

                //    cmd.Parameters.AddWithValue("@idproveedor", producto.idproveedor);

                //    cmd.ExecuteNonQuery();
                //}

            }


        }


        public List<CE_Producto> GetAll()
        {

            List<CE_Producto> producto = new List<CE_Producto>();

            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                //const string sqlQuery = "select productos.id_productos,productos.nombreproducto, productos.Descripcion,productos.estado,productos.id_categoria,productos.id_proveedor, categorias.id_categoria,categorias.nombre,proveedores.id_proveedor from productos inner join categorias on productos.id_categoria = categorias.id_categoria Order by productos.id_productos";
                const string sqlQuery = "SELECT productos.id_productos, productos.nombreproducto, productos.Descripcion, productos.estado, productos.id_categoria, productos.Id_proveedor, categorias.nombre as nombrecat, proveedores.nombre as nombreprov FROM categorias INNER JOIN productos ON categorias.id_categoria = productos.id_categoria INNER JOIN proveedores ON productos.Id_proveedor = proveedores.id_proveedor where productos.estado = 'Disponible'";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //
                    //Preguntamos si el DataReader fue devuelto con datos
                    while (dataReader.Read())
                    {
                        //
                        //Instanciamos al objeto Eproducto para llenar sus propiedades
                        CE_Producto productos = new CE_Producto
                        {
                            id = Convert.ToInt32(dataReader["id_productos"]),
                            nombre = Convert.ToString(dataReader["nombreproducto"]),
                            descripcion = Convert.ToString(dataReader["Descripcion"]),

                        //    byte[] datos = new byte[0];
                        //datos = (byte[])dr["img"],
                        //System.IO.MemoryStream ms = new System.IO.MemoryStream(datos),
                        //pbFoto.Image = System.Drawing.Bitmap.FromStream(ms),

                        estado = Convert.ToString(dataReader["Estado"]),/*Convert.ToInt32(dataReader["estado"]),*/
                            idcategoria = Convert.ToInt32(dataReader["id_categoria"]),
                            nombrecat = Convert.ToString(dataReader["nombrecat"]),
                            idproveedor = Convert.ToInt32(dataReader["id_proveedor"]),
                            nombreprov = Convert.ToString(dataReader["nombreprov"])

                            

                        };
                        //
                        //Insertamos el objeto Producto dentro de la lista Productos
                        producto.Add(productos);
                    }
                }
            }
            return producto;
        }


        public CE_Producto GetByid(int idProducto)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                //const string sqlGetById = "SELECT * FROM productos WHERE id_productos = @id";
                const string sqlGetById = "SELECT productos.id_productos, productos.nombreproducto, productos.Descripcion, productos.estado, productos.id_categoria, productos.Id_proveedor, categorias.nombre as nombrecat, proveedores.nombre as nombreprov FROM categorias INNER JOIN productos ON categorias.id_categoria = productos.id_categoria INNER JOIN proveedores ON productos.Id_proveedor = proveedores.id_proveedor where id_productos = @id";
                using (SqlCommand cmd = new SqlCommand(sqlGetById, cnx))
                {
                    //
                    cmd.Parameters.AddWithValue("@id", idProducto);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        CE_Producto producto = new CE_Producto
                        {
                            id = Convert.ToInt32(dataReader["id_productos"]),
                            nombre = Convert.ToString(dataReader["nombreproducto"]),
                            descripcion = Convert.ToString(dataReader["Descripcion"]),
                            estado = Convert.ToString(dataReader["Estado"])/*Convert.ToInt32(dataReader["estado"])*/,
                            idcategoria = Convert.ToInt32(dataReader["id_categoria"]),
                            nombrecat = Convert.ToString(dataReader["nombrecat"]),
                            idproveedor = Convert.ToInt32(dataReader["id_proveedor"]),
                            nombreprov = Convert.ToString(dataReader["nombreprov"])

                        };

                        return producto;
                    }
                }
            }

            return null;
        }


        public void Update(CE_Producto Producto)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery =
                    "UPDATE productos SET nombreproducto = @nombre,Descripcion = @descripcion, estado = @estado,id_categoria = @id_categoria,id_proveedor = @id_proveedor WHERE id_productos = @id";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", Producto.id);
                    cmd.Parameters.AddWithValue("@nombre", Producto.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", Producto.descripcion);
                    cmd.Parameters.AddWithValue("@estado", Producto.estado);
                    cmd.Parameters.AddWithValue("@id_categoria", Producto.idcategoria);
                    cmd.Parameters.AddWithValue("@id_proveedor", Producto.idproveedor);



                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int idProducto)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();
                const string sqlQuery = "DELETE FROM productos WHERE id_productos = @id";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", idProducto);

                    cmd.ExecuteNonQuery();
                }
            }
        }




    }
}
