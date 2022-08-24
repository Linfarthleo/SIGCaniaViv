using Sistema.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;




namespace Sistema.Interfaces_Módulos
{
    public partial class Clientes : Form
    {
        List<Cliente> auxlistcliente = new List<Cliente>();
        Cliente auxeditcliente = new Cliente();
        public Clientes()
        {
            InitializeComponent();
            auxlistcliente = Cliente.listadoclientes();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = auxlistcliente;
            TopMost = true;

        }

        private void btnnuevocliente_Click(object sender, EventArgs e)
        {
            Form formularioNuevoCli = new Form_Nuevo_Cliente();
            formularioNuevoCli.Show();
        }

        private void btneditarcliente_Click(object sender, EventArgs e)
        {
            if (auxeditcliente.Idcliente != 0)
            {
                Form_Nuevo_Cliente aux = new Form_Nuevo_Cliente(auxeditcliente);
                aux.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente a editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                auxeditcliente = auxlistcliente[e.RowIndex];
            }
            catch (Exception ex) { }
        }*/

        private void btlelimnarcliente_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar el cliente?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Boolean eliminado = Cliente.eliminarcliente(auxeditcliente);
                if (eliminado == true)
                {
                    DialogResult result2 = MessageBox.Show("Cliente eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    {
                        guna2DataGridView1.DataSource = Cliente.listadoclientes();
                    }
                }
                else
                {
                    MessageBox.Show("El cliente no ha sido eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buscarClientes_TextChanged(object sender, EventArgs e)
        {
            List<Cliente> clientes = Cliente.buscarclientes(buscarClientes.Text);
            auxlistcliente = clientes;
            guna2DataGridView1.DataSource = clientes;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = Cliente.listadoclientes();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                auxeditcliente = auxlistcliente[e.RowIndex];
            }
            catch (Exception ex) { }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
