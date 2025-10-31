namespace RJAS_Market_App
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label idProductoLbl;
            dataGridView1 = new DataGridView();
            crearBtn = new Button();
            eliminarBtn = new Button();
            noIdLbl = new Label();
            consultaBodegaLbl = new Label();
            buscarBtn = new Button();
            limpiarBtn = new Button();
            textBox1 = new TextBox();
            nombreProductoLbl = new TextBox();
            idProductoLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // idProductoLbl
            // 
            idProductoLbl.AutoSize = true;
            idProductoLbl.Location = new Point(250, 108);
            idProductoLbl.Name = "idProductoLbl";
            idProductoLbl.Size = new Size(56, 15);
            idProductoLbl.TabIndex = 4;
            idProductoLbl.Text = "Producto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(698, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // crearBtn
            // 
            crearBtn.Location = new Point(250, 391);
            crearBtn.Name = "crearBtn";
            crearBtn.Size = new Size(75, 23);
            crearBtn.TabIndex = 1;
            crearBtn.Text = "Crear";
            crearBtn.UseVisualStyleBackColor = true;
            // 
            // eliminarBtn
            // 
            eliminarBtn.Location = new Point(479, 391);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(75, 23);
            eliminarBtn.TabIndex = 2;
            eliminarBtn.Text = "Eliminar";
            eliminarBtn.UseVisualStyleBackColor = true;
            // 
            // noIdLbl
            // 
            noIdLbl.AutoSize = true;
            noIdLbl.Location = new Point(96, 108);
            noIdLbl.Name = "noIdLbl";
            noIdLbl.Size = new Size(35, 15);
            noIdLbl.TabIndex = 3;
            noIdLbl.Text = "N° ID";
            // 
            // consultaBodegaLbl
            // 
            consultaBodegaLbl.AutoSize = true;
            consultaBodegaLbl.Location = new Point(357, 67);
            consultaBodegaLbl.Name = "consultaBodegaLbl";
            consultaBodegaLbl.Size = new Size(97, 15);
            consultaBodegaLbl.TabIndex = 5;
            consultaBodegaLbl.Text = "Consulta Bodega";
            // 
            // buscarBtn
            // 
            buscarBtn.Location = new Point(510, 103);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(75, 23);
            buscarBtn.TabIndex = 6;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = true;
            buscarBtn.Click += buscarBtn_Click_1;
            // 
            // limpiarBtn
            // 
            limpiarBtn.Location = new Point(627, 104);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(75, 23);
            limpiarBtn.TabIndex = 7;
            limpiarBtn.Text = "Limpiar";
            limpiarBtn.UseVisualStyleBackColor = true;
            limpiarBtn.Click += limpiarBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(48, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // nombreProductoLbl
            // 
            nombreProductoLbl.Location = new Point(321, 104);
            nombreProductoLbl.Name = "nombreProductoLbl";
            nombreProductoLbl.Size = new Size(183, 23);
            nombreProductoLbl.TabIndex = 9;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nombreProductoLbl);
            Controls.Add(textBox1);
            Controls.Add(limpiarBtn);
            Controls.Add(buscarBtn);
            Controls.Add(consultaBodegaLbl);
            Controls.Add(idProductoLbl);
            Controls.Add(noIdLbl);
            Controls.Add(eliminarBtn);
            Controls.Add(crearBtn);
            Controls.Add(dataGridView1);
            Name = "Inventario";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button crearBtn;
        private Button eliminarBtn;
        private Label noIdLbl;
        private Label idProductoLbl;
        private Label consultaBodegaLbl;
        private Button buscarBtn;
        private Button limpiarBtn;
        private TextBox textBox1;
        private TextBox nombreProductoLbl;
    }
}