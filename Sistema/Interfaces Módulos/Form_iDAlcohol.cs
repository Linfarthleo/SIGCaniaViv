using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Form_iDAlcohol : Form
    {
        public Form_iDAlcohol()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtcodigoProducto.Text.Length == 0)
            {
                DialogResult result = MessageBox.Show("Debe ingresar el código del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //añadir otro if para validar los datos
                Form formularioEdicionDeAlcohol = new Form_editarCantidadAlcohol();
                formularioEdicionDeAlcohol.Show();
                this.Close();
            }

        }
    }
}
