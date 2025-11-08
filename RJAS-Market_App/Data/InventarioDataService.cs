using Microsoft.Data.SqlClient;
using RJAS_Market_App.Models;
using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RJAS_Market_App.Data
{
    // Servicio de datos para gestionar inventario
    public class InventarioDataService 
    {
        private readonly static string connectionString =
               System.Configuration.ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;

        // Busca un producto por su ID
        public Producto BuscarPorID(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT " +
                                       "P.ID_PROVEEDOR, " +
                                       "P.NOMBRE_PROVEEDOR, " +
                                       "P.ID_CATEGORIA, " +
                                       "C.NOMBRE_CATEGORIA, " +
                                       "P.TELEFONO, " +
                                       "P.EMAIL, " +
                                       "P.DESCRIPCION_PRODUCTO, " +
                                       "P.CANTIDAD, " +
                                       "P.PRECIO, " +
                                       "P.IMPUESTO_IVA, " +
                                       "P.DESCUENTO, " +
                                       "P.TOTAL, " +
                                       "P.ES_ACTIVO " +
                                   "FROM RJAS.PROVEEDORES AS P " +
                                   "INNER JOIN RJAS.CATEGORIA_PRODUCTO AS C " +
                                   "ON P.ID_CATEGORIA = C.ID_CATEGORIA " +
                                   "WHERE P.ID_PROVEEDOR = @ID_PROVEEDOR;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID_PROVEEDOR", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Producto
                    {
                        IdProveedor = (int)reader["ID_PROVEEDOR"],
                        NombreProveedor = reader["NOMBRE_PROVEEDOR"].ToString() ?? string.Empty,
                        IdCategoria = (int)reader["ID_CATEGORIA"],
                        Telefono = reader["TELEFONO"].ToString() ?? string.Empty,
                        Email = reader["EMAIL"].ToString() ?? string.Empty,
                        DescripcionProducto = reader["DESCRIPCION_PRODUCTO"].ToString(),
                        Cantidad = reader.IsDBNull(reader.GetOrdinal("CANTIDAD")) ? null : (int?)reader["CANTIDAD"],
                        Precio = reader.IsDBNull(reader.GetOrdinal("PRECIO")) ? null : Convert.ToDecimal(reader["PRECIO"]),
                        ImpuestoIva = reader.IsDBNull(reader.GetOrdinal("IMPUESTO_IVA")) ? 0 : Convert.ToDecimal(reader["IMPUESTO_IVA"]),
                        Descuento = reader.IsDBNull(reader.GetOrdinal("DESCUENTO")) ? null : Convert.ToDecimal(reader["DESCUENTO"]),
                        Total = reader.IsDBNull(reader.GetOrdinal("TOTAL")) ? 0 : Convert.ToDecimal(reader["TOTAL"]),
                        EsActivo = reader.IsDBNull(reader.GetOrdinal("ES_ACTIVO")) ? false : (bool)reader["ES_ACTIVO"]
                    };
                }
                return null;
            }
        }

        // Busca un producto por su nombre
        public Producto BuscarPorNombre(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT " +
                                       "P.ID_PROVEEDOR, " +
                                       "P.NOMBRE_PROVEEDOR, " +
                                       "P.ID_CATEGORIA, " +
                                       "C.NOMBRE_CATEGORIA, " +
                                       "P.TELEFONO, " +
                                       "P.EMAIL, " +
                                       "P.DESCRIPCION_PRODUCTO, " +
                                       "P.CANTIDAD, " +
                                       "P.PRECIO, " +
                                       "P.IMPUESTO_IVA, " +
                                       "P.DESCUENTO, " +
                                       "P.TOTAL, " +
                                       "P.ES_ACTIVO " +
                                   "FROM RJAS.PROVEEDORES AS P " +
                                   "INNER JOIN RJAS.CATEGORIA_PRODUCTO AS C " +
                                   "ON P.ID_CATEGORIA = C.ID_CATEGORIA " +
                                   "WHERE P.NOMBRE_PROVEEDOR = @NOMBRE_PROVEEDOR;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NOMBRE_PROVEEDOR", nombre);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Producto
                    {
                        IdProveedor = (int)reader["ID_PROVEEDOR"],
                        NombreProveedor = reader["NOMBRE_PROVEEDOR"].ToString() ?? string.Empty,
                        IdCategoria = (int)reader["ID_CATEGORIA"],
                        Telefono = reader["TELEFONO"].ToString() ?? string.Empty,
                        Email = reader["EMAIL"].ToString() ?? string.Empty,
                        DescripcionProducto = reader["DESCRIPCION_PRODUCTO"].ToString(),
                        Cantidad = reader.IsDBNull(reader.GetOrdinal("CANTIDAD")) ? null : (int?)reader["CANTIDAD"],
                        Precio = reader.IsDBNull(reader.GetOrdinal("PRECIO")) ? null : Convert.ToDecimal(reader["PRECIO"]),
                        ImpuestoIva = reader.IsDBNull(reader.GetOrdinal("IMPUESTO_IVA")) ? 0 : Convert.ToDecimal(reader["IMPUESTO_IVA"]),
                        Descuento = reader.IsDBNull(reader.GetOrdinal("DESCUENTO")) ? null : Convert.ToDecimal(reader["DESCUENTO"]),
                        Total = reader.IsDBNull(reader.GetOrdinal("TOTAL")) ? 0 : Convert.ToDecimal(reader["TOTAL"]),
                        EsActivo = reader.IsDBNull(reader.GetOrdinal("ES_ACTIVO")) ? false : (bool)reader["ES_ACTIVO"]
                    };
                }

                return null;
            }
        }

        // Obtiene todos los productos
        public List<Producto> ObtenerTodos()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID_PROVEEDOR, NOMBRE_PROVEEDOR, ID_CATEGORIA, TELEFONO, EMAIL, DESCRIPCION_PRODUCTO, CANTIDAD, PRECIO, IMPUESTO_IVA, DESCUENTO, TOTAL, ES_ACTIVO FROM RJAS.PROVEEDORES";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        IdProveedor = (int)reader["ID_PROVEEDOR"],
                        NombreProveedor = reader["NOMBRE_PROVEEDOR"].ToString(),
                        IdCategoria = (int)reader["ID_CATEGORIA"],
                        Telefono = reader["TELEFONO"].ToString(),
                        Email = reader["EMAIL"].ToString(),
                        DescripcionProducto = reader["DESCRIPCION_PRODUCTO"].ToString(),
                        Cantidad = Convert.ToInt32(reader["CANTIDAD"]),
                        Precio = Convert.ToDecimal(reader["PRECIO"]),
                        ImpuestoIva = Convert.ToDecimal(reader["IMPUESTO_IVA"]),
                        Descuento = Convert.ToDecimal(reader["DESCUENTO"]),
                        Total = Convert.ToDecimal(reader["TOTAL"]),
                        EsActivo = Convert.ToBoolean(reader["ES_ACTIVO"])
                    });
                }
            }

            return productos;
        }

        // Elimina un proveedor por su ID
        public void EliminarProveedor(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM RJAS.PROVEEDORES WHERE ID_PROVEEDOR = @ID_PROVEEDOR";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_PROVEEDOR", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}