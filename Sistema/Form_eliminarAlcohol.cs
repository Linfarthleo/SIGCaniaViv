using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Form_eliminarAlcohol : Form
    {
        ErrorProvider error = new ErrorProvider();
        public Form_eliminarAlcohol()
        {
            InitializeComponent();
        }

        //Para que aparezca un icono en el lugar donde no se ingresaron datos, y envia el mensaje de error
        private void validacion_Campos(Guna.UI2.WinForms.Guna2TextBox auxtxt)
        {
            if (auxtxt.Text.Length == 0)
                error.SetError(auxtxt, "Se debe ingresar un valor");
            else
                error.SetError(auxtxt, "");
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcantidadAlcohol.Text.Length == 0 || txtgradoDeAlcohol.Text.Length == 0)
            {
                DialogResult result = MessageBox.Show("Datos incompletos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbunidades.SelectedIndex == -1)
            {
                DialogResult result = MessageBox.Show("Debe seleccionar una unidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Está seguro del eliminar el producto?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Producto eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcantidadAlcohol.Text = "";
                    txtgradoDeAlcohol.Text = "";
                    txtdetalleAlcohol.Text = "";
                    cmbunidades.SelectedIndex = -1;
                    this.Close();
                }
            }
        }

        private void txtcantidadAlcohol_KeyPress(object sender, KeyPressEventArgs e)
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
            if (Char.IsLetter(e.KeyChar))
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtcantidadAlcohol_Validating(object sender, CancelEventArgs e)
        {
            validacion_Campos(this.txtcantidadAlcohol);
        }

        private void txtgradoDeAlcohol_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtgradoDeAlcohol_Validating(object sender, CancelEventArgs e)
        {
            validacion_Campos(this.txtgradoDeAlcohol);
        }

        private void Form_eliminarAlcohol_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
