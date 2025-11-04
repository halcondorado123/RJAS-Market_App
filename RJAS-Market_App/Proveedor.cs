using Microsoft.Data.SqlClient;
using RJAS_Market_App.Data;
using RJAS_Market_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuAplicacion.Services;

namespace RJAS_Market_App
{
    public partial class Proveedor : Form
    {

        private readonly ProveedorDataService _dataService;

        private List<Producto> _proveedoresSesion = new List<Producto>(); // ← Registros en sesión

        private int IdSeleccionado = 0;


        public Proveedor()
        {
            InitializeComponent();

            // 1️⃣ Crear primero el servicio
            _dataService = new ProveedorDataService();
            cantidadTxt.TextChanged += cantidadTxt_TextChanged;
            precioTxt.TextChanged += precioTxt_TextChanged;
            descuentoTxt.TextChanged += descuentoTxt_TextChanged;

            // 2️⃣ Ahora sí, puedes cargar las categorías
            CargarCategorias();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CargarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombreProveedorTxt.Text))
                {
                    MessageBox.Show("El nombre del proveedor es obligatorio.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nombreProveedorTxt.Focus();
                    return;
                }

                if (categoriaCmb.SelectedValue == null || (int)categoriaCmb.SelectedValue == 0)
                {
                    MessageBox.Show("Debe seleccionar una categoría.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    categoriaCmb.Focus();
                    return;
                }

                Producto producto = new Producto()
                {
                    NombreProveedor = nombreProveedorTxt.Text.Trim(),
                    IdCategoria = Convert.ToInt32(categoriaCmb.SelectedValue),
                    Telefono = telefonoTxt.Text.Trim(),
                    Email = emailTxt.Text.Trim(),
                    DescripcionProducto = comentarioTxt.Text.Trim(),
                    Cantidad = string.IsNullOrWhiteSpace(cantidadTxt.Text) ? 0 : Convert.ToInt32(cantidadTxt.Text),
                    Precio = string.IsNullOrWhiteSpace(precioTxt.Text) ? 0 : Convert.ToDecimal(precioTxt.Text),
                    ImpuestoIva = string.IsNullOrWhiteSpace(impuestoTxt.Text) ? 0 : Convert.ToDecimal(impuestoTxt.Text),
                    Descuento = string.IsNullOrWhiteSpace(descuentoTxt.Text) ? 0 : Convert.ToDecimal(descuentoTxt.Text),
                    EsActivo = activoRdbt.Checked,
                    Total = string.IsNullOrWhiteSpace(totalTxt.Text) ? 0 : Convert.ToDecimal(totalTxt.Text)
                };

                bool guardado = _dataService.GuardarProveedor(producto);

                if (guardado)
                {
                    // ✅ Agregamos a la lista en sesión
                    _proveedoresSesion.Add(producto);

                    // ✅ Refrescamos la grilla solo con los datos actuales
                    CargarProveedoresSesion();

                    MessageBox.Show($"Proveedor guardado exitosamente con ID: {producto.IdProveedor}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el proveedor.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, verifica que los campos numéricos tengan valores válidos.",
                    "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Excepción",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método auxiliar para limpiar el formulario
        private void LimpiarFormulario()
        {
            nombreProveedorTxt.Clear();
            categoriaCmb.SelectedIndex = -1;
            telefonoTxt.Clear();
            emailTxt.Clear();
            comentarioTxt.Clear();
            cantidadTxt.Clear();
            precioTxt.Clear();
            impuestoTxt.Clear();
            descuentoTxt.Clear();
            totalTxt.Clear();
            activoRdbt.Checked = false;
            nombreProveedorTxt.Focus();
        }

        private void CargarProveedoresSesion()
        {
            dataGridView1.DataSource = null; // Limpia la tabla
            dataGridView1.DataSource = _proveedoresSesion; // Muestra los nuevos registros
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cantidadTxt_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void precioTxt_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void descuentoTxt_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void CalcularTotales()
        {
            try
            {
                // Limpieza básica
                string cantidadText = cantidadTxt.Text.Trim().Replace(",", ".");
                string precioText = precioTxt.Text.Trim().Replace(",", ".");
                string descuentoText = descuentoTxt.Text.Trim().Replace(",", ".");

                if (!decimal.TryParse(cantidadText, out decimal cantidad))
                    cantidad = 0;

                if (!decimal.TryParse(precioText, out decimal precio))
                    precio = 0;

                if (!decimal.TryParse(descuentoText, out decimal descuento))
                    descuento = 0;

                // Calcular subtotal (cantidad * precio)
                decimal subtotal = cantidad * precio;

                // Calcular impuesto (19%)
                decimal impuesto = subtotal * 0.19m;
                impuestoTxt.Text = impuesto.ToString("0.00");

                // Calcular total (subtotal + impuesto - descuento)
                decimal total = subtotal + impuesto - descuento;
                totalTxt.Text = total.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el cálculo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void categorialbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        //private void Proveedor_Load(object sender, EventArgs e)
        //{
        //    CargarCategorias();
        //}



        private void CargarCategorias()
        {
            try
            {
                List<Categoria> categorias = _dataService.ObtenerCategorias();

                // Agregar una opción por defecto al inicio
                categorias.Insert(0, new Categoria
                {
                    IdCategoria = 0,
                    NombreCategoria = "Seleccione una opción"
                });

                categoriaCmb.DataSource = categorias;
                categoriaCmb.DisplayMember = "NombreCategoria";
                categoriaCmb.ValueMember = "IdCategoria";
                categoriaCmb.SelectedIndex = 0; // Mostrar la opción por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                // ✅ Asignar el ID seleccionado
                IdSeleccionado = Convert.ToInt32(fila.Cells["IdProveedor"].Value);

                // ✅ Llenar los TextBox con los valores seleccionados
                nombreProveedorTxt.Text = fila.Cells["NombreProveedor"].Value?.ToString();
                telefonoTxt.Text = fila.Cells["Telefono"].Value?.ToString();
                emailTxt.Text = fila.Cells["Email"].Value?.ToString();
                comentarioTxt.Text = fila.Cells["DescripcionProducto"].Value?.ToString();
                cantidadTxt.Text = fila.Cells["Cantidad"].Value?.ToString();
                precioTxt.Text = fila.Cells["Precio"].Value?.ToString();
                descuentoTxt.Text = fila.Cells["Descuento"].Value?.ToString();
                impuestoTxt.Text = fila.Cells["ImpuestoIva"].Value?.ToString();
                totalTxt.Text = fila.Cells["Total"].Value?.ToString();

                // Seleccionar categoría en el combo
                categoriaCmb.SelectedValue = fila.Cells["IdCategoria"].Value;
                activoRdbt.Checked = Convert.ToBoolean(fila.Cells["EsActivo"].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un registro para actualizar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(nombreProveedorTxt.Text))
                {
                    MessageBox.Show("El nombre del proveedor es obligatorio.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (categoriaCmb.SelectedValue == null || (int)categoriaCmb.SelectedValue == 0)
                {
                    MessageBox.Show("Debe seleccionar una categoría.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Producto producto = new Producto()
                {
                    IdProveedor = IdSeleccionado,
                    NombreProveedor = nombreProveedorTxt.Text.Trim(),
                    Telefono = telefonoTxt.Text.Trim(),
                    Email = emailTxt.Text.Trim(),
                    DescripcionProducto = comentarioTxt.Text.Trim(),
                    Cantidad = string.IsNullOrWhiteSpace(cantidadTxt.Text) ? 0 : Convert.ToInt32(cantidadTxt.Text),
                    Precio = string.IsNullOrWhiteSpace(precioTxt.Text) ? 0 : Convert.ToDecimal(precioTxt.Text),
                    Descuento = string.IsNullOrWhiteSpace(descuentoTxt.Text) ? 0 : Convert.ToDecimal(descuentoTxt.Text),
                    ImpuestoIva = string.IsNullOrWhiteSpace(impuestoTxt.Text) ? 0 : Convert.ToDecimal(impuestoTxt.Text),
                    Total = string.IsNullOrWhiteSpace(totalTxt.Text) ? 0 : Convert.ToDecimal(totalTxt.Text),
                    IdCategoria = Convert.ToInt32(categoriaCmb.SelectedValue),
                    EsActivo = activoRdbt.Checked
                };

                bool actualizado = _dataService.ActualizarProveedor(producto);

                if (actualizado)
                {
                    // ✅ BUSCAR el registro en la lista de sesión y ACTUALIZARLO
                    var proveedorEnSesion = _proveedoresSesion.FirstOrDefault(p => p.IdProveedor == IdSeleccionado);
                    if (proveedorEnSesion != null)
                    {
                        proveedorEnSesion.NombreProveedor = producto.NombreProveedor;
                        proveedorEnSesion.Telefono = producto.Telefono;
                        proveedorEnSesion.Email = producto.Email;
                        proveedorEnSesion.DescripcionProducto = producto.DescripcionProducto;
                        proveedorEnSesion.Cantidad = producto.Cantidad;
                        proveedorEnSesion.Precio = producto.Precio;
                        proveedorEnSesion.Descuento = producto.Descuento;
                        proveedorEnSesion.ImpuestoIva = producto.ImpuestoIva;
                        proveedorEnSesion.Total = producto.Total;
                        proveedorEnSesion.IdCategoria = producto.IdCategoria;
                        proveedorEnSesion.EsActivo = producto.EsActivo;
                    }

                    MessageBox.Show("Registro actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    IdSeleccionado = 0;
                    LimpiarFormulario();

                    // ✅ Refrescar la grid con los datos actualizados
                    CargarProveedoresSesion();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, verifica que los campos numéricos tengan valores válidos.",
                    "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void finalizarBtn_Click(object sender, EventArgs e)
        {
            // Cerrar el actual (opcional)
            this.Close();
        }


        //private void CargarCategorias()
        //{
        //    try
        //    {
        //        List<Categoria> categorias = _dataService.ObtenerCategorias();

        //        categoriaCmb.DataSource = categorias;
        //        categoriaCmb.DisplayMember = "NombreCategoria";
        //        categoriaCmb.ValueMember = "IdCategoria";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al cargar categorías: {ex.Message}");
        //    }
        //}
    }
}
