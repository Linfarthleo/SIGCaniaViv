using Sistema.Clases;
using System.Windows.Forms;

namespace Sistema.Interfaces_Módulos
{
    public partial class Produccion : Form
    {
        Producto auxProducto = new Producto();
        public Produccion()
        {
            InitializeComponent();
        }

        private void Produccion_Load(object sender, System.EventArgs e)
        {
            TopMost = true;
            dtgvProductos.DataSource = Producto.listadoProductos();
        }

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {
            Form registrarFechaSiembra = new Form_registrarFechaDeSiembra();
            registrarFechaSiembra.Show();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, System.EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, System.EventArgs e)
        {

        }
        //Método para abrir la venta de produccion al momento de dar click en "produccion"
        private void btnregistrarCantAlcohol_Click(object sender, System.EventArgs e)
        {
            Form registrarCantidadAlcohol = new Form_registrarCantidadDeAlcohol();
            registrarCantidadAlcohol.Show();

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pcbagregarProducto_Click(object sender, System.EventArgs e)
        {
            Form registrarCantidadAlcohol = new Form_registrarCantidadDeAlcohol();
            registrarCantidadAlcohol.Show();
        }

        private void lblAgregar_Click(object sender, System.EventArgs e)
        {

        }

        private void lblagregarFechaSiembra_Click(object sender, System.EventArgs e)
        {
            Form registrarFechaSiembra = new Form_registrarFechaDeSiembra();
            registrarFechaSiembra.Show();
        }

        private void pcbeliminarProducto_Click(object sender, System.EventArgs e)
        {
            Form formularioIngresoDeCodigo = new Form_iDAlcoholEliminar();
            formularioIngresoDeCodigo.Show();
        }

        private void pcbeditarProducto_Click(object sender, System.EventArgs e)
        {
            Form formularioValidacionCodigo = new Form_iDAlcohol();
            formularioValidacionCodigo.Show();
        }

        private void pcbeditarFechaSiembra_Click(object sender, System.EventArgs e)
        {
            Form registrarFechaSiembra = new Form_registrarFechaDeSiembra();
            registrarFechaSiembra.Show();
        }

        private void guna2ImageButton1_Click(object sender, System.EventArgs e)
        {
            dtgvProductos.DataSource = Producto.listadoProductos();
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
