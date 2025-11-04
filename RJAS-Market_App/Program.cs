using Microsoft.Data.SqlClient;
using RJAS_Market_App;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJAS_Market_App.Data
{

    public static class Program
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
}
public static class DatabaseConnection
{
    private static readonly string connectionString =
               ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;

    public static SqlConnection GetConnection()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        return connection;
    }

    // Ejemplo de prueba
    public static bool TestConnection()
    {
        try
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.State == ConnectionState.Open;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al conectar con la base de datos:\n{ex.Message}",
                            "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}

