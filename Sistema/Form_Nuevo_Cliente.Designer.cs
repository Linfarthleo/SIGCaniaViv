
namespace Sistema
{
    partial class Form_Nuevo_Cliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Nuevo_Cliente));
            this.lbltitulocliente = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcedula = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttelfmovil = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulocliente
            // 
            this.lbltitulocliente.AutoSize = true;
            this.lbltitulocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulocliente.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbltitulocliente.Location = new System.Drawing.Point(30, 12);
            this.lbltitulocliente.Name = "lbltitulocliente";
            this.lbltitulocliente.Size = new System.Drawing.Size(247, 39);
            this.lbltitulocliente.TabIndex = 1;
            this.lbltitulocliente.Text = "Nuevo Cliente";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.txtNombres);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.txtapellidos);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.txtcedula);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2GroupBox1.FillColor = System.Drawing.SystemColors.Menu;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(37, 81);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(742, 200);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Información del Cliente:";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.BorderColor = System.Drawing.Color.Black;
            this.txtNombres.BorderRadius = 5;
            this.txtNombres.BorderThickness = 2;
            this.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombres.DefaultText = "";
            this.txtNombres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombres.DisabledState.Parent = this.txtNombres;
            this.txtNombres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombres.FocusedState.Parent = this.txtNombres;
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.Black;
            this.txtNombres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombres.HoverState.Parent = this.txtNombres;
            this.txtNombres.Location = new System.Drawing.Point(221, 102);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.PlaceholderText = "";
            this.txtNombres.SelectedText = "";
            this.txtNombres.ShadowDecoration.Parent = this.txtNombres;
            this.txtNombres.Size = new System.Drawing.Size(478, 31);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombresKeyP);
            this.txtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombresValidating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos:";
            // 
            // txtapellidos
            // 
            this.txtapellidos.BorderColor = System.Drawing.Color.Black;
            this.txtapellidos.BorderRadius = 5;
            this.txtapellidos.BorderThickness = 2;
            this.txtapellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtapellidos.DefaultText = "";
            this.txtapellidos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtapellidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtapellidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtapellidos.DisabledState.Parent = this.txtapellidos;
            this.txtapellidos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtapellidos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtapellidos.FocusedState.Parent = this.txtapellidos;
            this.txtapellidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.ForeColor = System.Drawing.Color.Black;
            this.txtapellidos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtapellidos.HoverState.Parent = this.txtapellidos;
            this.txtapellidos.Location = new System.Drawing.Point(221, 143);
            this.txtapellidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.PasswordChar = '\0';
            this.txtapellidos.PlaceholderText = "";
            this.txtapellidos.SelectedText = "";
            this.txtapellidos.ShadowDecoration.Parent = this.txtapellidos;
            this.txtapellidos.Size = new System.Drawing.Size(478, 31);
            this.txtapellidos.TabIndex = 2;
            this.txtapellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidosKeyP);
            this.txtapellidos.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidosValidating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cédula No.:";
            // 
            // txtcedula
            // 
            this.txtcedula.BorderColor = System.Drawing.Color.Black;
            this.txtcedula.BorderRadius = 5;
            this.txtcedula.BorderThickness = 2;
            this.txtcedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcedula.DefaultText = "";
            this.txtcedula.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcedula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcedula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcedula.DisabledState.Parent = this.txtcedula;
            this.txtcedula.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcedula.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcedula.FocusedState.Parent = this.txtcedula;
            this.txtcedula.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtcedula.ForeColor = System.Drawing.Color.Black;
            this.txtcedula.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcedula.HoverState.Parent = this.txtcedula;
            this.txtcedula.Location = new System.Drawing.Point(221, 56);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.PasswordChar = '\0';
            this.txtcedula.PlaceholderText = "";
            this.txtcedula.SelectedText = "";
            this.txtcedula.ShadowDecoration.Parent = this.txtcedula;
            this.txtcedula.Size = new System.Drawing.Size(478, 31);
            this.txtcedula.TabIndex = 3;
            this.txtcedula.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaKeyP);
            this.txtcedula.Validating += new System.ComponentModel.CancelEventHandler(this.txtCedulaValidating);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.txttelfmovil);
            this.guna2GroupBox2.Controls.Add(this.txtcorreo);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.txtdireccion);
            this.guna2GroupBox2.Controls.Add(this.label9);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2GroupBox2.FillColor = System.Drawing.SystemColors.Menu;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(37, 287);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(741, 258);
            this.guna2GroupBox2.TabIndex = 3;
            this.guna2GroupBox2.Text = "Información de Contacto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teléfono:";
            // 
            // txttelfmovil
            // 
            this.txttelfmovil.BorderColor = System.Drawing.Color.Black;
            this.txttelfmovil.BorderRadius = 5;
            this.txttelfmovil.BorderThickness = 2;
            this.txttelfmovil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttelfmovil.DefaultText = "";
            this.txttelfmovil.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttelfmovil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttelfmovil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttelfmovil.DisabledState.Parent = this.txttelfmovil;
            this.txttelfmovil.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttelfmovil.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttelfmovil.FocusedState.Parent = this.txttelfmovil;
            this.txttelfmovil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelfmovil.ForeColor = System.Drawing.Color.Black;
            this.txttelfmovil.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttelfmovil.HoverState.Parent = this.txttelfmovil;
            this.txttelfmovil.Location = new System.Drawing.Point(220, 50);
            this.txttelfmovil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttelfmovil.Name = "txttelfmovil";
            this.txttelfmovil.PasswordChar = '\0';
            this.txttelfmovil.PlaceholderText = "";
            this.txttelfmovil.SelectedText = "";
            this.txttelfmovil.ShadowDecoration.Parent = this.txttelfmovil;
            this.txttelfmovil.Size = new System.Drawing.Size(305, 31);
            this.txttelfmovil.TabIndex = 1;
            this.txttelfmovil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelfCel1KeyP);
            this.txttelfmovil.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelfCel1Validating);
            // 
            // txtcorreo
            // 
            this.txtcorreo.BorderColor = System.Drawing.Color.Black;
            this.txtcorreo.BorderRadius = 5;
            this.txtcorreo.BorderThickness = 2;
            this.txtcorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcorreo.DefaultText = "";
            this.txtcorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcorreo.DisabledState.Parent = this.txtcorreo;
            this.txtcorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcorreo.FocusedState.Parent = this.txtcorreo;
            this.txtcorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcorreo.ForeColor = System.Drawing.Color.Black;
            this.txtcorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcorreo.HoverState.Parent = this.txtcorreo;
            this.txtcorreo.Location = new System.Drawing.Point(219, 140);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.PasswordChar = '\0';
            this.txtcorreo.PlaceholderText = "";
            this.txtcorreo.SelectedText = "";
            this.txtcorreo.ShadowDecoration.Parent = this.txtcorreo;
            this.txtcorreo.Size = new System.Drawing.Size(306, 32);
            this.txtcorreo.TabIndex = 5;
            this.txtcorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreoValidating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(3, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Correo:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.BorderColor = System.Drawing.Color.Black;
            this.txtdireccion.BorderRadius = 5;
            this.txtdireccion.BorderThickness = 2;
            this.txtdireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdireccion.DefaultText = "";
            this.txtdireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdireccion.DisabledState.Parent = this.txtdireccion;
            this.txtdireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdireccion.FocusedState.Parent = this.txtdireccion;
            this.txtdireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.Color.Black;
            this.txtdireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdireccion.HoverState.Parent = this.txtdireccion;
            this.txtdireccion.Location = new System.Drawing.Point(220, 94);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PasswordChar = '\0';
            this.txtdireccion.PlaceholderText = "";
            this.txtdireccion.SelectedText = "";
            this.txtdireccion.ShadowDecoration.Parent = this.txtdireccion;
            this.txtdireccion.Size = new System.Drawing.Size(305, 31);
            this.txtdireccion.TabIndex = 3;
            this.txtdireccion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDireccionValidating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(3, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Dirección:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.InitialImage")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(712, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(66, 63);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 36;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardar.FillColor2 = System.Drawing.Color.CadetBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGuardar.Location = new System.Drawing.Point(622, 551);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(141, 39);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarHab_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_Nuevo_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(791, 602);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lbltitulocliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Nuevo_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.Form_Nuevo_Cliente_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulocliente;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtapellidos;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtcedula;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txttelfmovil;
        private Guna.UI2.WinForms.Guna2TextBox txtcorreo;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtdireccion;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}