
namespace Sistema
{
    partial class Form_registrarCantidadDeAlcohol
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
            this.lbltituloRegistrarCantidadAlcohol = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCantidadAlcohol = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblregistroGradoDeAlcohol = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbunidades = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbldetalle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnguardar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.grbregistroDeLaCantidadAlcohol = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtdetalleAlcohol = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtgradoDeAlcohol = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcantidadAlcohol = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbregistroDeLaCantidadAlcohol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltituloRegistrarCantidadAlcohol
            // 
            this.lbltituloRegistrarCantidadAlcohol.BackColor = System.Drawing.Color.Transparent;
            this.lbltituloRegistrarCantidadAlcohol.Font = new System.Drawing.Font("Raleway", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbltituloRegistrarCantidadAlcohol.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbltituloRegistrarCantidadAlcohol.Location = new System.Drawing.Point(28, 18);
            this.lbltituloRegistrarCantidadAlcohol.Name = "lbltituloRegistrarCantidadAlcohol";
            this.lbltituloRegistrarCantidadAlcohol.Size = new System.Drawing.Size(458, 46);
            this.lbltituloRegistrarCantidadAlcohol.TabIndex = 0;
            this.lbltituloRegistrarCantidadAlcohol.Text = "Registrar Cantidad de Alcohol";
            this.lbltituloRegistrarCantidadAlcohol.Click += new System.EventHandler(this.lbltituloRegistrarCantidadAlcohol_Click);
            // 
            // lblCantidadAlcohol
            // 
            this.lblCantidadAlcohol.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCantidadAlcohol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCantidadAlcohol.Location = new System.Drawing.Point(16, 88);
            this.lblCantidadAlcohol.Name = "lblCantidadAlcohol";
            this.lblCantidadAlcohol.Size = new System.Drawing.Size(178, 26);
            this.lblCantidadAlcohol.TabIndex = 1;
            this.lblCantidadAlcohol.Text = "Cantidad de Alcohol:";
            // 
            // lblregistroGradoDeAlcohol
            // 
            this.lblregistroGradoDeAlcohol.BackColor = System.Drawing.Color.Transparent;
            this.lblregistroGradoDeAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblregistroGradoDeAlcohol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblregistroGradoDeAlcohol.Location = new System.Drawing.Point(36, 144);
            this.lblregistroGradoDeAlcohol.Name = "lblregistroGradoDeAlcohol";
            this.lblregistroGradoDeAlcohol.Size = new System.Drawing.Size(156, 26);
            this.lblregistroGradoDeAlcohol.TabIndex = 2;
            this.lblregistroGradoDeAlcohol.Text = "Grado de Alcohol:";
            // 
            // cmbunidades
            // 
            this.cmbunidades.BackColor = System.Drawing.Color.Transparent;
            this.cmbunidades.BorderColor = System.Drawing.Color.Black;
            this.cmbunidades.BorderRadius = 5;
            this.cmbunidades.BorderThickness = 2;
            this.cmbunidades.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbunidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbunidades.FocusedColor = System.Drawing.Color.Empty;
            this.cmbunidades.FocusedState.Parent = this.cmbunidades;
            this.cmbunidades.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbunidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbunidades.FormattingEnabled = true;
            this.cmbunidades.HoverState.Parent = this.cmbunidades;
            this.cmbunidades.ItemHeight = 30;
            this.cmbunidades.Items.AddRange(new object[] {
            "Litro",
            "Pipa",
            "Galon"});
            this.cmbunidades.ItemsAppearance.Parent = this.cmbunidades;
            this.cmbunidades.Location = new System.Drawing.Point(459, 83);
            this.cmbunidades.Name = "cmbunidades";
            this.cmbunidades.ShadowDecoration.Parent = this.cmbunidades;
            this.cmbunidades.Size = new System.Drawing.Size(113, 36);
            this.cmbunidades.TabIndex = 9;
            this.cmbunidades.Tag = "";
            this.cmbunidades.SelectedIndexChanged += new System.EventHandler(this.cmbunidades_SelectedIndexChanged);
            // 
            // lbldetalle
            // 
            this.lbldetalle.BackColor = System.Drawing.Color.Transparent;
            this.lbldetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbldetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbldetalle.Location = new System.Drawing.Point(16, 188);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(176, 26);
            this.lbldetalle.TabIndex = 15;
            this.lbldetalle.Text = "Detalle del producto:";
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
            this.btnguardar.Location = new System.Drawing.Point(469, 456);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.ShadowDecoration.Parent = this.btnguardar;
            this.btnguardar.Size = new System.Drawing.Size(180, 45);
            this.btnguardar.TabIndex = 18;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // grbregistroDeLaCantidadAlcohol
            // 
            this.grbregistroDeLaCantidadAlcohol.Controls.Add(this.txtcantidadAlcohol);
            this.grbregistroDeLaCantidadAlcohol.Controls.Add(this.txtgradoDeAlcohol);
            this.grbregistroDeLaCantidadAlcohol.Controls.Add(this.txtdetalleAlcohol);
            this.grbregistroDeLaCantidadAlcohol.Controls.Add(this.cmbunidades);
            this.grbregistroDeLaCantidadAlcohol.Controls.Add(this.lblregistroGradoDeAlcohol);
            this.grbregistroDeLaCantidadAlcohol.Controls.Add(this.lbldetalle);
            this.grbregistroDeLaCantidadAlcohol.Controls.Add(this.lblCantidadAlcohol);
            this.grbregistroDeLaCantidadAlcohol.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.grbregistroDeLaCantidadAlcohol.FillColor = System.Drawing.SystemColors.Menu;
            this.grbregistroDeLaCantidadAlcohol.Font = new System.Drawing.Font("Raleway", 14F);
            this.grbregistroDeLaCantidadAlcohol.ForeColor = System.Drawing.Color.White;
            this.grbregistroDeLaCantidadAlcohol.Location = new System.Drawing.Point(28, 82);
            this.grbregistroDeLaCantidadAlcohol.Name = "grbregistroDeLaCantidadAlcohol";
            this.grbregistroDeLaCantidadAlcohol.ShadowDecoration.Parent = this.grbregistroDeLaCantidadAlcohol;
            this.grbregistroDeLaCantidadAlcohol.Size = new System.Drawing.Size(621, 351);
            this.grbregistroDeLaCantidadAlcohol.TabIndex = 19;
            this.grbregistroDeLaCantidadAlcohol.Text = "Registro de la Cantidad de Alcohol";
            this.grbregistroDeLaCantidadAlcohol.Click += new System.EventHandler(this.grbregistroDeLaCantidadAlcohol_Click);
            // 
            // txtdetalleAlcohol
            // 
            this.txtdetalleAlcohol.BorderColor = System.Drawing.Color.Black;
            this.txtdetalleAlcohol.BorderRadius = 5;
            this.txtdetalleAlcohol.BorderThickness = 2;
            this.txtdetalleAlcohol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdetalleAlcohol.DefaultText = "";
            this.txtdetalleAlcohol.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdetalleAlcohol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdetalleAlcohol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdetalleAlcohol.DisabledState.Parent = this.txtdetalleAlcohol;
            this.txtdetalleAlcohol.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdetalleAlcohol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdetalleAlcohol.FocusedState.Parent = this.txtdetalleAlcohol;
            this.txtdetalleAlcohol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdetalleAlcohol.ForeColor = System.Drawing.Color.Black;
            this.txtdetalleAlcohol.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdetalleAlcohol.HoverState.Parent = this.txtdetalleAlcohol;
            this.txtdetalleAlcohol.Location = new System.Drawing.Point(14, 221);
            this.txtdetalleAlcohol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdetalleAlcohol.Multiline = true;
            this.txtdetalleAlcohol.Name = "txtdetalleAlcohol";
            this.txtdetalleAlcohol.PasswordChar = '\0';
            this.txtdetalleAlcohol.PlaceholderText = "";
            this.txtdetalleAlcohol.SelectedText = "";
            this.txtdetalleAlcohol.ShadowDecoration.Parent = this.txtdetalleAlcohol;
            this.txtdetalleAlcohol.Size = new System.Drawing.Size(422, 95);
            this.txtdetalleAlcohol.TabIndex = 22;
            this.txtdetalleAlcohol.TextChanged += new System.EventHandler(this.txtdetalleAlcohol_TextChanged);
            // 
            // txtgradoDeAlcohol
            // 
            this.txtgradoDeAlcohol.BorderColor = System.Drawing.Color.Black;
            this.txtgradoDeAlcohol.BorderRadius = 5;
            this.txtgradoDeAlcohol.BorderThickness = 2;
            this.txtgradoDeAlcohol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgradoDeAlcohol.DefaultText = "";
            this.txtgradoDeAlcohol.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtgradoDeAlcohol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtgradoDeAlcohol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgradoDeAlcohol.DisabledState.Parent = this.txtgradoDeAlcohol;
            this.txtgradoDeAlcohol.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgradoDeAlcohol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgradoDeAlcohol.FocusedState.Parent = this.txtgradoDeAlcohol;
            this.txtgradoDeAlcohol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgradoDeAlcohol.ForeColor = System.Drawing.Color.Black;
            this.txtgradoDeAlcohol.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgradoDeAlcohol.HoverState.Parent = this.txtgradoDeAlcohol;
            this.txtgradoDeAlcohol.Location = new System.Drawing.Point(198, 144);
            this.txtgradoDeAlcohol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtgradoDeAlcohol.Name = "txtgradoDeAlcohol";
            this.txtgradoDeAlcohol.PasswordChar = '\0';
            this.txtgradoDeAlcohol.PlaceholderText = "";
            this.txtgradoDeAlcohol.SelectedText = "";
            this.txtgradoDeAlcohol.ShadowDecoration.Parent = this.txtgradoDeAlcohol;
            this.txtgradoDeAlcohol.Size = new System.Drawing.Size(238, 31);
            this.txtgradoDeAlcohol.TabIndex = 23;
            this.txtgradoDeAlcohol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtgradoDeAlcohol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgradoDeAlcohol_KeyPress);
            this.txtgradoDeAlcohol.Validating += new System.ComponentModel.CancelEventHandler(this.txtgradoDeAlcohol_Validating);
            // 
            // txtcantidadAlcohol
            // 
            this.txtcantidadAlcohol.BorderColor = System.Drawing.Color.Black;
            this.txtcantidadAlcohol.BorderRadius = 5;
            this.txtcantidadAlcohol.BorderThickness = 2;
            this.txtcantidadAlcohol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcantidadAlcohol.DefaultText = "";
            this.txtcantidadAlcohol.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcantidadAlcohol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcantidadAlcohol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcantidadAlcohol.DisabledState.Parent = this.txtcantidadAlcohol;
            this.txtcantidadAlcohol.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcantidadAlcohol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcantidadAlcohol.FocusedState.Parent = this.txtcantidadAlcohol;
            this.txtcantidadAlcohol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidadAlcohol.ForeColor = System.Drawing.Color.Black;
            this.txtcantidadAlcohol.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcantidadAlcohol.HoverState.Parent = this.txtcantidadAlcohol;
            this.txtcantidadAlcohol.Location = new System.Drawing.Point(198, 88);
            this.txtcantidadAlcohol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcantidadAlcohol.Name = "txtcantidadAlcohol";
            this.txtcantidadAlcohol.PasswordChar = '\0';
            this.txtcantidadAlcohol.PlaceholderText = "";
            this.txtcantidadAlcohol.SelectedText = "";
            this.txtcantidadAlcohol.ShadowDecoration.Parent = this.txtcantidadAlcohol;
            this.txtcantidadAlcohol.Size = new System.Drawing.Size(238, 31);
            this.txtcantidadAlcohol.TabIndex = 24;
            this.txtcantidadAlcohol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcantidadAlcohol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidadAlcohol_KeyPress);
            this.txtcantidadAlcohol.Validating += new System.ComponentModel.CancelEventHandler(this.txtcantidadAlcohol_Validating);
            // 
            // Form_registrarCantidadDeAlcohol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(661, 513);
            this.Controls.Add(this.grbregistroDeLaCantidadAlcohol);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lbltituloRegistrarCantidadAlcohol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(-2500, 1000);
            this.Name = "Form_registrarCantidadDeAlcohol";
            this.Text = "Nuevo Producto";
            this.Load += new System.EventHandler(this.Form_registrarCantidadDeAlcohol_Load);
            this.grbregistroDeLaCantidadAlcohol.ResumeLayout(false);
            this.grbregistroDeLaCantidadAlcohol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbltituloRegistrarCantidadAlcohol;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCantidadAlcohol;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblregistroGradoDeAlcohol;
        private Guna.UI2.WinForms.Guna2ComboBox cmbunidades;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbldetalle;
        private Guna.UI2.WinForms.Guna2GradientButton btnguardar;
        private Guna.UI2.WinForms.Guna2GroupBox grbregistroDeLaCantidadAlcohol;
        private Guna.UI2.WinForms.Guna2TextBox txtdetalleAlcohol;
        private Guna.UI2.WinForms.Guna2TextBox txtcantidadAlcohol;
        private Guna.UI2.WinForms.Guna2TextBox txtgradoDeAlcohol;
    }
}