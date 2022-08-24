using Sistema.Clases;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistema.Interfaces_Módulos
{
    public partial class Usuario : Form
    {
        public string UseSystemPasswordChar { get; private set; }

        UsuarioAdmin auxedituser = new UsuarioAdmin();
        Boolean modeditar = false;

        public Usuario()
        {
            InitializeComponent();
            modeditar = true;

        }

        /*public Usuario(UsuarioAdmin aux)
        {
            mostrarvalores(aux);
            auxedituser = aux;
            modeditar = true;
        }*/

        private void mostrarvalores(UsuarioAdmin aux)
        {
            guna2TextBox1.Text = aux.Nombres;
            guna2TextBox2.Text = aux.Apellidos;
            guna2TextBox3.Text = aux.Cedula;
            guna2TextBox4.Text = aux.Nombreusuario;
            guna2TextBox5.Text = aux.Contrasena;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == string.Empty || guna2TextBox2.Text == string.Empty ||
                guna2TextBox3.Text == string.Empty || guna2TextBox4.Text == string.Empty ||
                guna2TextBox5.Text == string.Empty || guna2TextBox6.Text == string.Empty)
            {
                MessageBox.Show("Hay campos sin llenar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (guna2TextBox5.Text != guna2TextBox6.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Esta seguro que desea registrar el nuevo usuario?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (resultado)
                {
                    case DialogResult.Yes:
                        {
                            MessageBox.Show("Usuario registrado exitosamente", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case DialogResult.No:
                        {
                            break;
                        }
                }

            }

            if (modeditar == false)
            {
                if (guna2TextBox1.Text == "" && guna2TextBox2.Text == "" && guna2TextBox3.Text == "" && guna2TextBox4.Text == "" && guna2TextBox5.Text == "")
                {
                    MessageBox.Show("Debe llenar la información necesaria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Esta seguro de registrar usuario", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        //Armo el objeto
                        UsuarioAdmin aux = new UsuarioAdmin();
                        aux.Nombres = guna2TextBox1.Text;
                        aux.Apellidos = guna2TextBox2.Text;
                        aux.Cedula = guna2TextBox3.Text;
                        aux.Nombreusuario = guna2TextBox4.Text;
                        aux.Contrasena = guna2TextBox5.Text;

                        //Mando a guardar al cliente
                        Boolean agregado = UsuarioAdmin.registraruser(aux);
                        if (agregado == true)
                        {
                            DialogResult result2 = MessageBox.Show("Usuario ingresado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result2 == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido registrar al Usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    UsuarioAdmin aux = new UsuarioAdmin();
                    aux.Nombres = guna2TextBox1.Text;
                    aux.Apellidos = guna2TextBox2.Text;
                    aux.Cedula = guna2TextBox3.Text;
                    aux.Nombreusuario = guna2TextBox4.Text;
                    aux.Contrasena = guna2TextBox5.Text;

                    //Mando a guardar al cliente
                    Boolean modificado = UsuarioAdmin.registraruser(aux);
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
            }

        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            //solo letras
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
               if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            //obligar solo letras
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
               if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == Convert.ToChar(Keys.Space);
        }

        private void guna2TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            // guna2TextBox5.Text = UseSystemPasswordChar;
        }

        private void guna2TextBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == Convert.ToChar(Keys.Space);
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == Convert.ToChar(Keys.Space);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (guna2TextBox1.Text == string.Empty)

            {

                errorProvider1.SetError(guna2TextBox1, "Por favor ingrese sus nombres");

                errorProvider2.SetError(guna2TextBox1, "");

            }
            else

            {

                errorProvider1.SetError(guna2TextBox1, "");

                errorProvider2.SetError(guna2TextBox1, "Correcto");

            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (guna2TextBox2.Text == string.Empty)

            {

                errorProvider1.SetError(guna2TextBox2, "Por favor ingrese sus apellidos");

                errorProvider2.SetError(guna2TextBox2, "");

            }
            else

            {

                errorProvider1.SetError(guna2TextBox2, "");

                errorProvider2.SetError(guna2TextBox2, "Correcto");

            }
        }

        private void guna2TextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (guna2TextBox3.Text == string.Empty)

            {

                errorProvider1.SetError(guna2TextBox3, "Por favor ingrese su cédula");

                errorProvider2.SetError(guna2TextBox3, "");

            }
            else

            {

                errorProvider1.SetError(guna2TextBox3, "");

                errorProvider2.SetError(guna2TextBox3, "Correcto");

            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_Validating(object sender, CancelEventArgs e)
        {
            if (guna2TextBox4.Text == string.Empty)

            {

                errorProvider1.SetError(guna2TextBox4, "Por favor ingrese un nombre de usuario");

                errorProvider2.SetError(guna2TextBox4, "");

            }
            else

            {

                errorProvider1.SetError(guna2TextBox4, "");

                errorProvider2.SetError(guna2TextBox4, "Correcto");

            }
        }

        private void guna2TextBox5_Validating(object sender, CancelEventArgs e)
        {
            if (guna2TextBox5.Text == string.Empty)

            {

                errorProvider1.SetError(guna2TextBox5, "Por favor ingrese una contraseña");

                errorProvider2.SetError(guna2TextBox5, "");

            }
            else

            {

                errorProvider1.SetError(guna2TextBox5, "");

                errorProvider2.SetError(guna2TextBox5, "Correcto");

            }
        }

        private void guna2TextBox6_Validating(object sender, CancelEventArgs e)
        {
            if (guna2TextBox6.Text == string.Empty)

            {

                errorProvider1.SetError(guna2TextBox6, "Por favor vuelva a escribir la contraseña");

                errorProvider2.SetError(guna2TextBox6, "");

            }
            else

            {

                errorProvider1.SetError(guna2TextBox6, "");

                errorProvider2.SetError(guna2TextBox6, "Correcto");

            }

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
