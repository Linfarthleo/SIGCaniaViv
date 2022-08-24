using System;
using System.Windows.Forms;

namespace Sistema.Interfaces_Módulos
{
    public partial class AdministraciónSistema : Form
    {
        public AdministraciónSistema()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Form parametros = new Parametros();
            parametros.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Form registroAuditoria = new Auditoria();
            registroAuditoria.Show();
        }
    }
}
