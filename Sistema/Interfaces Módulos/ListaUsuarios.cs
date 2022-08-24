using Sistema.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema.Interfaces_Módulos
{
    public partial class ListaUsuarios : Form
    {
        List<UsuarioAdmin> auxlistusuario = new List<UsuarioAdmin>();
        UsuarioAdmin auxeditusuario = new UsuarioAdmin();
        public ListaUsuarios()
        {
            InitializeComponent();
            auxlistusuario = UsuarioAdmin.usuarioAdmins();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void guna2TextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = auxlistusuario;
            TopMost = true;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            List<UsuarioAdmin> usuarios = UsuarioAdmin.buscarusuarioadmin(guna2TextBox1.Text);
            auxlistusuario = usuarios;
            guna2DataGridView1.DataSource = usuarios;
        }
    }
}
