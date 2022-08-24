using System;
using System.Windows.Forms;

namespace Sistema.Interfaces_Módulos
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Form nuevoUsuario = new Usuario();
            nuevoUsuario.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Form listaUsuarios = new ListaUsuarios();
            listaUsuarios.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Form herramientasSistema = new AdministraciónSistema();
            herramientasSistema.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
