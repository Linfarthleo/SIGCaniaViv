using Sistema.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema.Interfaces_Módulos
{
    public partial class Ventas : Form
    {

        List<Venta> auxlistVenta = new List<Venta>();
        private string validacion;
        private string aprobacion;

        public Ventas()
        {
            InitializeComponent();
            auxlistVenta = Venta.listadoVentas();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            formaDePagoComboBox.Enabled = true;
        }

        private void guna2HtmlLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel18_Click(object sender, EventArgs e)
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

        private void textBoxCantVenta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = auxlistVenta;
            TopMost = true;
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            numeroIdentificacion2TextBox.Text = "";
            dgvVentas.DataSource = Venta.listadoVentas();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            List<Venta> ventas = Venta.buscarVentas(numeroIdentificacion2TextBox.Text);
            auxlistVenta = ventas;
            dgvVentas.DataSource = ventas;
        }

        private void num_Identificacion1Ventas_TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void consumidorFinalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            num_Identificacion1Ventas_TextBox.Enabled = false;

            gradoVentaComboBox.Enabled = true;

            btn_buscarClienteVentas.Enabled = false;
            cedulaClienteVentaLabel.Text = "9999999999";
            celuClienteVentasLabel.Text = "9999999999";
            num_Identificacion1Ventas_TextBox.Text = "9999999999";
            nombreClienteVentasLabel.Text = "Consumidor Final";
            apellidoClienteVentasLabel.Text = "----------------";
            correoClienteVentasLabel.Text = "----------------";
            celuClienteVentasLabel.Text = "9999999999";

        }

        private void ingresoClienteVentaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            num_Identificacion1Ventas_TextBox.Enabled = true;
            btn_buscarClienteVentas.Enabled = true;
            num_Identificacion1Ventas_TextBox.Text = "";
            cedulaClienteVentaLabel.Text = "____________________";
            nombreClienteVentasLabel.Text = "____________________";
            apellidoClienteVentasLabel.Text = "____________________";
            correoClienteVentasLabel.Text = "____________________";
            celuClienteVentasLabel.Text = "____________________";
            gradoVentaComboBox.Enabled = false;
        }

        private void numeroIdentificacion2TextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        public bool ValidarLongitud()
        {

            string cedula = num_Identificacion1Ventas_TextBox.Text;
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
        private void btn_buscarClienteVentas_Click(object sender, EventArgs e)
        {
            if (num_Identificacion1Ventas_TextBox.Text == "")
            {
                MessageBox.Show("Debe llenar todos los espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (ValidarLongitud() == true)
                {
                    Cliente clientped = new Cliente();

                    Boolean verificador = Cliente.buscarCedulaCliente(num_Identificacion1Ventas_TextBox.Text);

                    if (verificador == true)
                    {
                        clientped = Cliente.obtenerClienteDeNumId(numIdentificacion: num_Identificacion1Ventas_TextBox.Text);
                        cedulaClienteVentaLabel.Text = clientped.Cedula;
                        nombreClienteVentasLabel.Text = clientped.Nombres;
                        apellidoClienteVentasLabel.Text = clientped.Apellidos;
                        correoClienteVentasLabel.Text = clientped.Correo;
                        celuClienteVentasLabel.Text = clientped.Telefonomovil;
                        gradoVentaComboBox.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cliente no registrado, primero registre el cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        num_Identificacion1Ventas_TextBox.Text = "";
                    }
                }
            }

        }

        private void gradoVentaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBoxCantVenta.Enabled = true;
        }

        private void textBoxCantVenta_TextChanged(object sender, EventArgs e)
        {
            cantVentaComboBox.Enabled = true;

        }

        private void cantVentaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            formaDePagoComboBox.Enabled = true;

        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_CancelarVenta_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de cancelar la venta?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                num_Identificacion1Ventas_TextBox.Text = "";
                cedulaClienteVentaLabel.Text = "____________________";
                nombreClienteVentasLabel.Text = "____________________";
                apellidoClienteVentasLabel.Text = "____________________";
                correoClienteVentasLabel.Text = "____________________";
                celuClienteVentasLabel.Text = "____________________";
                totalClienteVentasLabel.Text = "_________";
                gradoVentaComboBox.SelectedIndex = -1;
                cantVentaComboBox.SelectedIndex = -1;
                textBoxCantVenta.Text = "";
                formaDePagoComboBox.SelectedIndex = -1;
                ingresoClienteVentaRadioButton.Checked = false;
                btn_buscarClienteVentas.Enabled = false;
                consumidorFinalRadioButton.Checked = false;
                num_Identificacion1Ventas_TextBox.Enabled = false;
                cantVentaComboBox.Enabled = false;
                formaDePagoComboBox.Enabled = false;
                textBoxCantVenta.Enabled = false;
                gradoVentaComboBox.Enabled = false;
            }
        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Está seguro del registro de la venta?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Venta auxV = new Venta();
                Boolean cantEsSuficiente = false;

                if (cantVentaComboBox.SelectedIndex == 0)
                {
                    float cambio = float.Parse(textBoxCantVenta.Text);

                    if (gradoVentaComboBox.SelectedIndex == 0)
                    {
                        if (Producto.consultarCantidadDeProductoAEditar("1") > cambio)
                        {
                            auxV.CantAlcoholVendida = cambio;
                            auxV.ValorTotal = cambio * 1;
                            totalClienteVentasLabel.Text = auxV.ValorTotal.ToString();
                            auxV.IdProducto = 1;
                            cantEsSuficiente = true;
                            Producto.actualizarCantidad(1, (Producto.consultarCantidadDeProductoAEditar("1") - cambio));
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente cantidad de alcohol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    if (gradoVentaComboBox.SelectedIndex == 1)
                    {
                        if (Producto.consultarCantidadDeProductoAEditar("2") > cambio)
                        {
                            auxV.CantAlcoholVendida = cambio;
                            auxV.ValorTotal = (float)(cambio * 0.9);
                            totalClienteVentasLabel.Text = auxV.ValorTotal.ToString();
                            auxV.IdProducto = 2;
                            cantEsSuficiente = true;
                            Producto.actualizarCantidad(2, (Producto.consultarCantidadDeProductoAEditar("2") - cambio));
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente cantidad de alcohol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    if (gradoVentaComboBox.SelectedIndex == 2)
                    {
                        if (Producto.consultarCantidadDeProductoAEditar("3") > cambio)
                        {
                            auxV.CantAlcoholVendida = cambio;
                            auxV.ValorTotal = (float)(cambio * 1.3);
                            totalClienteVentasLabel.Text = auxV.ValorTotal.ToString();
                            auxV.IdProducto = 3;
                            cantEsSuficiente = true;
                            Producto.actualizarCantidad(3, (Producto.consultarCantidadDeProductoAEditar("3") - cambio));
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente cantidad de alcohol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }

                if (cantVentaComboBox.SelectedIndex == 1)
                {
                    float cambio = float.Parse(textBoxCantVenta.Text);
                    float conversion = cambio * 200;

                    if (gradoVentaComboBox.SelectedIndex == 0)
                    {
                        if (Producto.consultarCantidadDeProductoAEditar("1") > conversion)
                        {
                            auxV.CantAlcoholVendida = conversion;
                            auxV.ValorTotal = conversion * 1;

                            totalClienteVentasLabel.Text = auxV.ValorTotal.ToString();
                            auxV.IdProducto = 1;

                            cantEsSuficiente = true;

                            Producto.actualizarCantidad(1, (Producto.consultarCantidadDeProductoAEditar("1") - conversion));
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente cantidad de alcohol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    if (gradoVentaComboBox.SelectedIndex == 1)
                    {
                        if (Producto.consultarCantidadDeProductoAEditar("2") > conversion)
                        {
                            auxV.CantAlcoholVendida = conversion;
                            auxV.ValorTotal = (float)(conversion * 0.9);
                            totalClienteVentasLabel.Text = auxV.ValorTotal.ToString();
                            auxV.IdProducto = 2;
                            cantEsSuficiente = true;

                            Producto.actualizarCantidad(2, (Producto.consultarCantidadDeProductoAEditar("2") - conversion));
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente cantidad de alcohol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    if (gradoVentaComboBox.SelectedIndex == 2)
                    {
                        if (Producto.consultarCantidadDeProductoAEditar("3") > conversion)
                        {
                            auxV.CantAlcoholVendida = conversion;
                            auxV.ValorTotal = (float)(conversion * 1.3);
                            totalClienteVentasLabel.Text = auxV.ValorTotal.ToString();
                            auxV.IdProducto = 3;
                            cantEsSuficiente = true;

                            Producto.actualizarCantidad(3, (Producto.consultarCantidadDeProductoAEditar("3") - conversion));
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente cantidad de alcohol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }

                if (cantVentaComboBox.SelectedIndex == 2)
                {
                    float cambio = float.Parse(textBoxCantVenta.Text);
                    float conversion = cambio * (float)3.78;

                    if (gradoVentaComboBox.SelectedIndex == 0)
                    {
                        if (Producto.consultarCantidadDeProductoAEditar("1") > conversion)
                        {
                            auxV.CantAlcoholVendida = conversion;
                            auxV.ValorTotal = conversion * 1;
                            totalClienteVentasLabel.Text = auxV.ValorTotal.ToString();
                            auxV.IdProducto = 1;
                            cantEsSuficiente = true;

                            Producto.actualizarCantidad(1, (Producto.consultarCantidadDeProductoAEditar("1") - conversion));
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente cantidad de alcohol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    if (gradoVentaComboBox.SelectedIndex == 1)
                    {
                        if (Producto.consultarCantidadDeProductoAEditar("2") > conversion)
                        {
                            auxV.CantAlcoholVendida = conversion;
                            auxV.ValorTotal = (float)(conversion * 0.9);
                            totalClienteVentasLabel.Text = auxV.ValorTotal.ToString();
                            auxV.IdProducto = 2;
                            cantEsSuficiente = true;

                            Producto.actualizarCantidad(2, (Producto.consultarCantidadDeProductoAEditar("2") - conversion));
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente cantidad de alcohol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    if (gradoVentaComboBox.SelectedIndex == 2)
                    {
                        if (Producto.consultarCantidadDeProductoAEditar("3") > conversion)
                        {
                            auxV.CantAlcoholVendida = conversion;
                            auxV.ValorTotal = (float)(conversion * 1.3);
                            totalClienteVentasLabel.Text = auxV.ValorTotal.ToString();
                            auxV.IdProducto = 3;
                            cantEsSuficiente = true;
                            Producto.actualizarCantidad(3, (Producto.consultarCantidadDeProductoAEditar("3") - conversion));
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente cantidad de alcohol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }

                }


                if (cantEsSuficiente == true)
                {
                    if (formaDePagoComboBox.SelectedIndex == 0)
                    {
                        auxV.FormaPago = "Efectivo";
                    }
                    else
                    {
                        auxV.FormaPago = "CACPECO";
                    }
                    auxV.NumIdentificacion = num_Identificacion1Ventas_TextBox.Text;

                    Boolean agregadoV = Venta.registrarVenta(auxV);

                    NotaVenta auxN = new NotaVenta();
                    auxN.NumIdentificacion = num_Identificacion1Ventas_TextBox.Text;
                    auxN.Estado = "Emitida";
                    auxN.IdVenta = Venta.buscarUltimaVenta();

                    Boolean agregadoN = NotaVenta.emitirNota(auxN);

                    if (agregadoN == true)
                    {
                        if (agregadoV == true)
                        {
                            DialogResult result3 = MessageBox.Show("Venta registrada exitosamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            num_Identificacion1Ventas_TextBox.Text = "";
                            cedulaClienteVentaLabel.Text = "____________________";
                            nombreClienteVentasLabel.Text = "____________________";
                            apellidoClienteVentasLabel.Text = "____________________";
                            correoClienteVentasLabel.Text = "____________________";
                            celuClienteVentasLabel.Text = "____________________";
                            totalClienteVentasLabel.Text = "_________";
                            gradoVentaComboBox.SelectedIndex = -1;
                            cantVentaComboBox.SelectedIndex = -1;
                            textBoxCantVenta.Text = "";
                            formaDePagoComboBox.SelectedIndex = -1;
                            ingresoClienteVentaRadioButton.Checked = false;
                            btn_buscarClienteVentas.Enabled = false;
                            consumidorFinalRadioButton.Checked = false;
                            num_Identificacion1Ventas_TextBox.Enabled = false;
                            cantVentaComboBox.Enabled = false;
                            formaDePagoComboBox.Enabled = false;
                            textBoxCantVenta.Enabled = false;
                            gradoVentaComboBox.Enabled = false;

                        }
                        else
                        {
                            MessageBox.Show("No ha sido posible registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }
    }
}
