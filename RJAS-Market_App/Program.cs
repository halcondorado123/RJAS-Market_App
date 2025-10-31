using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;

namespace RJAS_Market_App.Data
{

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inventario()); // Cambia "Inventario" por tu formulario principal
        }
    }
    //public static class DatabaseConnection
    //{
    //    private static readonly string connectionString =
    //               ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;

    //    public static SqlConnection GetConnection()
    //    {
    //        SqlConnection connection = new SqlConnection(connectionString);
    //        return connection;
    //    }

    //    // Ejemplo de prueba
    //    public static bool TestConnection()
    //    {
    //        try
    //        {
    //            using (var conn = GetConnection())
    //            {
    //                conn.Open();
    //                return conn.State == ConnectionState.Open;
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show($"Error al conectar con la base de datos:\n{ex.Message}",
    //                            "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //            return false;
    //        }
    //    }
    //}
}
