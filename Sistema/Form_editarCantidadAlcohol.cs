using Sistema.Clases;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Form_editarCantidadAlcohol : Form
    {
        ErrorProvider error = new ErrorProvider();
        public Form_editarCantidadAlcohol()
        {
            InitializeComponent();
        }

        public Form_editarCantidadAlcohol(Producto aux)
        {
            InitializeComponent();
            mostrarvalores(aux);
        }


        private void mostrarvalores(Producto aux)
        {
            txtcantidadAlcohol.Text = Convert.ToString(aux.CantidadAlcohol);
            txtgradoDeAlcohol.Text = Convert.ToString(aux.GradosAlcohol);
            txtdetalleAlcohol.Text = aux.DetalleProducto;

        }


        //Para que aparezca un icono en el lugar donde no se ingresaron datos, y envia el mensaje de error
        private void validacion_Campos(Guna.UI2.WinForms.Guna2TextBox auxtxt)
        {
            if (auxtxt.Text.Length == 0)
                error.SetError(auxtxt, "Se debe ingresar un valor");
            else
                error.SetError(auxtxt, "");
        }

        private void btnguardar_Click(object sender, EventArgs e)
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
                DialogResult result = MessageBox.Show("Está seguro del registro?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Dato del producto modificado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcantidadAlcohol.Text = "";
                    txtgradoDeAlcohol.Text = "";
                    txtdetalleAlcohol.Text = "";
                    cmbunidades.SelectedIndex = -1;
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

        private void grbrmodificacionDeLaCantidadAlcohol_Click(object sender, EventArgs e)
        {

        }

        private void lbltituloEditarCantidadAlcohol_Click(object sender, EventArgs e)
        {

        }

        private void Form_editarCantidadAlcohol_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
