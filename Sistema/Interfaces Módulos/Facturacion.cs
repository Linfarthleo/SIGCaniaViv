using Sistema.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema.Interfaces_Módulos
{
    public partial class Facturacion : Form
    {
        List<NotaVenta> auxlistNota = new List<NotaVenta>();
        NotaVenta auxNotaVenta = new NotaVenta();
        public Facturacion()
        {
            InitializeComponent();
            auxlistNota = NotaVenta.listadoNotas();
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

        private void Facturacion_Load(object sender, EventArgs e)
        {
            dgvNotasDeVenta.DataSource = auxlistNota;
            TopMost = true;

        }



        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (auxNotaVenta.IdNota != 0)

            {
                Factura ventasfac = new Factura();

                Cliente clienteFacturado = Cliente.obtenerClienteDeNumId(auxNotaVenta.NumIdentificacion);
                Venta ventaFacturada = Venta.buscarVenta(auxNotaVenta.IdVenta);
                ventasfac.Date = auxNotaVenta.Fecha.ToString();
                ventasfac.Nombres = clienteFacturado.Nombres + " " +clienteFacturado.Apellidos;
                ventasfac.Identificacion = auxNotaVenta.NumIdentificacion;
                ventasfac.IDFact = auxNotaVenta.IdNota.ToString();
                ventasfac.Section = ventaFacturada.FormaPago;
                ventasfac.Telefono = clienteFacturado.Telefonomovil;
                ventasfac.Correo = clienteFacturado.Correo;
                ventasfac.CantAlcohol = ventaFacturada.CantAlcoholVendida.ToString();
                ventasfac.PrecioTotal = "$ "+ventaFacturada.ValorTotal.ToString();
                ventasfac.Estado = auxNotaVenta.Estado;
                ventasfac.Medida="Litros";
                if (ventaFacturada.IdProducto == 1)
                {
                    ventasfac.GradoAlcohol = "58°";
                    ventasfac.PrecioUnitario = "$ 1";
                }
                else if (ventaFacturada.IdProducto == 2)
                {
                    ventasfac.GradoAlcohol = "65°";
                    ventasfac.PrecioUnitario = "$ 0.9";
                }
                else
                {
                    ventasfac.GradoAlcohol = "70°";
                    ventasfac.PrecioUnitario = "$ 1.3";
                }

                ventasfac.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una nota de venta a imprimir", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Está seguro de anular la nota de venta?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (auxNotaVenta.IdNota != 0)

                {
                    NotaVenta.anularFactura(auxNotaVenta);
                    int a = Venta.consultarIdProductoventa(idNotaDeVentaTextBox.Text);
                    float b = Venta.consultarCantidadDeAlcoholDeVenta(idNotaDeVentaTextBox.Text);
                    float c = Producto.consultarCantidadDeProductoAEditar(a.ToString());
                    Producto.actualizarCantidad(a, (c + b));
                    dgvNotasDeVenta.DataSource = NotaVenta.listadoNotas();
                }
                else
                {
                    MessageBox.Show("Seleccione una nota de venta a anular", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            else {
                MessageBox.Show("No se ha podido eliminar la nota de venta", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            }

        private void btn_buscarFactura_Click(object sender, EventArgs e)
        {
            btnImprimir.Enabled = true;
        }

        private void btnrefrescarFacturas_Click(object sender, EventArgs e)
        {
            idNotaDeVentaTextBox.Text = "";
            numIdentificacionClienteFacturaTextBox.Text = "";
        }

        private void numIdentificacionClienteFacturaTextBox_TextChanged(object sender, EventArgs e)
        {
            List<NotaVenta> notas = NotaVenta.buscarNotasPorIdentificacion(numIdentificacionClienteFacturaTextBox.Text);
            auxlistNota = notas;
            dgvNotasDeVenta.DataSource = notas;
        }

        private void btnrefrescarFacturas_Click_1(object sender, EventArgs e)
        {
            numIdentificacionClienteFacturaTextBox.Text = "";
            idNotaDeVentaTextBox.Text = "";
            dgvNotasDeVenta.DataSource = NotaVenta.listadoNotas();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void idFacturaTextBox_TextChanged(object sender, EventArgs e)
        {
            List<NotaVenta> notas = NotaVenta.buscarNotas(idNotaDeVentaTextBox.Text);
            auxlistNota = notas;
            dgvNotasDeVenta.DataSource = notas;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Facturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void dgvNotasDeVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                auxNotaVenta = auxlistNota[e.RowIndex];
            }
            catch (Exception ex) { }
        }
    }
}