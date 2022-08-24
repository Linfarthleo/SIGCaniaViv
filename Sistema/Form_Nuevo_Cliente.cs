using Sistema.Clases;
using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Form_Nuevo_Cliente : Form
    {
        Cliente auxeditcliente = new Cliente();
        Boolean modeditar = false;
        string validacion, aprobacion;
        public Form_Nuevo_Cliente()
        {
            InitializeComponent();
        }

        private void Form_Nuevo_Cliente_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

        public Form_Nuevo_Cliente(Cliente aux)
        {
            InitializeComponent();
            mostrarvalores(aux);
            auxeditcliente = aux;
            modeditar = true;
            lbltitulocliente.Text = "Modificar cliente";
        }

        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool ValidarLongitud()
        {

            string cedula = txtcedula.Text;
            char[] vector = cedula.ToArray();
            int sumatotal = 0;

            for (int i = 0; i < vector.Length - 1; i++)
            {
                int numero = Convert.ToInt32(vector[i].ToString());
                if ((i + 1) % 2 == 1)
                {
                    numero = Convert.ToInt32(vector[i].ToString()) * 2;
                    if (numero > 9)
                    {
                        numero = numero - 9;
                    }
                }
                sumatotal += numero;
            }
            sumatotal = 10 - (sumatotal % 10);
            if (sumatotal > 9)
            {
                validacion = "0";
            }
            else
            {
                validacion = Convert.ToString(sumatotal);
            }

            if (Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "1" ||
                Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "2" ||
                Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "3" ||
                Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "4" ||
                Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "5" ||
                Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "6" ||
                Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "7" ||
                Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "8" ||
                Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "9" ||
                Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "0" ||
                Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "1" ||
                Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "2" ||
                Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "3" ||
                Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "4" ||
                Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "5" ||
                Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "6" ||
                Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "7" ||
                Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "8" ||
                Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "9" ||
                Convert.ToString(vector[0]) == "2" && Convert.ToString(vector[1]) == "0" ||
                Convert.ToString(vector[0]) == "2" && Convert.ToString(vector[1]) == "1" ||
                Convert.ToString(vector[0]) == "2" && Convert.ToString(vector[1]) == "2" ||
                Convert.ToString(vector[0]) == "2" && Convert.ToString(vector[1]) == "3" ||
                Convert.ToString(vector[0]) == "2" && Convert.ToString(vector[1]) == "4")
            {
                if (Convert.ToString(vector[2]) == "0" || Convert.ToString(vector[2]) == "1" ||
                    Convert.ToString(vector[2]) == "2" || Convert.ToString(vector[2]) == "3" ||
                    Convert.ToString(vector[2]) == "4" || Convert.ToString(vector[2]) == "5")
                {
                    if (Convert.ToString(vector[9]) == validacion)
                    {
                        //MessageBox.Show("Cedula correcta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Cedula Incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        aprobacion = "Cedula Incorrecta";
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Cedula Incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aprobacion = "Cedula Incorrecta";
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Cedula Incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aprobacion = "Cedula Incorrecta";
                return false;
            }

        }

        private void mostrarvalores(Cliente aux)
        {
            //txtNombres.Text = aux.Nombres;
            txtNombres.Enabled = false;
            txtNombres.ReadOnly = true;
            txtNombres.Text = aux.Nombres;
            txtapellidos.Enabled = false;
            txtapellidos.ReadOnly = true;
            txtapellidos.Text = aux.Apellidos;
            txtcedula.Enabled = false;
            txtcedula.ReadOnly = true;
            txtcedula.Text = aux.Cedula;
            txtcorreo.Text = aux.Correo;
            //txttelffijo.Text = aux.Telefonofijo;
            txttelfmovil.Text = aux.Telefonomovil;
            txtdireccion.Text = aux.Direccion;
            //txtTlfnmov2.Text = aux.Telefono2;
        }


        private void btnGuardarHab_Click(object sender, EventArgs e)
        {
            if (modeditar == false)
            {
                if (txtNombres.Text == "" && txtapellidos.Text == "" && txtcedula.Text == "")
                {
                    MessageBox.Show("Debe llenar la información necesaria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Está seguro de registrar cliente", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        //Armo el objeto
                        Cliente aux = new Cliente();
                        aux.Nombres = txtNombres.Text;
                        aux.Apellidos = txtapellidos.Text;
                        aux.Cedula = txtcedula.Text;
                        aux.Telefonomovil = txttelfmovil.Text;
                        aux.Correo = txtcorreo.Text;
                        aux.Direccion = txtdireccion.Text;

                        if (email_bien_escrito(txtcorreo.Text) == false)
                        {
                            errorProvider1.SetError(txtcorreo, "Correo incorrecto – Ingrese nuevamente");
                            txtcorreo.Focus();
                            return;
                        }
                        else
                        {
                            errorProvider1.Clear();
                        }

                        if (ValidarLongitud() == false)
                        {
                            errorProvider1.SetError(txtcedula, "Cédula incorrecta – Ingrese nuevamente");
                            txtcedula.Focus();
                            return;
                        }
                        else
                        {
                            errorProvider1.Clear();
                        }
                        //Mando a guardar al cliente
                        Boolean agregado = Cliente.registrarcliente(aux);
                        if (agregado == true)
                        {
                            DialogResult result2 = MessageBox.Show("Cliente ingresado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result2 == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido ingresar al cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Está seguro de modificar al cliente", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    //Armo el objeto
                    Cliente aux = new Cliente();
                    aux.Idcliente = auxeditcliente.Idcliente;
                    aux.Nombres = auxeditcliente.Nombres;
                    aux.Apellidos = auxeditcliente.Apellidos;
                    aux.Cedula = auxeditcliente.Cedula;
                    aux.Telefonomovil = txttelfmovil.Text;
                    aux.Correo = txtcorreo.Text;
                    aux.Direccion = txtdireccion.Text;

                    if (email_bien_escrito(txtcorreo.Text) == false)
                    {
                        errorProvider1.SetError(txtcorreo, "Correo incorrecto – Ingrese nuevamente");
                        txtcorreo.Focus();
                        return;
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }

                    //Mando a guardar al cliente
                    Boolean modificado = Cliente.modificarcliente(aux);
                    if (modificado == true)
                    {
                        DialogResult result2 = MessageBox.Show("Cliente modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result2 == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido modificar al cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {
            /*if (modeditar == false)
            {
                if (txtNombres.Text == "" && txtapellidos.Text == "" && txtcedula.Text == "")
                {
                    MessageBox.Show("Debe llenar la información necesaria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Esta seguro de registrar cliente", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        //Armo el objeto
                        Cliente aux = new Cliente();
                        aux.Nombres = txtNombres.Text;
                        aux.Apellidos = txtapellidos.Text;
                        aux.Cedula = txtcedula.Text;
                        aux.Telefonomovil = txttelfmovil.Text;
                        aux.Telefonofijo = txttelffijo.Text;
                        aux.Correo = txtcorreo.Text;
                        aux.Direccion = txtdireccion.Text;

                        //Mando a guardar al cliente
                        Boolean agregado = Cliente.registrarcliente(aux);
                        if (agregado == true)
                        {
                            DialogResult result2 = MessageBox.Show("Cliente ingresado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result2 == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido ingresar al cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Esta seguro de modificar al cliente", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    //Armo el objeto
                    Cliente aux = new Cliente();
                    aux.Idcliente = auxeditcliente.Idcliente;
                    aux.Nombres = txtNombres.Text;
                    aux.Apellidos = txtapellidos.Text;
                    aux.Cedula = txtcedula.Text;
                    aux.Telefonomovil = txttelfmovil.Text;
                    aux.Telefonofijo = txttelffijo.Text;
                    aux.Correo = txtcorreo.Text;
                    aux.Direccion = txtdireccion.Text;

                    //Mando a guardar al cliente
                    Boolean modificado = Cliente.modificarcliente(aux);
                    if (modificado == true)
                    {
                        DialogResult result2 = MessageBox.Show("Cliente modificado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result2 == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido modificar al cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }*/
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombresKeyP(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
              if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtApellidosKeyP(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
              if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCedulaKeyP(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelfCel1KeyP(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelffigKeyP(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombresValidating(object sender, CancelEventArgs e)
        {
            validacioncampos(this.txtNombres);
        }

        private void validacioncampos(Guna.UI2.WinForms.Guna2TextBox auxtxt)
        {
            if (auxtxt.Text.Length == 0)
                errorProvider1.SetError(auxtxt, "Se debe ingresar un valor.");
            else
                errorProvider1.SetError(auxtxt, "");
        }

        private void txtApellidosValidating(object sender, CancelEventArgs e)
        {
            validacioncampos(this.txtapellidos);
        }

        private void txtCedulaValidating(object sender, CancelEventArgs e)
        {
            validacioncampos(this.txtcedula);
        }

        private void txtTelfCel1Validating(object sender, CancelEventArgs e)
        {
            validacioncampos(this.txttelfmovil);
        }



        private void txtDireccionValidating(object sender, CancelEventArgs e)
        {
            validacioncampos(this.txtdireccion);
        }

        private void txtCorreoValidating(object sender, CancelEventArgs e)
        {
            validacioncampos(this.txtcorreo);
        }


        private void txtTlf2KeyP(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
