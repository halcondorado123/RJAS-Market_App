using RJAS_Market_App.Data;
using RJAS_Market_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJAS_Market_App
{
    public partial class Inventario : Form
    {
        private readonly InventarioDataService _inventarioService;

        public Inventario()
        {
            InitializeComponent();
            _inventarioService = new InventarioDataService();
            ConfigurarDataGridView();
            CargarProductos();
        }

        // Configurar el DataGridView (si tienes uno en el panel gris)
        private void ConfigurarDataGridView()
        {
            // Asumiendo que tienes un DataGridView llamado dataGridView1
            // Si no lo tienes, agrégalo al formulario
            if (dataGridView1 != null)
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.ReadOnly = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscarBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Por favor ingrese un ID o nombre para buscar.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                List<Producto> resultados = new List<Producto>();

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (int.TryParse(textBox1.Text, out int id))
                    {
                        Producto producto = _inventarioService.BuscarPorID(id);
                        if (producto != null)
                            resultados.Add(producto);
                    }
                    else
                    {
                        MessageBox.Show("El ID debe ser un número válido.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    string nombreProveedor = textBox2.Text.Trim();

                    Producto producto = _inventarioService.BuscarPorNombre(nombreProveedor);
                    if (producto != null)
                        resultados.Add(producto);
                }

                if (resultados.Count > 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = resultados;

                    MessageBox.Show($"Se encontraron {resultados.Count} producto(s).",
                        "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("No se encontraron productos con los criterios especificados.",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar los campos de texto
                textBox1.Clear();
                textBox2.Clear();

                // Limpiar el DataGridView
                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = null;
                }

                // Opcional: poner el foco en el primer campo
                textBox1.Focus();

                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            Proveedor crearProductoForm = new Proveedor();
            crearProductoForm.Show();
        }

        private void CargarProductos()
        {
            try
            {
                List<Producto> productos = _inventarioService.ObtenerTodos();
                dataGridView1.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}");
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del producto seleccionado
            int idProveedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdProveedor"].Value);

            string nombreProveedor = dataGridView1.CurrentRow.Cells["NombreProveedor"].Value.ToString();

            // Mostrar mensaje de confirmación
            DialogResult result = MessageBox.Show(
                $"¿Seguro que deseas eliminar el proveedor '{nombreProveedor}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    _inventarioService.EliminarProveedor(idProveedor);
                    MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos(); // refrescar la tabla
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}