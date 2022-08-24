using Sistema.Clases;
using System;
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
                Producto aux = new Producto();
                Boolean verificacion = Producto.buscarIDProducto(txtcodigoProducto.Text);
                if (verificacion == true)
                {
                    aux = Producto.obtenerProductoDesdeId(txtcodigoProducto.Text);
                    Form formularioEdicionDeAlcohol = new Form_editarCantidadAlcohol(aux);
                    formularioEdicionDeAlcohol.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcodigoProducto.Text = "";
                }


            }

        }

        private void Form_iDAlcohol_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
