using Sistema.Clases;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Form_registrarCantidadDeAlcohol : Form
    {
        Producto auxAgregProducto = new Producto();
        Boolean modeditar = false;
        ErrorProvider error = new ErrorProvider();
        public Form_registrarCantidadDeAlcohol()
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



        private void Form_registrarCantidadDeAlcohol_Load(object sender, EventArgs e)
        {
            TopMost = true;
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
                    Producto aux = new Producto();
                    aux.CantidadAlcohol = float.Parse(txtcantidadAlcohol.Text);
                    aux.GradosAlcohol = Convert.ToInt32(txtgradoDeAlcohol.Text);
                    aux.DetalleProducto = txtdetalleAlcohol.Text;


                    Boolean agregado = Producto.registrarProducto(aux);
                    if (agregado == true)
                    {
                        DialogResult result2 = MessageBox.Show("Cantidad de Alcohol registrada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcantidadAlcohol.Text = "";
                        txtgradoDeAlcohol.Text = "";
                        txtdetalleAlcohol.Text = "";
                        cmbunidades.SelectedIndex = -1;
                        if (result2 == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido registrar la cantidad de alcohol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }



        private void cmbunidades_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void txtdetalleAlcohol_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbregistroDeLaCantidadAlcohol_Click(object sender, EventArgs e)
        {

        }

        private void lbltituloRegistrarCantidadAlcohol_Click(object sender, EventArgs e)
        {

        }
    }
}
