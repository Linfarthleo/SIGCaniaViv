using Sistema.Clases;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Sistema
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int laparam);
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void fondoDeLogin_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            if (txt_User.Text == "USUARIO")
            {
                txt_User.Text = "";
                txt_User.ForeColor = Color.LightGray;
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (txt_User.Text == "")
            {
                txt_User.Text = "USUARIO";
                txt_User.ForeColor = Color.DimGray;

            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "CONTRASENA")
            {
                txt_Pass.Text = "";
                txt_Pass.ForeColor = Color.LightGray;
                txt_Pass.UseSystemPasswordChar = true;

            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "")
            {
                txt_Pass.Text = "CONTRASENA";
                txt_Pass.ForeColor = Color.DimGray;
                txt_Pass.UseSystemPasswordChar = false;
            }

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Pass.Checked)
            {
                txt_Pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Pass.UseSystemPasswordChar = true;
            }
        }

        private void fondoDeLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_User.Text == String.Empty || txt_Pass.Text == String.Empty)
            {
                labelErr.Visible = true;
                txt_Pass.Clear();
            }
            else
            {
                Administrador admin = Administrador.infoadmin(txt_User.Text, txt_Pass.Text);

                if (admin != null)
                {
                    labelErr.Visible = false;
                    Menu menu = new Menu();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    labelErr.Visible = true;
                    txt_Pass.Clear();
                }


            }






        }

        private void labelErr_Click(object sender, EventArgs e)
        {

        }

        private void txt_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txt_User.Text == String.Empty || txt_Pass.Text == String.Empty)
                {
                    labelErr.Visible = true;
                    txt_Pass.Clear();
                }
                else
                {
                    Administrador admin = Administrador.infoadmin(txt_User.Text, txt_Pass.Text);

                    if (admin != null)
                    {
                        labelErr.Visible = false;
                        Menu menu = new Menu();
                        this.Hide();
                        menu.Show();
                    }
                    else
                    {
                        labelErr.Visible = true;
                        txt_Pass.Clear();
                    }
                }
            }
        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


