using RJAS_Market_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJAS_Market_App.Data
{
    public class InventarioDataService
    {
        private List<Producto> productosSimulados;

        public InventarioDataService()
        {
            // Inicializar con datos de prueba
            productosSimulados = new List<Producto>
        {
            new Producto { ID = 1, Nombre = "Laptop HP", Descripcion = "Laptop core i5", Cantidad = 15, Precio = 850.00m, Categoria = "Electrónica" },
            new Producto { ID = 2, Nombre = "Mouse Logitech", Descripcion = "Mouse inalámbrico", Cantidad = 50, Precio = 25.00m, Categoria = "Accesorios" },
            new Producto { ID = 3, Nombre = "Teclado Mecánico", Descripcion = "Teclado RGB", Cantidad = 30, Precio = 75.00m, Categoria = "Accesorios" },
            new Producto { ID = 4, Nombre = "Monitor Samsung", Descripcion = "Monitor 24 pulgadas", Cantidad = 20, Precio = 180.00m, Categoria = "Electrónica" },
            new Producto { ID = 5, Nombre = "Silla Ergonómica", Descripcion = "Silla de oficina", Cantidad = 10, Precio = 150.00m, Categoria = "Mobiliario" }
        };

        }

        // Método para buscar por ID
        public Producto BuscarPorID(int id)
        {
            return productosSimulados.FirstOrDefault(p => p.ID == id);
        }

        // Método para buscar por nombre (búsqueda parcial)
        public List<Producto> BuscarPorNombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                return new List<Producto>();

            return productosSimulados
                .Where(p => p.Nombre.ToLower().Contains(nombre.ToLower()))
                .ToList();
        }

        // Método para obtener todos los productos
        public List<Producto> ObtenerTodos()
        {
            return productosSimulados;
        }

        // TODO: Cuando tengas la BD, reemplaza estos métodos con:
        /*
        public Producto BuscarPorID(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Inventario WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                // ... implementar lógica SQL
            }
        }
        */



    }
}
