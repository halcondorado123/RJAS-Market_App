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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numeroIdLbl = new Label();
            nombreProductoLbl = new Label();
            buscarBtn = new Button();
            button2 = new Button();
            eliminarBtn = new Button();
            limpiarBtn = new Button();
            bodegaLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(75, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(549, 218);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(42, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // numeroIdLbl
            // 
            numeroIdLbl.AutoSize = true;
            numeroIdLbl.Location = new Point(80, 127);
            numeroIdLbl.Name = "numeroIdLbl";
            numeroIdLbl.Size = new Size(35, 15);
            numeroIdLbl.TabIndex = 3;
            numeroIdLbl.Text = "N° ID";
            numeroIdLbl.Click += label1_Click;
            // 
            // nombreProductoLbl
            // 
            nombreProductoLbl.AutoSize = true;
            nombreProductoLbl.Location = new Point(191, 128);
            nombreProductoLbl.Name = "nombreProductoLbl";
            nombreProductoLbl.Size = new Size(56, 15);
            nombreProductoLbl.TabIndex = 4;
            nombreProductoLbl.Text = "Producto";
            nombreProductoLbl.Click += nombreProductoLbl_Click;
            // 
            // buscarBtn
            // 
            buscarBtn.Location = new Point(468, 125);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(75, 23);
            buscarBtn.TabIndex = 5;
            buscarBtn.Text = "Buscar";
            buscarBtn.UseVisualStyleBackColor = true;
            buscarBtn.Click += buscarBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(285, 424);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // eliminarBtn
            // 
            eliminarBtn.Location = new Point(375, 424);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(75, 23);
            eliminarBtn.TabIndex = 7;
            eliminarBtn.Text = "Eliminar";
            eliminarBtn.UseVisualStyleBackColor = true;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // limpiarBtn
            // 
            limpiarBtn.Location = new Point(549, 125);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(75, 23);
            limpiarBtn.TabIndex = 8;
            limpiarBtn.Text = "Limpiar";
            limpiarBtn.UseVisualStyleBackColor = true;
            limpiarBtn.Click += button1_Click;
            // 
            // bodegaLbl
            // 
            bodegaLbl.AutoSize = true;
            bodegaLbl.Location = new Point(285, 91);
            bodegaLbl.Name = "bodegaLbl";
            bodegaLbl.Size = new Size(97, 15);
            bodegaLbl.TabIndex = 9;
            bodegaLbl.Text = "Consulta Bodega";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 495);
            Controls.Add(bodegaLbl);
            Controls.Add(limpiarBtn);
            Controls.Add(eliminarBtn);
            Controls.Add(button2);
            Controls.Add(buscarBtn);
            Controls.Add(nombreProductoLbl);
            Controls.Add(numeroIdLbl);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Inventario";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label numeroIdLbl;
        private Label nombreProductoLbl;
        private Button buscarBtn;
        private Button button2;
        private Button eliminarBtn;
        private Button limpiarBtn;
        private Label bodegaLbl;
    }
}