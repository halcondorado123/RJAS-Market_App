using Microsoft.Data.SqlClient;
using RJAS_Market_App.Models;
using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RJAS_Market_App.Data
{
    public static class InventarioDataService  // Clase estática
    {
        // Eliminar productosSimulados si no lo usas
        // O hacerlo estático si lo necesitas
        // private static List<Producto> productosSimulados;

        private readonly static string connectionString =
               System.Configuration.ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;

        public static Producto BuscarPorID(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT " +
                                "P.ID_PROVEEDOR, " +
                                "P.NOMBRE_PROVEEDOR, " +
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
                        NombreCategoria = reader["NOMBRE_CATEGORIA"].ToString(),
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

        public static Producto BuscarPorNombre(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT " +
                                "P.ID_PROVEEDOR, " +
                                "P.NOMBRE_PROVEEDOR, " +
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
                        NombreCategoria = reader["NOMBRE_CATEGORIA"].ToString(),
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

        public static Producto BuscarPorNombre(object nombre)
        {
            throw new NotImplementedException();
        }
    }
}