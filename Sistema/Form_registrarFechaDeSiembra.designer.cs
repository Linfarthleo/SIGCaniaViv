
namespace Sistema
{
    partial class Form_registrarFechaDeSiembra
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
            this.lbltituloRegistroFechaDeSiembra = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIngreseFechaDeSiembra = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtmFechaSiembra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnguardar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // lbltituloRegistroFechaDeSiembra
            // 
            this.lbltituloRegistroFechaDeSiembra.BackColor = System.Drawing.Color.Transparent;
            this.lbltituloRegistroFechaDeSiembra.Font = new System.Drawing.Font("Raleway", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloRegistroFechaDeSiembra.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbltituloRegistroFechaDeSiembra.Location = new System.Drawing.Point(13, 13);
            this.lbltituloRegistroFechaDeSiembra.Name = "lbltituloRegistroFechaDeSiembra";
            this.lbltituloRegistroFechaDeSiembra.Size = new System.Drawing.Size(204, 36);
            this.lbltituloRegistroFechaDeSiembra.TabIndex = 0;
            this.lbltituloRegistroFechaDeSiembra.Text = "Fecha de Siembra";
            // 
            // lblIngreseFechaDeSiembra
            // 
            this.lblIngreseFechaDeSiembra.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreseFechaDeSiembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblIngreseFechaDeSiembra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIngreseFechaDeSiembra.Location = new System.Drawing.Point(13, 82);
            this.lblIngreseFechaDeSiembra.Name = "lblIngreseFechaDeSiembra";
            this.lblIngreseFechaDeSiembra.Size = new System.Drawing.Size(240, 26);
            this.lblIngreseFechaDeSiembra.TabIndex = 1;
            this.lblIngreseFechaDeSiembra.Text = "Ingrese la fecha de siembra: ";
            // 
            // dtmFechaSiembra
            // 
            this.dtmFechaSiembra.CheckedState.Parent = this.dtmFechaSiembra;
            this.dtmFechaSiembra.FillColor = System.Drawing.Color.Honeydew;
            this.dtmFechaSiembra.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmFechaSiembra.HoverState.Parent = this.dtmFechaSiembra;
            this.dtmFechaSiembra.Location = new System.Drawing.Point(268, 72);
            this.dtmFechaSiembra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmFechaSiembra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmFechaSiembra.Name = "dtmFechaSiembra";
            this.dtmFechaSiembra.ShadowDecoration.Parent = this.dtmFechaSiembra;
            this.dtmFechaSiembra.Size = new System.Drawing.Size(224, 36);
            this.dtmFechaSiembra.TabIndex = 2;
            this.dtmFechaSiembra.Value = new System.DateTime(2021, 9, 7, 15, 14, 5, 837);
            // 
            // btnguardar
            // 
            this.btnguardar.CheckedState.Parent = this.btnguardar;
            this.btnguardar.CustomImages.Parent = this.btnguardar;
            this.btnguardar.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnguardar.FillColor2 = System.Drawing.Color.CadetBlue;
            this.btnguardar.Font = new System.Drawing.Font("Raleway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.HoverState.Parent = this.btnguardar;
            this.btnguardar.Location = new System.Drawing.Point(377, 155);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.ShadowDecoration.Parent = this.btnguardar;
            this.btnguardar.Size = new System.Drawing.Size(180, 45);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            // 
            // Form_registrarFechaDeSiembra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(569, 212);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dtmFechaSiembra);
            this.Controls.Add(this.lblIngreseFechaDeSiembra);
            this.Controls.Add(this.lbltituloRegistroFechaDeSiembra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_registrarFechaDeSiembra";
            this.Text = "Fecha de siembra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbltituloRegistroFechaDeSiembra;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIngreseFechaDeSiembra;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmFechaSiembra;
        private Guna.UI2.WinForms.Guna2GradientButton btnguardar;
    }
}