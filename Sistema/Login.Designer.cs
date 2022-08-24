
namespace Sistema
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.fondoDeLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chk_Pass = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.txt_User = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelErr = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnExitMain = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fondoDeLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fondoDeLogin
            // 
            this.fondoDeLogin.Image = ((System.Drawing.Image)(resources.GetObject("fondoDeLogin.Image")));
            this.fondoDeLogin.Location = new System.Drawing.Point(0, -1);
            this.fondoDeLogin.Name = "fondoDeLogin";
            this.fondoDeLogin.ShadowDecoration.Parent = this.fondoDeLogin;
            this.fondoDeLogin.Size = new System.Drawing.Size(1165, 618);
            this.fondoDeLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondoDeLogin.TabIndex = 0;
            this.fondoDeLogin.TabStop = false;
            this.fondoDeLogin.Click += new System.EventHandler(this.fondoDeLogin_Click);
            this.fondoDeLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fondoDeLogin_MouseDown);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Login.BorderRadius = 10;
            this.btn_Login.CheckedState.Parent = this.btn_Login;
            this.btn_Login.CustomImages.Parent = this.btn_Login;
            this.btn_Login.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Login.FillColor2 = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Login.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.HoverState.Parent = this.btn_Login;
            this.btn_Login.Location = new System.Drawing.Point(694, 474);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.ShadowDecoration.Parent = this.btn_Login;
            this.btn_Login.Size = new System.Drawing.Size(180, 45);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Iniciar sesión";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // chk_Pass
            // 
            this.chk_Pass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.chk_Pass.CheckedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.chk_Pass.CheckedState.BorderRadius = 2;
            this.chk_Pass.CheckedState.BorderThickness = 0;
            this.chk_Pass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_Pass.CheckedState.Parent = this.chk_Pass;
            this.chk_Pass.Location = new System.Drawing.Point(694, 438);
            this.chk_Pass.Name = "chk_Pass";
            this.chk_Pass.ShadowDecoration.Parent = this.chk_Pass;
            this.chk_Pass.Size = new System.Drawing.Size(20, 20);
            this.chk_Pass.TabIndex = 2;
            this.chk_Pass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_Pass.UncheckedState.BorderRadius = 2;
            this.chk_Pass.UncheckedState.BorderThickness = 0;
            this.chk_Pass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_Pass.UncheckedState.Parent = this.chk_Pass;
            this.chk_Pass.CheckedChanged += new System.EventHandler(this.guna2CustomCheckBox1_CheckedChanged);
            // 
            // txt_User
            // 
            this.txt_User.Animated = true;
            this.txt_User.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txt_User.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txt_User.BorderRadius = 10;
            this.txt_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_User.DefaultText = "";
            this.txt_User.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_User.DisabledState.Parent = this.txt_User;
            this.txt_User.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_User.FillColor = System.Drawing.Color.DimGray;
            this.txt_User.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_User.FocusedState.Parent = this.txt_User;
            this.txt_User.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.FloralWhite;
            this.txt_User.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txt_User.HoverState.Parent = this.txt_User;
            this.txt_User.Location = new System.Drawing.Point(696, 245);
            this.txt_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_User.Name = "txt_User";
            this.txt_User.PasswordChar = '\0';
            this.txt_User.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txt_User.PlaceholderText = "Introduzca aquí el nombre de usuario";
            this.txt_User.SelectedText = "";
            this.txt_User.ShadowDecoration.Parent = this.txt_User;
            this.txt_User.Size = new System.Drawing.Size(366, 49);
            this.txt_User.TabIndex = 3;
            this.txt_User.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.txt_User.Enter += new System.EventHandler(this.guna2TextBox1_Enter);
            this.txt_User.Leave += new System.EventHandler(this.guna2TextBox1_Leave);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Animated = true;
            this.txt_Pass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txt_Pass.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Pass.BorderRadius = 10;
            this.txt_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pass.DefaultText = "";
            this.txt_Pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Pass.DisabledState.Parent = this.txt_Pass;
            this.txt_Pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Pass.FillColor = System.Drawing.Color.DimGray;
            this.txt_Pass.FocusedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_Pass.FocusedState.Parent = this.txt_Pass;
            this.txt_Pass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.FloralWhite;
            this.txt_Pass.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txt_Pass.HoverState.Parent = this.txt_Pass;
            this.txt_Pass.Location = new System.Drawing.Point(694, 345);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '\0';
            this.txt_Pass.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txt_Pass.PlaceholderText = "Introduzca aquí su contraseña";
            this.txt_Pass.SelectedText = "";
            this.txt_Pass.ShadowDecoration.Parent = this.txt_Pass;
            this.txt_Pass.Size = new System.Drawing.Size(366, 49);
            this.txt_Pass.TabIndex = 4;
            this.txt_Pass.UseSystemPasswordChar = true;
            this.txt_Pass.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
            this.txt_Pass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txt_Pass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.AllowDrop = true;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(943, 425);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(200, 18);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Ha olvidado su contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelErr
            // 
            this.labelErr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErr.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErr.ForeColor = System.Drawing.Color.DarkRed;
            this.labelErr.Location = new System.Drawing.Point(694, 399);
            this.labelErr.Name = "labelErr";
            this.labelErr.Size = new System.Drawing.Size(241, 21);
            this.labelErr.TabIndex = 7;
            this.labelErr.Text = "Usuario o contraseña incorrecta";
            this.labelErr.Visible = false;
            // 
            // btnExitMain
            // 
            this.btnExitMain.ActiveImage = null;
            this.btnExitMain.AllowAnimations = true;
            this.btnExitMain.AllowBuffering = false;
            this.btnExitMain.AllowToggling = false;
            this.btnExitMain.AllowZooming = true;
            this.btnExitMain.AllowZoomingOnFocus = false;
            this.btnExitMain.BackColor = System.Drawing.Color.White;
            this.btnExitMain.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExitMain.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnExitMain.ErrorImage")));
            this.btnExitMain.FadeWhenInactive = false;
            this.btnExitMain.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnExitMain.Image = ((System.Drawing.Image)(resources.GetObject("btnExitMain.Image")));
            this.btnExitMain.ImageActive = null;
            this.btnExitMain.ImageLocation = null;
            this.btnExitMain.ImageMargin = 20;
            this.btnExitMain.ImageSize = new System.Drawing.Size(55, 55);
            this.btnExitMain.ImageZoomSize = new System.Drawing.Size(75, 75);
            this.btnExitMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnExitMain.InitialImage")));
            this.btnExitMain.Location = new System.Drawing.Point(1068, 12);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Rotation = 0;
            this.btnExitMain.ShowActiveImage = true;
            this.btnExitMain.ShowCursorChanges = true;
            this.btnExitMain.ShowImageBorders = true;
            this.btnExitMain.ShowSizeMarkers = false;
            this.btnExitMain.Size = new System.Drawing.Size(75, 75);
            this.btnExitMain.TabIndex = 8;
            this.btnExitMain.ToolTipText = "";
            this.btnExitMain.WaitOnLoad = false;
            this.btnExitMain.Zoom = 20;
            this.btnExitMain.ZoomSpeed = 10;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(959, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 615);
            this.Controls.Add(this.labelErr);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExitMain);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.chk_Pass);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.fondoDeLogin);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fondoDeLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox fondoDeLogin;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Login;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chk_Pass;
        private Guna.UI2.WinForms.Guna2TextBox txt_User;
        private Guna.UI2.WinForms.Guna2TextBox txt_Pass;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelErr;
        private Bunifu.UI.WinForms.BunifuImageButton btnExitMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

