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
        private InventarioDataService dataService;

        public Inventario(InventarioDataService dataService)
        {
            this.dataService = dataService;
        }

        public Inventario()
        {
            InitializeComponent();
            dataService = new InventarioDataService();
            ConfigurarDataGridView();
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreProductoLbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void BuscarEnBaseDeDatos(string id, string v)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {

        }

        private void buscarBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar que al menos un campo tenga datos
                if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(nombreProductoLbl.Text))
                {
                    MessageBox.Show("Por favor ingrese un ID o nombre de producto para buscar.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                List<Producto> resultados = new List<Producto>();

                // Buscar por ID si se ingresó
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (int.TryParse(textBox1.Text, out int id))
                    {
                        Producto producto = dataService.BuscarPorID(id);
                        if (producto != null)
                        {
                            resultados.Add(producto);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID debe ser un número válido.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // Buscar por nombre si se ingresó
                else if (!string.IsNullOrWhiteSpace(nombreProductoLbl.Text))
                {
                    resultados = dataService.BuscarPorNombre(nombreProductoLbl.Text);
                }

                // Mostrar resultados
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
                nombreProductoLbl.Clear();

                // Limpiar el DataGridView
                if (dataGridView1 != null)
                {
                    dataGridView1.DataSource = null;
                }

                // Opcional: poner el foco en el primer campo
                textBox1.Focus();

                // Opcional: mostrar mensaje de confirmación
                // MessageBox.Show("Campos limpiados correctamente.", "Información", 
                //     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
