namespace RJAS_Market_App
{
    partial class InformacionProducto
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
            components = new System.ComponentModel.Container();
            successLbl = new Label();
            notifyIcon1 = new NotifyIcon(components);
            approvedBtn = new Button();
            SuspendLayout();
            // 
            // successLbl
            // 
            successLbl.AutoSize = true;
            successLbl.Location = new Point(78, 97);
            successLbl.Name = "successLbl";
            successLbl.Size = new Size(163, 15);
            successLbl.TabIndex = 0;
            successLbl.Text = "¡Productos creados con exito!";
            successLbl.Click += label1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // approvedBtn
            // 
            approvedBtn.Location = new Point(118, 140);
            approvedBtn.Name = "approvedBtn";
            approvedBtn.Size = new Size(75, 23);
            approvedBtn.TabIndex = 1;
            approvedBtn.Text = "Aceptar";
            approvedBtn.UseVisualStyleBackColor = true;
            // 
            // InformacionProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 204);
            Controls.Add(approvedBtn);
            Controls.Add(successLbl);
            Name = "InformacionProducto";
            Text = "InformacionProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label successLbl;
        private NotifyIcon notifyIcon1;
        private Button approvedBtn;
    }
}