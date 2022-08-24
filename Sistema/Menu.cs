using Sistema.Interfaces_Módulos;
using System;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            submenuVentas.Visible = false;
            submenuProduccion.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form moduloClientes = new Clientes();
            moduloClientes.Show();
            submenuVentas.Visible = false;
            submenuProduccion.Visible = false;
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            submenuVentas.Visible = true;
            submenuProduccion.Visible = false;
        }

        private void btnproduccion_Click(object sender, EventArgs e)
        {
            Form produccion = new Produccion();
            produccion.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            submenuVentas.Visible = false;
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnVenta_Click_1(object sender, EventArgs e)
        {
            Form moduloVentas = new Ventas();
            moduloVentas.Show();
        }

        private void btnProduccion_Click_1(object sender, EventArgs e)
        {



            submenuVentas.Visible = false;
            submenuProduccion.Visible = true;


        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            Form moduloFacturacion = new Facturacion();
            moduloFacturacion.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Form moduloPedidos = new Pedidos();
            moduloPedidos.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Form moduloProduccion = new Produccion();
            moduloProduccion.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Form moduloEmpleados = new Empleados();
            moduloEmpleados.Show();

            submenuVentas.Visible = false;
            submenuProduccion.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            submenuVentas.Visible = false;
            submenuProduccion.Visible = false;
            Form moduloAdministracion = new Administracion();
            moduloAdministracion.Show();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
