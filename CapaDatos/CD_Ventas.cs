using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using CapaEntidades;

namespace CapaDatos
{
    public class CD_Ventas
    {

        public List<CE_Ventas> GetAll()
        {

            List<CE_Ventas> producto = new List<CE_Ventas>();

            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["cnnString"].ToString()))
            {
                cnx.Open();

                //const string sqlQuery = "select productos.id_productos,productos.nombreproducto, productos.Descripcion,productos.estado,productos.id_categoria,productos.id_proveedor, categorias.id_categoria,categorias.nombre,proveedores.id_proveedor from productos inner join categorias on productos.id_categoria = categorias.id_categoria Order by productos.id_productos";
                const string sqlQuery = "SELECT  productos.id_productos, productos.nombreproducto, bodega.stock, bodega.precioventa FROM productos INNER JOIN bodega ON productos.id_productos = bodega.id_productos";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cnx))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //
                    //Preguntamos si el DataReader fue devuelto con datos
                    while (dataReader.Read())
                    {
                        //
                        //Instanciamos al objeto Eproducto para llenar sus propiedades
                        CE_Ventas productos = new CE_Ventas
                        {
                            id = Convert.ToInt32(dataReader["id_productos"]),
                            nombreprod = Convert.ToString(dataReader["nombreproducto"]),
                            stock = Convert.ToInt32(dataReader["stock"]),
                            precio = Convert.ToInt32(dataReader["precioventa"])
                
                        };
                        //
                        //Insertamos el objeto Producto dentro de la lista Productos
                        producto.Add(productos);
                    }
                }
            }
            return producto;
        }





    }
}
