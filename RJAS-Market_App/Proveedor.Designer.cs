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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelDatosProveedor = new System.Windows.Forms.Panel();
            this.lblSeccionProveedor = new System.Windows.Forms.Label();
            this.nombreproveedorlbl = new System.Windows.Forms.Label();
            this.nombreProveedorTxt = new System.Windows.Forms.TextBox();
            this.categorialbl = new System.Windows.Forms.Label();
            this.categoriaCmb = new System.Windows.Forms.ComboBox();
            this.telefonolbl = new System.Windows.Forms.Label();
            this.telefonoTxt = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.panelDatosProducto = new System.Windows.Forms.Panel();
            this.lblSeccionProducto = new System.Windows.Forms.Label();
            this.descripcionproductolbl = new System.Windows.Forms.Label();
            this.comentarioTxt = new System.Windows.Forms.TextBox();
            this.cantidadlbl = new System.Windows.Forms.Label();
            this.cantidadTxt = new System.Windows.Forms.TextBox();
            this.preciolbl = new System.Windows.Forms.Label();
            this.precioTxt = new System.Windows.Forms.TextBox();
            this.Impuesto19lbl = new System.Windows.Forms.Label();
            this.impuestoTxt = new System.Windows.Forms.TextBox();
            this.descuentolbl = new System.Windows.Forms.Label();
            this.descuentoTxt = new System.Windows.Forms.TextBox();
            this.activoRdbt = new System.Windows.Forms.RadioButton();
            this.totallbl = new System.Windows.Forms.Label();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.CargarBtn = new System.Windows.Forms.Button();
            this.actualizarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.finalizarBtn = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelDatosProveedor.SuspendLayout();
            this.panelDatosProducto.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1300, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(100, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(432, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "GESTIÓN DE PROVEEDORES";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogo.Location = new System.Drawing.Point(20, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelDatosProveedor
            // 
            this.panelDatosProveedor.BackColor = System.Drawing.Color.White;
            this.panelDatosProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatosProveedor.Controls.Add(this.lblSeccionProveedor);
            this.panelDatosProveedor.Controls.Add(this.nombreproveedorlbl);
            this.panelDatosProveedor.Controls.Add(this.nombreProveedorTxt);
            this.panelDatosProveedor.Controls.Add(this.categorialbl);
            this.panelDatosProveedor.Controls.Add(this.categoriaCmb);
            this.panelDatosProveedor.Controls.Add(this.telefonolbl);
            this.panelDatosProveedor.Controls.Add(this.telefonoTxt);
            this.panelDatosProveedor.Controls.Add(this.emaillbl);
            this.panelDatosProveedor.Controls.Add(this.emailTxt);
            this.panelDatosProveedor.Location = new System.Drawing.Point(20, 100);
            this.panelDatosProveedor.Name = "panelDatosProveedor";
            this.panelDatosProveedor.Size = new System.Drawing.Size(580, 240);
            this.panelDatosProveedor.TabIndex = 1;
            // 
            // lblSeccionProveedor
            // 
            this.lblSeccionProveedor.AutoSize = true;
            this.lblSeccionProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSeccionProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.lblSeccionProveedor.Location = new System.Drawing.Point(15, 15);
            this.lblSeccionProveedor.Name = "lblSeccionProveedor";
            this.lblSeccionProveedor.Size = new System.Drawing.Size(197, 21);
            this.lblSeccionProveedor.TabIndex = 0;
            this.lblSeccionProveedor.Text = "📋 Datos del Proveedor";
            // 
            // nombreproveedorlbl
            // 
            this.nombreproveedorlbl.AutoSize = true;
            this.nombreproveedorlbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombreproveedorlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.nombreproveedorlbl.Location = new System.Drawing.Point(20, 55);
            this.nombreproveedorlbl.Name = "nombreproveedorlbl";
            this.nombreproveedorlbl.Size = new System.Drawing.Size(117, 15);
            this.nombreproveedorlbl.TabIndex = 1;
            this.nombreproveedorlbl.Text = "Nombre Proveedor *";
            // 
            // nombreProveedorTxt
            // 
            this.nombreProveedorTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nombreProveedorTxt.Location = new System.Drawing.Point(20, 75);
            this.nombreProveedorTxt.Name = "nombreProveedorTxt";
            this.nombreProveedorTxt.Size = new System.Drawing.Size(540, 25);
            this.nombreProveedorTxt.TabIndex = 2;
            this.nombreProveedorTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // categorialbl
            // 
            this.categorialbl.AutoSize = true;
            this.categorialbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categorialbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.categorialbl.Location = new System.Drawing.Point(20, 110);
            this.categorialbl.Name = "categorialbl";
            this.categorialbl.Size = new System.Drawing.Size(66, 15);
            this.categorialbl.TabIndex = 3;
            this.categorialbl.Text = "Categoría *";
            this.categorialbl.Click += new System.EventHandler(this.categorialbl_Click);
            // 
            // categoriaCmb
            // 
            this.categoriaCmb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoriaCmb.FormattingEnabled = true;
            this.categoriaCmb.Location = new System.Drawing.Point(20, 130);
            this.categoriaCmb.Name = "categoriaCmb";
            this.categoriaCmb.Size = new System.Drawing.Size(540, 25);
            this.categoriaCmb.TabIndex = 4;
            // 
            // telefonolbl
            // 
            this.telefonolbl.AutoSize = true;
            this.telefonolbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.telefonolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.telefonolbl.Location = new System.Drawing.Point(20, 165);
            this.telefonolbl.Name = "telefonolbl";
            this.telefonolbl.Size = new System.Drawing.Size(52, 15);
            this.telefonolbl.TabIndex = 5;
            this.telefonolbl.Text = "Teléfono";
            // 
            // telefonoTxt
            // 
            this.telefonoTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.telefonoTxt.Location = new System.Drawing.Point(20, 185);
            this.telefonoTxt.Name = "telefonoTxt";
            this.telefonoTxt.Size = new System.Drawing.Size(260, 25);
            this.telefonoTxt.TabIndex = 6;
            this.telefonoTxt.TextChanged += new System.EventHandler(this.telefonoTxt_TextChanged);
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emaillbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.emaillbl.Location = new System.Drawing.Point(300, 165);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(36, 15);
            this.emaillbl.TabIndex = 7;
            this.emaillbl.Text = "Email";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.emailTxt.Location = new System.Drawing.Point(300, 185);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(260, 25);
            this.emailTxt.TabIndex = 8;
            // 
            // panelDatosProducto
            // 
            this.panelDatosProducto.BackColor = System.Drawing.Color.White;
            this.panelDatosProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatosProducto.Controls.Add(this.lblSeccionProducto);
            this.panelDatosProducto.Controls.Add(this.descripcionproductolbl);
            this.panelDatosProducto.Controls.Add(this.comentarioTxt);
            this.panelDatosProducto.Controls.Add(this.cantidadlbl);
            this.panelDatosProducto.Controls.Add(this.cantidadTxt);
            this.panelDatosProducto.Controls.Add(this.preciolbl);
            this.panelDatosProducto.Controls.Add(this.precioTxt);
            this.panelDatosProducto.Controls.Add(this.Impuesto19lbl);
            this.panelDatosProducto.Controls.Add(this.impuestoTxt);
            this.panelDatosProducto.Controls.Add(this.descuentolbl);
            this.panelDatosProducto.Controls.Add(this.descuentoTxt);
            this.panelDatosProducto.Controls.Add(this.activoRdbt);
            this.panelDatosProducto.Controls.Add(this.totallbl);
            this.panelDatosProducto.Controls.Add(this.totalTxt);
            this.panelDatosProducto.Location = new System.Drawing.Point(620, 100);
            this.panelDatosProducto.Name = "panelDatosProducto";
            this.panelDatosProducto.Size = new System.Drawing.Size(660, 240);
            this.panelDatosProducto.TabIndex = 2;
            // 
            // lblSeccionProducto
            // 
            this.lblSeccionProducto.AutoSize = true;
            this.lblSeccionProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSeccionProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.lblSeccionProducto.Location = new System.Drawing.Point(15, 15);
            this.lblSeccionProducto.Name = "lblSeccionProducto";
            this.lblSeccionProducto.Size = new System.Drawing.Size(192, 21);
            this.lblSeccionProducto.TabIndex = 0;
            this.lblSeccionProducto.Text = "📦 Datos del Producto";
            // 
            // descripcionproductolbl
            // 
            this.descripcionproductolbl.AutoSize = true;
            this.descripcionproductolbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descripcionproductolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.descripcionproductolbl.Location = new System.Drawing.Point(20, 55);
            this.descripcionproductolbl.Name = "descripcionproductolbl";
            this.descripcionproductolbl.Size = new System.Drawing.Size(129, 15);
            this.descripcionproductolbl.TabIndex = 1;
            this.descripcionproductolbl.Text = "Descripción Producto *";
            this.descripcionproductolbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comentarioTxt
            // 
            this.comentarioTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comentarioTxt.Location = new System.Drawing.Point(20, 75);
            this.comentarioTxt.Name = "comentarioTxt";
            this.comentarioTxt.Size = new System.Drawing.Size(620, 25);
            this.comentarioTxt.TabIndex = 2;
            // 
            // cantidadlbl
            // 
            this.cantidadlbl.AutoSize = true;
            this.cantidadlbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cantidadlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cantidadlbl.Location = new System.Drawing.Point(20, 110);
            this.cantidadlbl.Name = "cantidadlbl";
            this.cantidadlbl.Size = new System.Drawing.Size(63, 15);
            this.cantidadlbl.TabIndex = 3;
            this.cantidadlbl.Text = "Cantidad *";
            this.cantidadlbl.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // cantidadTxt
            // 
            this.cantidadTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cantidadTxt.Location = new System.Drawing.Point(20, 130);
            this.cantidadTxt.Name = "cantidadTxt";
            this.cantidadTxt.Size = new System.Drawing.Size(150, 25);
            this.cantidadTxt.TabIndex = 4;
            this.cantidadTxt.TextChanged += new System.EventHandler(this.cantidadTxt_TextChanged);
            // 
            // preciolbl
            // 
            this.preciolbl.AutoSize = true;
            this.preciolbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.preciolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.preciolbl.Location = new System.Drawing.Point(190, 110);
            this.preciolbl.Name = "preciolbl";
            this.preciolbl.Size = new System.Drawing.Size(48, 15);
            this.preciolbl.TabIndex = 5;
            this.preciolbl.Text = "Precio *";
            // 
            // precioTxt
            // 
            this.precioTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.precioTxt.Location = new System.Drawing.Point(190, 130);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(150, 25);
            this.precioTxt.TabIndex = 6;
            this.precioTxt.TextChanged += new System.EventHandler(this.precioTxt_TextChanged);
            // 
            // Impuesto19lbl
            // 
            this.Impuesto19lbl.AutoSize = true;
            this.Impuesto19lbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Impuesto19lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Impuesto19lbl.Location = new System.Drawing.Point(20, 165);
            this.Impuesto19lbl.Name = "Impuesto19lbl";
            this.Impuesto19lbl.Size = new System.Drawing.Size(82, 15);
            this.Impuesto19lbl.TabIndex = 7;
            this.Impuesto19lbl.Text = "Impuesto 19%";
            // 
            // impuestoTxt
            // 
            this.impuestoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.impuestoTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.impuestoTxt.Location = new System.Drawing.Point(20, 185);
            this.impuestoTxt.Name = "impuestoTxt";
            this.impuestoTxt.ReadOnly = true;
            this.impuestoTxt.Size = new System.Drawing.Size(150, 25);
            this.impuestoTxt.TabIndex = 8;
            this.impuestoTxt.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // descuentolbl
            // 
            this.descuentolbl.AutoSize = true;
            this.descuentolbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descuentolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.descuentolbl.Location = new System.Drawing.Point(190, 165);
            this.descuentolbl.Name = "descuentolbl";
            this.descuentolbl.Size = new System.Drawing.Size(63, 15);
            this.descuentolbl.TabIndex = 9;
            this.descuentolbl.Text = "Descuento";
            // 
            // descuentoTxt
            // 
            this.descuentoTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.descuentoTxt.Location = new System.Drawing.Point(190, 185);
            this.descuentoTxt.Name = "descuentoTxt";
            this.descuentoTxt.Size = new System.Drawing.Size(150, 25);
            this.descuentoTxt.TabIndex = 10;
            // 
            // activoRdbt
            // 
            this.activoRdbt.AutoSize = true;
            this.activoRdbt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.activoRdbt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.activoRdbt.Location = new System.Drawing.Point(360, 133);
            this.activoRdbt.Name = "activoRdbt";
            this.activoRdbt.Size = new System.Drawing.Size(69, 19);
            this.activoRdbt.TabIndex = 11;
            this.activoRdbt.TabStop = true;
            this.activoRdbt.Text = "¿Activo?";
            this.activoRdbt.UseVisualStyleBackColor = true;
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.totallbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.totallbl.Location = new System.Drawing.Point(360, 165);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(40, 19);
            this.totallbl.TabIndex = 12;
            this.totallbl.Text = "Total";
            // 
            // totalTxt
            // 
            this.totalTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.totalTxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.totalTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.totalTxt.Location = new System.Drawing.Point(360, 185);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.ReadOnly = true;
            this.totalTxt.Size = new System.Drawing.Size(180, 27);
            this.totalTxt.TabIndex = 13;
            this.totalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.Color.White;
            this.panelDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDataGrid.Controls.Add(this.dataGridView1);
            this.panelDataGrid.Location = new System.Drawing.Point(20, 360);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(1260, 280);
            this.panelDataGrid.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1258, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.White;
            this.panelBotones.Controls.Add(this.CargarBtn);
            this.panelBotones.Controls.Add(this.actualizarBtn);
            this.panelBotones.Controls.Add(this.limpiarBtn);
            this.panelBotones.Controls.Add(this.finalizarBtn);
            this.panelBotones.Location = new System.Drawing.Point(20, 655);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1260, 60);
            this.panelBotones.TabIndex = 4;
            // 
            // CargarBtn
            // 
            this.CargarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.CargarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargarBtn.FlatAppearance.BorderSize = 0;
            this.CargarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CargarBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CargarBtn.ForeColor = System.Drawing.Color.White;
            this.CargarBtn.Location = new System.Drawing.Point(380, 10);
            this.CargarBtn.Name = "CargarBtn";
            this.CargarBtn.Size = new System.Drawing.Size(140, 40);
            this.CargarBtn.TabIndex = 0;
            this.CargarBtn.Text = "💾 Cargar";
            this.CargarBtn.UseVisualStyleBackColor = false;
            this.CargarBtn.Click += new System.EventHandler(this.CargarBtn_Click);
            // 
            // actualizarBtn
            // 
            this.actualizarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.actualizarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualizarBtn.FlatAppearance.BorderSize = 0;
            this.actualizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizarBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.actualizarBtn.ForeColor = System.Drawing.Color.White;
            this.actualizarBtn.Location = new System.Drawing.Point(540, 10);
            this.actualizarBtn.Name = "actualizarBtn";
            this.actualizarBtn.Size = new System.Drawing.Size(140, 40);
            this.actualizarBtn.TabIndex = 1;
            this.actualizarBtn.Text = "🔄 Actualizar";
            this.actualizarBtn.UseVisualStyleBackColor = false;
            this.actualizarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.limpiarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiarBtn.FlatAppearance.BorderSize = 0;
            this.limpiarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.limpiarBtn.ForeColor = System.Drawing.Color.White;
            this.limpiarBtn.Location = new System.Drawing.Point(700, 10);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(140, 40);
            this.limpiarBtn.TabIndex = 2;
            this.limpiarBtn.Text = "🗑️ Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = false;
            // 
            // finalizarBtn
            // 
            this.finalizarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.finalizarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finalizarBtn.FlatAppearance.BorderSize = 0;
            this.finalizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizarBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.finalizarBtn.ForeColor = System.Drawing.Color.White;
            this.finalizarBtn.Location = new System.Drawing.Point(1060, 10);
            this.finalizarBtn.Name = "finalizarBtn";
            this.finalizarBtn.Size = new System.Drawing.Size(140, 40);
            this.finalizarBtn.TabIndex = 3;
            this.finalizarBtn.Text = "✅ Finalizar";
            this.finalizarBtn.UseVisualStyleBackColor = false;
            this.finalizarBtn.Click += new System.EventHandler(this.finalizarBtn_Click);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1300, 730);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.panelDatosProducto);
            this.Controls.Add(this.panelDatosProveedor);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RJAS Market - Proveedores";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelDatosProveedor.ResumeLayout(false);
            this.panelDatosProveedor.PerformLayout();
            this.panelDatosProducto.ResumeLayout(false);
            this.panelDatosProducto.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
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