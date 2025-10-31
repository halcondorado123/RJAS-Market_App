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

        private void button1_Click(object sender, EventArgs e)
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
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
