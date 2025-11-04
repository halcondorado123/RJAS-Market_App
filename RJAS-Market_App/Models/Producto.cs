namespace RJAS_Market_App.Models
{
    public class Producto
    {
        public int IdProveedor { get; set; }
        public required string NombreProveedor { get; set; }
        public string? DescripcionProducto { get; set; }
        public required int IdCategoria { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public required string Telefono { get; set; }
        public required string Email { get; set; }
        public required decimal ImpuestoIva { get; set; }
        public decimal? Descuento { get; set; }
        public required decimal Total { get; set; }
        public required bool EsActivo { get; set; }
        public IEnumerable<Categoria>? Categorias { get; set; }
    }
}
