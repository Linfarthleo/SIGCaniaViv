using System;
using System.Windows.Forms;

namespace Sistema.Interfaces_Módulos
{
    public partial class Auditoria : Form
    {
        public Auditoria()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Auditoria_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
