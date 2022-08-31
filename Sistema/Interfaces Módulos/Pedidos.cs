using Sistema.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema.Interfaces_Módulos
{
    public partial class Pedidos : Form
    {
        String validacion, aprobacion;
        List<Pedido> auxlistPedido = new List<Pedido>();
        Pedido auxEditPedido = new Pedido();
        Boolean modoEditarPedido = false;
        int auxidcliente = 0;
        public Pedidos()
        {
            InitializeComponent();
            auxlistPedido = Pedido.listadoPedidos();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            gdvPedidos.DataSource = auxlistPedido;
            TopMost = true;
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2GroupBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel19_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            cantPedidoComboBox.Enabled = true;

        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void gradoPedidoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            cantPedidoTextBox.Enabled = true;
        }

        private void cantPedidoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            fechaEntregaDate.Enabled = true;

        }

        private void btnrefrescarPedidos_Click(object sender, EventArgs e)
        {
            numIdentifiacionConsultaPedidoTextBox.Text = "";
            gdvPedidos.DataSource = Pedido.listadoPedidos();
        }

        private void ident1PedidoTexBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ident1PedidoTexBox.Text == string.Empty)

            {

                errorProvider1.SetError(ident1PedidoTexBox, "Por favor ingrese un número de identificación");
            }
            else

            {
                errorProvider1.SetError(ident1PedidoTexBox, "");

            }
        }

        private void ident1PedidoTexBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void buscarcliente(string cedula)
        {
            Cliente aux = Cliente.buscarcliente(cedula);
            if (aux.Idcliente == 0)
            {
                MessageBox.Show("No se ha encontrado el cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                mostrarvalores(aux);
                auxidcliente = aux.Idcliente;
            }
        }
        public void mostrarvalores(Cliente aux)
        {
            cedulaClientePedidoLabel.Text = aux.Cedula;

        }

        public bool ValidarLongitud()
        {

            string cedula = ident1PedidoTexBox.Text;
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
                       // MessageBox.Show("Cedula correcta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //aprobacion = "Cedula Correcta";
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


        private void btn_buscarClientePedidos_Click(object sender, EventArgs e)
        {
            if (ident1PedidoTexBox.Text == "")
            {
                MessageBox.Show("Debe llenar todos los espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (ValidarLongitud() == true)
                {

                

            Cliente clientped = new Cliente();
            Boolean verificador = Cliente.buscarCedulaCliente(ident1PedidoTexBox.Text);

            if (verificador == true)
            {
                clientped = Cliente.obtenerClienteDeNumId(numIdentificacion: ident1PedidoTexBox.Text);
                cedulaClientePedidoLabel.Text = clientped.Cedula;
                nombreClientePedidoLabel.Text = clientped.Nombres;
                apellidoClientePedidoLabel.Text = clientped.Apellidos;
                correoClientePedidoLabel.Text = clientped.Correo;
                celularClientePedidoLabel.Text = clientped.Telefonomovil;
                gradoPedidoComboBox.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cliente no registrado, primero registre el cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ident1PedidoTexBox.Text = "";
            }
                }
            }



        }



        private void btn_RegistrarPedidos_Click(object sender, EventArgs e)
        {
            if (modoEditarPedido == false)
            {
                DialogResult result = MessageBox.Show("¿Está seguro del registro del pedido?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Pedido aux = new Pedido();
                    TimeSpan ts = fechaEntregaDate.Value - DateTime.Now;
                    int diasParaEntrega = ts.Days + 1;
                    Boolean entregafactible = false;

                    if (cantPedidoComboBox.SelectedIndex == 1)
                    {
                        float cambio = float.Parse(cantPedidoTextBox.Text);
                        float conversion = cambio * 200;
                        if ((diasParaEntrega * 200) > conversion)
                        {
                            aux.CantidadAlcPedido = conversion;
                            entregafactible = true;
                        }
                        else
                        {
                            MessageBox.Show("Se necesitará más tiempo para la entrega", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                    else if (cantPedidoComboBox.SelectedIndex == 2)
                    {
                        float cambio = float.Parse(cantPedidoTextBox.Text);
                        float conversion = cambio * (float)3.78;
                        if ((diasParaEntrega * 200) > conversion)
                        {
                            aux.CantidadAlcPedido = conversion;
                            entregafactible = true;
                        }
                        else
                        {
                            MessageBox.Show("Se necesitará más tiempo para la entrega", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        float cambio = float.Parse(cantPedidoTextBox.Text);
                        if ((diasParaEntrega * 200) > cambio)
                        {
                            aux.CantidadAlcPedido = cambio;
                            entregafactible = true;
                        }
                        else
                        {
                            MessageBox.Show("Se necesitará más tiempo para la entrega", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }


                    if (entregafactible == true)
                    {

                        aux.FechaEntrega = fechaEntregaDate.Value;
                        aux.Abono = float.Parse(cantPedidoTextBox.Text);
                        totalPedidoLabel.Text = aux.Abono.ToString();
                        aux.NumIdentificacion = ident1PedidoTexBox.Text;

                        if (gradoPedidoComboBox.SelectedIndex == 0)
                        {
                            aux.IdProducto = 1;
                        }
                        else if (gradoPedidoComboBox.SelectedIndex == 1)
                        {
                            aux.IdProducto = 2;
                        }
                        else
                        {
                            aux.IdProducto = 3;
                        }
                        Boolean agregado = Pedido.registrarPedido(aux);
                        if (agregado == true)
                        {
                            DialogResult result2 = MessageBox.Show("Pedido registrado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ident1PedidoTexBox.Text = "";
                            cedulaClientePedidoLabel.Text = "____________________";
                            nombreClientePedidoLabel.Text = "____________________";
                            apellidoClientePedidoLabel.Text = "____________________";
                            correoClientePedidoLabel.Text = "____________________";
                            celularClientePedidoLabel.Text = "____________________";
                            totalPedidoLabel.Text = "______";
                            gradoPedidoComboBox.SelectedIndex = -1;
                            cantPedidoComboBox.SelectedIndex = -1;
                            cantPedidoTextBox.Text = "";
                            abonoTextBox.Text = "";
                            cantPedidoComboBox.Enabled = false;
                            cantPedidoTextBox.Enabled = false;
                            gradoPedidoComboBox.Enabled = false;
                            fechaEntregaDate.Enabled = false;
                            abonoTextBox.Enabled = false;

                        }
                        else
                        {
                            MessageBox.Show("No se ha podido registrar el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }


                }



            }
        }

        private void fechaEntregaDate_ValueChanged(object sender, EventArgs e)
        {
            abonoTextBox.Enabled = true;

        }

        private void numIdentifiacionConsultaPedidoTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Pedido> pedidos = Pedido.buscarPedidos(numIdentifiacionConsultaPedidoTextBox.Text);
            auxlistPedido = pedidos;
            gdvPedidos.DataSource = pedidos;
        }

        private void estadoPedidoCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_CancelarPedidos_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de cancelar el pedido?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                ident1PedidoTexBox.Text = "";
                cedulaClientePedidoLabel.Text = "____________________";
                nombreClientePedidoLabel.Text = "____________________";
                apellidoClientePedidoLabel.Text = "____________________";
                correoClientePedidoLabel.Text = "____________________";
                celularClientePedidoLabel.Text = "____________________";
                totalPedidoLabel.Text = "______";
                gradoPedidoComboBox.SelectedIndex = -1;
                cantPedidoComboBox.SelectedIndex = -1;
                cantPedidoTextBox.Text = "";
                abonoTextBox.Text = "";
                cantPedidoComboBox.Enabled = false;
                cantPedidoTextBox.Enabled = false;
                gradoPedidoComboBox.Enabled = false;
                fechaEntregaDate.Enabled = false;
                abonoTextBox.Enabled = false;

            }
        }

        private void totalPedidoLabel_Click(object sender, EventArgs e)
        {

        }

        private void Pedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btn_ActualizarPedido_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de cambiar el estado del pedido a entregado?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {


            }
            else
            {
                MessageBox.Show("Seleccione el pedido a editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}
