
namespace Sistema
{
    partial class Form_iDAlcoholEliminar
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
            this.btnBuscar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtcodigoProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblcodigoProducto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.CheckedState.Parent = this.btnBuscar;
            this.btnBuscar.CustomImages.Parent = this.btnBuscar;
            this.btnBuscar.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscar.FillColor2 = System.Drawing.Color.CadetBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Raleway Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.HoverState.Parent = this.btnBuscar;
            this.btnBuscar.Location = new System.Drawing.Point(51, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Parent = this.btnBuscar;
            this.btnBuscar.Size = new System.Drawing.Size(180, 45);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtcodigoProducto
            // 
            this.txtcodigoProducto.BorderColor = System.Drawing.Color.Black;
            this.txtcodigoProducto.BorderRadius = 5;
            this.txtcodigoProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigoProducto.DefaultText = "";
            this.txtcodigoProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcodigoProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcodigoProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodigoProducto.DisabledState.Parent = this.txtcodigoProducto;
            this.txtcodigoProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodigoProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodigoProducto.FocusedState.Parent = this.txtcodigoProducto;
            this.txtcodigoProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodigoProducto.HoverState.Parent = this.txtcodigoProducto;
            this.txtcodigoProducto.Location = new System.Drawing.Point(42, 57);
            this.txtcodigoProducto.Name = "txtcodigoProducto";
            this.txtcodigoProducto.PasswordChar = '\0';
            this.txtcodigoProducto.PlaceholderText = "";
            this.txtcodigoProducto.SelectedText = "";
            this.txtcodigoProducto.ShadowDecoration.Parent = this.txtcodigoProducto;
            this.txtcodigoProducto.Size = new System.Drawing.Size(200, 36);
            this.txtcodigoProducto.TabIndex = 4;
            // 
            // lblcodigoProducto
            // 
            this.lblcodigoProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblcodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblcodigoProducto.Location = new System.Drawing.Point(12, 12);
            this.lblcodigoProducto.Name = "lblcodigoProducto";
            this.lblcodigoProducto.Size = new System.Drawing.Size(263, 27);
            this.lblcodigoProducto.TabIndex = 3;
            this.lblcodigoProducto.Text = "Ingrese el código del producto";
            // 
            // Form_iDAlcoholEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtcodigoProducto);
            this.Controls.Add(this.lblcodigoProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_iDAlcoholEliminar";
            this.Text = "Form_iDAlcoholEliminar";
            this.Load += new System.EventHandler(this.Form_iDAlcoholEliminar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnBuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtcodigoProducto;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblcodigoProducto;
    }
}