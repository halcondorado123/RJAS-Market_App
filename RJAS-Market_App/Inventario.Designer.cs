namespace RJAS_Market_App
{
    partial class Inventario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitulo = new Label();
            pictureBoxLogo = new PictureBox();
            panelBusqueda = new Panel();
            lblConsultaBodega = new Label();
            lblID = new Label();
            textBox1 = new TextBox();
            lblProducto = new Label();
            textBox2 = new TextBox();
            buscarBtn = new Button();
            limpiarBtn = new Button();
            panelDataGrid = new Panel();
            dataGridView1 = new DataGridView();
            panelBotones = new Panel();
            crearBtn = new Button();
            eliminarBtn = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelBusqueda.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(pictureBoxLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1400, 92);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(117, 23);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(446, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTIÓN DE INVENTARIO R-J-A-S";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.White;
            pictureBoxLogo.Location = new Point(23, 12);
            pictureBoxLogo.Margin = new Padding(4, 3, 4, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(70, 69);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelBusqueda
            // 
            panelBusqueda.BackColor = Color.White;
            panelBusqueda.BorderStyle = BorderStyle.FixedSingle;
            panelBusqueda.Controls.Add(lblConsultaBodega);
            panelBusqueda.Controls.Add(lblID);
            panelBusqueda.Controls.Add(textBox1);
            panelBusqueda.Controls.Add(lblProducto);
            panelBusqueda.Controls.Add(textBox2);
            panelBusqueda.Controls.Add(buscarBtn);
            panelBusqueda.Controls.Add(limpiarBtn);
            panelBusqueda.Location = new Point(23, 115);
            panelBusqueda.Margin = new Padding(4, 3, 4, 3);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(1353, 138);
            panelBusqueda.TabIndex = 1;
            // 
            // lblConsultaBodega
            // 
            lblConsultaBodega.AutoSize = true;
            lblConsultaBodega.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblConsultaBodega.ForeColor = Color.FromArgb(52, 73, 94);
            lblConsultaBodega.Location = new Point(23, 17);
            lblConsultaBodega.Margin = new Padding(4, 0, 4, 0);
            lblConsultaBodega.Name = "lblConsultaBodega";
            lblConsultaBodega.Size = new Size(163, 25);
            lblConsultaBodega.TabIndex = 0;
            lblConsultaBodega.Text = "Consulta Bodega";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.ForeColor = Color.FromArgb(52, 73, 94);
            lblID.Location = new Point(29, 63);
            lblID.Margin = new Padding(4, 0, 4, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(42, 19);
            lblID.TabIndex = 1;
            lblID.Text = "N° ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(29, 89);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 25);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 10F);
            lblProducto.ForeColor = Color.FromArgb(52, 73, 94);
            lblProducto.Location = new Point(292, 63);
            lblProducto.Margin = new Padding(4, 0, 4, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(141, 19);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Producto / Proveedor";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(292, 89);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(466, 25);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // buscarBtn
            // 
            buscarBtn.BackColor = Color.FromArgb(46, 204, 113);
            buscarBtn.Cursor = Cursors.Hand;
            buscarBtn.FlatAppearance.BorderSize = 0;
            buscarBtn.FlatStyle = FlatStyle.Flat;
            buscarBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buscarBtn.ForeColor = Color.White;
            buscarBtn.Location = new Point(793, 81);
            buscarBtn.Margin = new Padding(4, 3, 4, 3);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(140, 40);
            buscarBtn.TabIndex = 5;
            buscarBtn.Text = "🔍 Buscar";
            buscarBtn.UseVisualStyleBackColor = false;
            buscarBtn.Click += buscarBtn_Click_1;
            // 
            // limpiarBtn
            // 
            limpiarBtn.BackColor = Color.FromArgb(149, 165, 166);
            limpiarBtn.Cursor = Cursors.Hand;
            limpiarBtn.FlatAppearance.BorderSize = 0;
            limpiarBtn.FlatStyle = FlatStyle.Flat;
            limpiarBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            limpiarBtn.ForeColor = Color.White;
            limpiarBtn.Location = new Point(957, 81);
            limpiarBtn.Margin = new Padding(4, 3, 4, 3);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(140, 40);
            limpiarBtn.TabIndex = 6;
            limpiarBtn.Text = "🗑️ Limpiar";
            limpiarBtn.UseVisualStyleBackColor = false;
            limpiarBtn.Click += limpiarBtn_Click;
            // 
            // panelDataGrid
            // 
            panelDataGrid.BackColor = Color.White;
            panelDataGrid.BorderStyle = BorderStyle.FixedSingle;
            panelDataGrid.Controls.Add(dataGridView1);
            panelDataGrid.Location = new Point(23, 277);
            panelDataGrid.Margin = new Padding(4, 3, 4, 3);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(1353, 404);
            panelDataGrid.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1351, 402);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.White;
            panelBotones.Controls.Add(crearBtn);
            panelBotones.Controls.Add(eliminarBtn);
            panelBotones.Location = new Point(23, 692);
            panelBotones.Margin = new Padding(4, 3, 4, 3);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1353, 69);
            panelBotones.TabIndex = 3;
            // 
            // crearBtn
            // 
            crearBtn.BackColor = Color.FromArgb(52, 152, 219);
            crearBtn.Cursor = Cursors.Hand;
            crearBtn.FlatAppearance.BorderSize = 0;
            crearBtn.FlatStyle = FlatStyle.Flat;
            crearBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            crearBtn.ForeColor = Color.White;
            crearBtn.Location = new Point(501, 13);
            crearBtn.Margin = new Padding(4, 3, 4, 3);
            crearBtn.Name = "crearBtn";
            crearBtn.Size = new Size(163, 46);
            crearBtn.TabIndex = 0;
            crearBtn.Text = "➕ Crear";
            crearBtn.UseVisualStyleBackColor = false;
            crearBtn.Click += crearBtn_Click;
            // 
            // eliminarBtn
            // 
            eliminarBtn.BackColor = Color.FromArgb(231, 76, 60);
            eliminarBtn.Cursor = Cursors.Hand;
            eliminarBtn.FlatAppearance.BorderSize = 0;
            eliminarBtn.FlatStyle = FlatStyle.Flat;
            eliminarBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            eliminarBtn.ForeColor = Color.White;
            eliminarBtn.Location = new Point(687, 13);
            eliminarBtn.Margin = new Padding(4, 3, 4, 3);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(163, 46);
            eliminarBtn.TabIndex = 1;
            eliminarBtn.Text = "❌ Eliminar";
            eliminarBtn.UseVisualStyleBackColor = false;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1400, 785);
            Controls.Add(panelBotones);
            Controls.Add(panelDataGrid);
            Controls.Add(panelBusqueda);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Inventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RJAS Market - Inventario";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Label lblConsultaBodega;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button crearBtn;
        private System.Windows.Forms.Button eliminarBtn;
    }
}