namespace RJAS_Market_App
{
    partial class Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
            panelHeader = new Panel();
            lblTitulo = new Label();
            pictureBoxLogo = new PictureBox();
            panelDatosProveedor = new Panel();
            lblSeccionProveedor = new Label();
            nombreproveedorlbl = new Label();
            nombreProveedorTxt = new TextBox();
            categorialbl = new Label();
            categoriaCmb = new ComboBox();
            telefonolbl = new Label();
            telefonoTxt = new TextBox();
            emaillbl = new Label();
            emailTxt = new TextBox();
            panelDatosProducto = new Panel();
            lblSeccionProducto = new Label();
            descripcionproductolbl = new Label();
            comentarioTxt = new TextBox();
            cantidadlbl = new Label();
            cantidadTxt = new TextBox();
            preciolbl = new Label();
            precioTxt = new TextBox();
            Impuesto19lbl = new Label();
            impuestoTxt = new TextBox();
            descuentolbl = new Label();
            descuentoTxt = new TextBox();
            activoRdbt = new RadioButton();
            totallbl = new Label();
            totalTxt = new TextBox();
            panelDataGrid = new Panel();
            dataGridView1 = new DataGridView();
            panelBotones = new Panel();
            CargarBtn = new Button();
            actualizarBtn = new Button();
            limpiarBtn = new Button();
            finalizarBtn = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelDatosProveedor.SuspendLayout();
            panelDatosProducto.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(142, 68, 173);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(pictureBoxLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 5, 4, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1733, 123);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(133, 31);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(464, 46);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTIÓN DE PROVEEDORES";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.White;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(27, 15);
            pictureBoxLogo.Margin = new Padding(4, 5, 4, 5);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(80, 92);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelDatosProveedor
            // 
            panelDatosProveedor.BackColor = Color.White;
            panelDatosProveedor.BorderStyle = BorderStyle.FixedSingle;
            panelDatosProveedor.Controls.Add(lblSeccionProveedor);
            panelDatosProveedor.Controls.Add(nombreproveedorlbl);
            panelDatosProveedor.Controls.Add(nombreProveedorTxt);
            panelDatosProveedor.Controls.Add(categorialbl);
            panelDatosProveedor.Controls.Add(categoriaCmb);
            panelDatosProveedor.Controls.Add(telefonolbl);
            panelDatosProveedor.Controls.Add(telefonoTxt);
            panelDatosProveedor.Controls.Add(emaillbl);
            panelDatosProveedor.Controls.Add(emailTxt);
            panelDatosProveedor.Location = new Point(27, 154);
            panelDatosProveedor.Margin = new Padding(4, 5, 4, 5);
            panelDatosProveedor.Name = "panelDatosProveedor";
            panelDatosProveedor.Size = new Size(773, 368);
            panelDatosProveedor.TabIndex = 1;
            // 
            // lblSeccionProveedor
            // 
            lblSeccionProveedor.AutoSize = true;
            lblSeccionProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSeccionProveedor.ForeColor = Color.FromArgb(142, 68, 173);
            lblSeccionProveedor.Location = new Point(20, 23);
            lblSeccionProveedor.Margin = new Padding(4, 0, 4, 0);
            lblSeccionProveedor.Name = "lblSeccionProveedor";
            lblSeccionProveedor.Size = new Size(239, 28);
            lblSeccionProveedor.TabIndex = 0;
            lblSeccionProveedor.Text = "📋 Datos del Proveedor";
            // 
            // nombreproveedorlbl
            // 
            nombreproveedorlbl.AutoSize = true;
            nombreproveedorlbl.Font = new Font("Segoe UI", 9F);
            nombreproveedorlbl.ForeColor = Color.FromArgb(52, 73, 94);
            nombreproveedorlbl.Location = new Point(27, 85);
            nombreproveedorlbl.Margin = new Padding(4, 0, 4, 0);
            nombreproveedorlbl.Name = "nombreproveedorlbl";
            nombreproveedorlbl.Size = new Size(146, 20);
            nombreproveedorlbl.TabIndex = 1;
            nombreproveedorlbl.Text = "Nombre Proveedor *";
            // 
            // nombreProveedorTxt
            // 
            nombreProveedorTxt.Font = new Font("Segoe UI", 10F);
            nombreProveedorTxt.Location = new Point(27, 115);
            nombreProveedorTxt.Margin = new Padding(4, 5, 4, 5);
            nombreProveedorTxt.Name = "nombreProveedorTxt";
            nombreProveedorTxt.Size = new Size(719, 30);
            nombreProveedorTxt.TabIndex = 2;
            nombreProveedorTxt.TextChanged += textBox1_TextChanged;
            // 
            // categorialbl
            // 
            categorialbl.AutoSize = true;
            categorialbl.Font = new Font("Segoe UI", 9F);
            categorialbl.ForeColor = Color.FromArgb(52, 73, 94);
            categorialbl.Location = new Point(27, 169);
            categorialbl.Margin = new Padding(4, 0, 4, 0);
            categorialbl.Name = "categorialbl";
            categorialbl.Size = new Size(84, 20);
            categorialbl.TabIndex = 3;
            categorialbl.Text = "Categoría *";
            categorialbl.Click += categorialbl_Click;
            // 
            // categoriaCmb
            // 
            categoriaCmb.Font = new Font("Segoe UI", 10F);
            categoriaCmb.FormattingEnabled = true;
            categoriaCmb.Location = new Point(27, 200);
            categoriaCmb.Margin = new Padding(4, 5, 4, 5);
            categoriaCmb.Name = "categoriaCmb";
            categoriaCmb.Size = new Size(719, 31);
            categoriaCmb.TabIndex = 4;
            // 
            // telefonolbl
            // 
            telefonolbl.AutoSize = true;
            telefonolbl.Font = new Font("Segoe UI", 9F);
            telefonolbl.ForeColor = Color.FromArgb(52, 73, 94);
            telefonolbl.Location = new Point(27, 254);
            telefonolbl.Margin = new Padding(4, 0, 4, 0);
            telefonolbl.Name = "telefonolbl";
            telefonolbl.Size = new Size(67, 20);
            telefonolbl.TabIndex = 5;
            telefonolbl.Text = "Teléfono";
            // 
            // telefonoTxt
            // 
            telefonoTxt.Font = new Font("Segoe UI", 10F);
            telefonoTxt.Location = new Point(27, 285);
            telefonoTxt.Margin = new Padding(4, 5, 4, 5);
            telefonoTxt.Name = "telefonoTxt";
            telefonoTxt.Size = new Size(345, 30);
            telefonoTxt.TabIndex = 6;
            telefonoTxt.TextChanged += telefonoTxt_TextChanged;
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Font = new Font("Segoe UI", 9F);
            emaillbl.ForeColor = Color.FromArgb(52, 73, 94);
            emaillbl.Location = new Point(400, 254);
            emaillbl.Margin = new Padding(4, 0, 4, 0);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(46, 20);
            emaillbl.TabIndex = 7;
            emaillbl.Text = "Email";
            // 
            // emailTxt
            // 
            emailTxt.Font = new Font("Segoe UI", 10F);
            emailTxt.Location = new Point(400, 285);
            emailTxt.Margin = new Padding(4, 5, 4, 5);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(345, 30);
            emailTxt.TabIndex = 8;
            // 
            // panelDatosProducto
            // 
            panelDatosProducto.BackColor = Color.White;
            panelDatosProducto.BorderStyle = BorderStyle.FixedSingle;
            panelDatosProducto.Controls.Add(lblSeccionProducto);
            panelDatosProducto.Controls.Add(descripcionproductolbl);
            panelDatosProducto.Controls.Add(comentarioTxt);
            panelDatosProducto.Controls.Add(cantidadlbl);
            panelDatosProducto.Controls.Add(cantidadTxt);
            panelDatosProducto.Controls.Add(preciolbl);
            panelDatosProducto.Controls.Add(precioTxt);
            panelDatosProducto.Controls.Add(Impuesto19lbl);
            panelDatosProducto.Controls.Add(impuestoTxt);
            panelDatosProducto.Controls.Add(descuentolbl);
            panelDatosProducto.Controls.Add(descuentoTxt);
            panelDatosProducto.Controls.Add(activoRdbt);
            panelDatosProducto.Controls.Add(totallbl);
            panelDatosProducto.Controls.Add(totalTxt);
            panelDatosProducto.Location = new Point(827, 154);
            panelDatosProducto.Margin = new Padding(4, 5, 4, 5);
            panelDatosProducto.Name = "panelDatosProducto";
            panelDatosProducto.Size = new Size(879, 368);
            panelDatosProducto.TabIndex = 2;
            // 
            // lblSeccionProducto
            // 
            lblSeccionProducto.AutoSize = true;
            lblSeccionProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSeccionProducto.ForeColor = Color.FromArgb(142, 68, 173);
            lblSeccionProducto.Location = new Point(20, 23);
            lblSeccionProducto.Margin = new Padding(4, 0, 4, 0);
            lblSeccionProducto.Name = "lblSeccionProducto";
            lblSeccionProducto.Size = new Size(228, 28);
            lblSeccionProducto.TabIndex = 0;
            lblSeccionProducto.Text = "📦 Datos del Producto";
            // 
            // descripcionproductolbl
            // 
            descripcionproductolbl.AutoSize = true;
            descripcionproductolbl.Font = new Font("Segoe UI", 9F);
            descripcionproductolbl.ForeColor = Color.FromArgb(52, 73, 94);
            descripcionproductolbl.Location = new Point(27, 85);
            descripcionproductolbl.Margin = new Padding(4, 0, 4, 0);
            descripcionproductolbl.Name = "descripcionproductolbl";
            descripcionproductolbl.Size = new Size(161, 20);
            descripcionproductolbl.TabIndex = 1;
            descripcionproductolbl.Text = "Descripción Producto *";
            descripcionproductolbl.Click += label1_Click_1;
            // 
            // comentarioTxt
            // 
            comentarioTxt.Font = new Font("Segoe UI", 10F);
            comentarioTxt.Location = new Point(27, 115);
            comentarioTxt.Margin = new Padding(4, 5, 4, 5);
            comentarioTxt.Name = "comentarioTxt";
            comentarioTxt.Size = new Size(825, 30);
            comentarioTxt.TabIndex = 2;
            // 
            // cantidadlbl
            // 
            cantidadlbl.AutoSize = true;
            cantidadlbl.Font = new Font("Segoe UI", 9F);
            cantidadlbl.ForeColor = Color.FromArgb(52, 73, 94);
            cantidadlbl.Location = new Point(27, 169);
            cantidadlbl.Margin = new Padding(4, 0, 4, 0);
            cantidadlbl.Name = "cantidadlbl";
            cantidadlbl.Size = new Size(79, 20);
            cantidadlbl.TabIndex = 3;
            cantidadlbl.Text = "Cantidad *";
            cantidadlbl.Click += label1_Click_2;
            // 
            // cantidadTxt
            // 
            cantidadTxt.Font = new Font("Segoe UI", 10F);
            cantidadTxt.Location = new Point(27, 200);
            cantidadTxt.Margin = new Padding(4, 5, 4, 5);
            cantidadTxt.Name = "cantidadTxt";
            cantidadTxt.Size = new Size(199, 30);
            cantidadTxt.TabIndex = 4;
            cantidadTxt.TextChanged += cantidadTxt_TextChanged;
            // 
            // preciolbl
            // 
            preciolbl.AutoSize = true;
            preciolbl.Font = new Font("Segoe UI", 9F);
            preciolbl.ForeColor = Color.FromArgb(52, 73, 94);
            preciolbl.Location = new Point(253, 169);
            preciolbl.Margin = new Padding(4, 0, 4, 0);
            preciolbl.Name = "preciolbl";
            preciolbl.Size = new Size(60, 20);
            preciolbl.TabIndex = 5;
            preciolbl.Text = "Precio *";
            // 
            // precioTxt
            // 
            precioTxt.Font = new Font("Segoe UI", 10F);
            precioTxt.Location = new Point(253, 200);
            precioTxt.Margin = new Padding(4, 5, 4, 5);
            precioTxt.Name = "precioTxt";
            precioTxt.Size = new Size(199, 30);
            precioTxt.TabIndex = 6;
            precioTxt.TextChanged += precioTxt_TextChanged;
            // 
            // Impuesto19lbl
            // 
            Impuesto19lbl.AutoSize = true;
            Impuesto19lbl.Font = new Font("Segoe UI", 9F);
            Impuesto19lbl.ForeColor = Color.FromArgb(52, 73, 94);
            Impuesto19lbl.Location = new Point(27, 254);
            Impuesto19lbl.Margin = new Padding(4, 0, 4, 0);
            Impuesto19lbl.Name = "Impuesto19lbl";
            Impuesto19lbl.Size = new Size(103, 20);
            Impuesto19lbl.TabIndex = 7;
            Impuesto19lbl.Text = "Impuesto 19%";
            // 
            // impuestoTxt
            // 
            impuestoTxt.BackColor = Color.FromArgb(241, 242, 246);
            impuestoTxt.Font = new Font("Segoe UI", 10F);
            impuestoTxt.Location = new Point(27, 285);
            impuestoTxt.Margin = new Padding(4, 5, 4, 5);
            impuestoTxt.Name = "impuestoTxt";
            impuestoTxt.ReadOnly = true;
            impuestoTxt.Size = new Size(199, 30);
            impuestoTxt.TabIndex = 8;
            impuestoTxt.TextChanged += textBox7_TextChanged;
            // 
            // descuentolbl
            // 
            descuentolbl.AutoSize = true;
            descuentolbl.Font = new Font("Segoe UI", 9F);
            descuentolbl.ForeColor = Color.FromArgb(52, 73, 94);
            descuentolbl.Location = new Point(253, 254);
            descuentolbl.Margin = new Padding(4, 0, 4, 0);
            descuentolbl.Name = "descuentolbl";
            descuentolbl.Size = new Size(79, 20);
            descuentolbl.TabIndex = 9;
            descuentolbl.Text = "Descuento";
            // 
            // descuentoTxt
            // 
            descuentoTxt.Font = new Font("Segoe UI", 10F);
            descuentoTxt.Location = new Point(253, 285);
            descuentoTxt.Margin = new Padding(4, 5, 4, 5);
            descuentoTxt.Name = "descuentoTxt";
            descuentoTxt.Size = new Size(199, 30);
            descuentoTxt.TabIndex = 10;
            // 
            // activoRdbt
            // 
            activoRdbt.AutoSize = true;
            activoRdbt.Font = new Font("Segoe UI", 9F);
            activoRdbt.ForeColor = Color.FromArgb(52, 73, 94);
            activoRdbt.Location = new Point(480, 205);
            activoRdbt.Margin = new Padding(4, 5, 4, 5);
            activoRdbt.Name = "activoRdbt";
            activoRdbt.Size = new Size(86, 24);
            activoRdbt.TabIndex = 11;
            activoRdbt.TabStop = true;
            activoRdbt.Text = "¿Activo?";
            activoRdbt.UseVisualStyleBackColor = true;
            // 
            // totallbl
            // 
            totallbl.AutoSize = true;
            totallbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            totallbl.ForeColor = Color.FromArgb(52, 73, 94);
            totallbl.Location = new Point(480, 254);
            totallbl.Margin = new Padding(4, 0, 4, 0);
            totallbl.Name = "totallbl";
            totallbl.Size = new Size(49, 23);
            totallbl.TabIndex = 12;
            totallbl.Text = "Total";
            // 
            // totalTxt
            // 
            totalTxt.BackColor = Color.FromArgb(241, 242, 246);
            totalTxt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totalTxt.ForeColor = Color.FromArgb(142, 68, 173);
            totalTxt.Location = new Point(480, 285);
            totalTxt.Margin = new Padding(4, 5, 4, 5);
            totalTxt.Name = "totalTxt";
            totalTxt.ReadOnly = true;
            totalTxt.Size = new Size(239, 32);
            totalTxt.TabIndex = 13;
            totalTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // panelDataGrid
            // 
            panelDataGrid.BackColor = Color.White;
            panelDataGrid.BorderStyle = BorderStyle.FixedSingle;
            panelDataGrid.Controls.Add(dataGridView1);
            panelDataGrid.Location = new Point(27, 554);
            panelDataGrid.Margin = new Padding(4, 5, 4, 5);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(1679, 430);
            panelDataGrid.TabIndex = 3;
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
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1677, 428);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.White;
            panelBotones.Controls.Add(CargarBtn);
            panelBotones.Controls.Add(actualizarBtn);
            panelBotones.Controls.Add(limpiarBtn);
            panelBotones.Controls.Add(finalizarBtn);
            panelBotones.Location = new Point(27, 1008);
            panelBotones.Margin = new Padding(4, 5, 4, 5);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1680, 92);
            panelBotones.TabIndex = 4;
            // 
            // CargarBtn
            // 
            CargarBtn.BackColor = Color.FromArgb(46, 204, 113);
            CargarBtn.Cursor = Cursors.Hand;
            CargarBtn.FlatAppearance.BorderSize = 0;
            CargarBtn.FlatStyle = FlatStyle.Flat;
            CargarBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CargarBtn.ForeColor = Color.White;
            CargarBtn.Location = new Point(507, 15);
            CargarBtn.Margin = new Padding(4, 5, 4, 5);
            CargarBtn.Name = "CargarBtn";
            CargarBtn.Size = new Size(187, 62);
            CargarBtn.TabIndex = 0;
            CargarBtn.Text = "💾 Cargar";
            CargarBtn.UseVisualStyleBackColor = false;
            CargarBtn.Click += CargarBtn_Click;
            // 
            // actualizarBtn
            // 
            actualizarBtn.BackColor = Color.FromArgb(52, 152, 219);
            actualizarBtn.Cursor = Cursors.Hand;
            actualizarBtn.FlatAppearance.BorderSize = 0;
            actualizarBtn.FlatStyle = FlatStyle.Flat;
            actualizarBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            actualizarBtn.ForeColor = Color.White;
            actualizarBtn.Location = new Point(720, 15);
            actualizarBtn.Margin = new Padding(4, 5, 4, 5);
            actualizarBtn.Name = "actualizarBtn";
            actualizarBtn.Size = new Size(187, 62);
            actualizarBtn.TabIndex = 1;
            actualizarBtn.Text = "🔄 Actualizar";
            actualizarBtn.UseVisualStyleBackColor = false;
            actualizarBtn.Click += button1_Click;
            // 
            // limpiarBtn
            // 
            limpiarBtn.BackColor = Color.FromArgb(149, 165, 166);
            limpiarBtn.Cursor = Cursors.Hand;
            limpiarBtn.FlatAppearance.BorderSize = 0;
            limpiarBtn.FlatStyle = FlatStyle.Flat;
            limpiarBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            limpiarBtn.ForeColor = Color.White;
            limpiarBtn.Location = new Point(933, 15);
            limpiarBtn.Margin = new Padding(4, 5, 4, 5);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(187, 62);
            limpiarBtn.TabIndex = 2;
            limpiarBtn.Text = "🗑️ Limpiar";
            limpiarBtn.UseVisualStyleBackColor = false;
            // 
            // finalizarBtn
            // 
            finalizarBtn.BackColor = Color.FromArgb(142, 68, 173);
            finalizarBtn.Cursor = Cursors.Hand;
            finalizarBtn.FlatAppearance.BorderSize = 0;
            finalizarBtn.FlatStyle = FlatStyle.Flat;
            finalizarBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            finalizarBtn.ForeColor = Color.White;
            finalizarBtn.Location = new Point(1413, 15);
            finalizarBtn.Margin = new Padding(4, 5, 4, 5);
            finalizarBtn.Name = "finalizarBtn";
            finalizarBtn.Size = new Size(187, 62);
            finalizarBtn.TabIndex = 3;
            finalizarBtn.Text = "✅ Finalizar";
            finalizarBtn.UseVisualStyleBackColor = false;
            finalizarBtn.Click += finalizarBtn_Click;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1733, 1055);
            Controls.Add(panelBotones);
            Controls.Add(panelDataGrid);
            Controls.Add(panelDatosProducto);
            Controls.Add(panelDatosProveedor);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Proveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RJAS Market - Proveedores";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelDatosProveedor.ResumeLayout(false);
            panelDatosProveedor.PerformLayout();
            panelDatosProducto.ResumeLayout(false);
            panelDatosProducto.PerformLayout();
            panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelDatosProveedor;
        private System.Windows.Forms.Label lblSeccionProveedor;
        private System.Windows.Forms.Label nombreproveedorlbl;
        private System.Windows.Forms.TextBox nombreProveedorTxt;
        private System.Windows.Forms.Label categorialbl;
        private System.Windows.Forms.ComboBox categoriaCmb;
        private System.Windows.Forms.Label telefonolbl;
        private System.Windows.Forms.TextBox telefonoTxt;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Panel panelDatosProducto;
        private System.Windows.Forms.Label lblSeccionProducto;
        private System.Windows.Forms.Label descripcionproductolbl;
        private System.Windows.Forms.TextBox comentarioTxt;
        private System.Windows.Forms.Label cantidadlbl;
        private System.Windows.Forms.TextBox cantidadTxt;
        private System.Windows.Forms.Label preciolbl;
        private System.Windows.Forms.TextBox precioTxt;
        private System.Windows.Forms.Label Impuesto19lbl;
        private System.Windows.Forms.TextBox impuestoTxt;
        private System.Windows.Forms.Label descuentolbl;
        private System.Windows.Forms.TextBox descuentoTxt;
        private System.Windows.Forms.RadioButton activoRdbt;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button CargarBtn;
        private System.Windows.Forms.Button actualizarBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Button finalizarBtn;
    }
}