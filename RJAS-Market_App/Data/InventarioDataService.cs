using Microsoft.Data.SqlClient;
using RJAS_Market_App.Models;
using System;
using System.Collections.Generic;

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
                string query = "SELECT * FROM Inventario WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Producto
                    {
                        ID = (int)reader["ID"],
                        Nombre = reader["Nombre"].ToString(),
                        Categoria = reader["Categoria"].ToString(),
                        Precio = (decimal)reader["Precio"]
                    };
                }

                return null;
            }
        }

        public static Producto BuscarPorNombre(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Inventario WHERE NOMBRE_PROVEEDOR = @NOMBRE";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NOMBRE", nombre);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Producto
                    {
                        ID = (int)reader["ID"],
                        Nombre = reader["Nombre"].ToString(),
                        Categoria = reader["Categoria"].ToString(),
                        Precio = (decimal)reader["Precio"]
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