namespace RJAS_Market_App
{
    partial class ConfirmarEliminar
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
            confirmDeleteLbl = new Label();
            successBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // confirmDeleteLbl
            // 
            confirmDeleteLbl.AutoSize = true;
            confirmDeleteLbl.Location = new Point(54, 107);
            confirmDeleteLbl.Name = "confirmDeleteLbl";
            confirmDeleteLbl.Size = new Size(217, 15);
            confirmDeleteLbl.TabIndex = 0;
            confirmDeleteLbl.Text = "¿Esta seguro(a) de eliminar el producto?";
            confirmDeleteLbl.Click += label1_Click;
            // 
            // successBtn
            // 
            successBtn.Location = new Point(77, 153);
            successBtn.Name = "successBtn";
            successBtn.Size = new Size(75, 23);
            successBtn.TabIndex = 1;
            successBtn.Text = "Aceptar";
            successBtn.UseVisualStyleBackColor = true;
            successBtn.Click += successBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(168, 153);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 2;
            cancelBtn.Text = "Cancelar";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // ConfirmarEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 214);
            Controls.Add(cancelBtn);
            Controls.Add(successBtn);
            Controls.Add(confirmDeleteLbl);
            Name = "ConfirmarEliminar";
            Text = "ConfirmarEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label confirmDeleteLbl;
        private Button successBtn;
        private Button cancelBtn;
    }
}