using Microsoft.Data.SqlClient;
using RJAS_Market_App.Models;

namespace TuAplicacion.Services
{
    // Servicio de datos para gestionar proveedores y categorías
    public class ProveedorDataService
    {
        private readonly static string connectionString =
               System.Configuration.ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;

        // Guarda un nuevo proveedor en la base de datos
        public bool GuardarProveedor(Producto producto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO [RJAS].[PROVEEDORES]
                                        ([NOMBRE_PROVEEDOR],
                                         [ID_CATEGORIA],
                                         [TELEFONO],
                                         [EMAIL],
                                         [DESCRIPCION_PRODUCTO],
                                         [CANTIDAD],
                                         [PRECIO],
                                         [IMPUESTO_IVA],
                                         [DESCUENTO],
                                         [ES_ACTIVO],
                                         [TOTAL])
                                    VALUES
                                        (@NombreProveedor,
                                         @IdCategoria,
                                         @Telefono,
                                         @Email,
                                         @DescripcionProducto,
                                         @Cantidad,
                                         @Precio,
                                         @ImpuestoIva,
                                         @Descuento,
                                         @EsActivo,
                                         @Total);
                                    SELECT CAST(SCOPE_IDENTITY() AS int);";

                    int idInsertado;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NombreProveedor", producto.NombreProveedor);
                        cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
                        cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(producto.Telefono) ? (object)DBNull.Value : producto.Telefono);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(producto.Email) ? (object)DBNull.Value : producto.Email);
                        cmd.Parameters.AddWithValue("@DescripcionProducto", string.IsNullOrWhiteSpace(producto.DescripcionProducto) ? (object)DBNull.Value : producto.DescripcionProducto);
                        cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                        cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                        cmd.Parameters.AddWithValue("@ImpuestoIva", producto.ImpuestoIva);
                        cmd.Parameters.AddWithValue("@Descuento", producto.Descuento);
                        cmd.Parameters.AddWithValue("@EsActivo", producto.EsActivo);
                        cmd.Parameters.AddWithValue("@Total", producto.Total);

                        idInsertado = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if (idInsertado > 0)
                    {
                        producto.IdProveedor = idInsertado;
                        return true;
                    }

                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al guardar el proveedor: {ex.Message}", ex);
            }
        }

        // Actualiza un proveedor existente en la base de datos
        public bool ActualizarProveedor(Producto producto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE [RJAS].[PROVEEDORES]
                             SET [NOMBRE_PROVEEDOR] = @NombreProveedor,
                                 [TELEFONO] = @Telefono,
                                 [EMAIL] = @Email,
                                 [DESCRIPCION_PRODUCTO] = @DescripcionProducto,
                                 [CANTIDAD] = @Cantidad,
                                 [PRECIO] = @Precio,
                                 [IMPUESTO_IVA] = @ImpuestoIva,
                                 [DESCUENTO] = @Descuento,
                                 [TOTAL] = @Total,
                                 [ES_ACTIVO] = @EsActivo,
                                 [ID_CATEGORIA] = @IdCategoria
                             WHERE [ID_PROVEEDOR] = @IdProveedor";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdProveedor", producto.IdProveedor);
                    cmd.Parameters.AddWithValue("@NombreProveedor", producto.NombreProveedor);
                    cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(producto.Telefono) ? (object)DBNull.Value : producto.Telefono);
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(producto.Email) ? (object)DBNull.Value : producto.Email);
                    cmd.Parameters.AddWithValue("@DescripcionProducto", string.IsNullOrWhiteSpace(producto.DescripcionProducto) ? (object)DBNull.Value : producto.DescripcionProducto);
                    cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@ImpuestoIva", producto.ImpuestoIva);
                    cmd.Parameters.AddWithValue("@Descuento", producto.Descuento);
                    cmd.Parameters.AddWithValue("@Total", producto.Total);
                    cmd.Parameters.AddWithValue("@EsActivo", producto.EsActivo);
                    cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);

                    conn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al actualizar el proveedor: {ex.Message}", ex);
            }
        }

        // Obtiene la lista de categorías desde la base de datos
        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();

            string query = "SELECT [ID_CATEGORIA], [NOMBRE_CATEGORIA] FROM [RJAS].[CATEGORIA_PRODUCTO]";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categorias.Add(new Categoria
                        {
                            IdCategoria = reader.GetInt32(0),
                            NombreCategoria = reader.GetString(1)
                        });
                    }
                }
            }

            return categorias;
        }
    }
}