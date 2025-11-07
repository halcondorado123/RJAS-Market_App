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
            panelHeader.Margin = new Padding(5, 4, 5, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1600, 123);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(134, 31);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(564, 46);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTIÓN DE INVENTARIO R-J-A-S";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.White;
            pictureBoxLogo.Image = Properties.Resources._73fb2ca0_3dc4_4c58_b97c_4ef7a4456137;
            pictureBoxLogo.Location = new Point(26, 16);
            pictureBoxLogo.Margin = new Padding(5, 4, 5, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(80, 92);
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
            panelBusqueda.Location = new Point(26, 153);
            panelBusqueda.Margin = new Padding(5, 4, 5, 4);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(1546, 183);
            panelBusqueda.TabIndex = 1;
            // 
            // lblConsultaBodega
            // 
            lblConsultaBodega.AutoSize = true;
            lblConsultaBodega.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblConsultaBodega.ForeColor = Color.FromArgb(52, 73, 94);
            lblConsultaBodega.Location = new Point(26, 23);
            lblConsultaBodega.Margin = new Padding(5, 0, 5, 0);
            lblConsultaBodega.Name = "lblConsultaBodega";
            lblConsultaBodega.Size = new Size(207, 32);
            lblConsultaBodega.TabIndex = 0;
            lblConsultaBodega.Text = "Consulta Bodega";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F);
            lblID.ForeColor = Color.FromArgb(52, 73, 94);
            lblID.Location = new Point(33, 84);
            lblID.Margin = new Padding(5, 0, 5, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(51, 23);
            lblID.TabIndex = 1;
            lblID.Text = "N° ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(33, 119);
            textBox1.Margin = new Padding(5, 4, 5, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 30);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 10F);
            lblProducto.ForeColor = Color.FromArgb(52, 73, 94);
            lblProducto.Location = new Point(334, 84);
            lblProducto.Margin = new Padding(5, 0, 5, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(175, 23);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Producto / Proveedor";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(334, 119);
            textBox2.Margin = new Padding(5, 4, 5, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(532, 30);
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
            buscarBtn.Location = new Point(906, 108);
            buscarBtn.Margin = new Padding(5, 4, 5, 4);
            buscarBtn.Name = "buscarBtn";
            buscarBtn.Size = new Size(160, 53);
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
            limpiarBtn.Location = new Point(1094, 108);
            limpiarBtn.Margin = new Padding(5, 4, 5, 4);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(160, 53);
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
            panelDataGrid.Location = new Point(26, 369);
            panelDataGrid.Margin = new Padding(5, 4, 5, 4);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(1546, 538);
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
            dataGridView1.Margin = new Padding(5, 4, 5, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1544, 536);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.White;
            panelBotones.Controls.Add(crearBtn);
            panelBotones.Controls.Add(eliminarBtn);
            panelBotones.Location = new Point(26, 923);
            panelBotones.Margin = new Padding(5, 4, 5, 4);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1546, 92);
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
            crearBtn.Location = new Point(573, 17);
            crearBtn.Margin = new Padding(5, 4, 5, 4);
            crearBtn.Name = "crearBtn";
            crearBtn.Size = new Size(186, 61);
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
            eliminarBtn.Location = new Point(785, 17);
            eliminarBtn.Margin = new Padding(5, 4, 5, 4);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(186, 61);
            eliminarBtn.TabIndex = 1;
            eliminarBtn.Text = "❌ Eliminar";
            eliminarBtn.UseVisualStyleBackColor = false;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1600, 1047);
            Controls.Add(panelBotones);
            Controls.Add(panelDataGrid);
            Controls.Add(panelBusqueda);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
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