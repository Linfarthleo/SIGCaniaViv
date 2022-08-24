using MySql.Data.MySqlClient;
using System;


namespace Sistema.Clases
{
    public class ConeccionBD
    {
        public MySqlConnection coneccion;
        private string stringConeccion = "Server=127.0.0.1; Port=3306; Database=cañ_viv; Uid=root; Pwd=root;";
        public ConeccionBD()
        {
            inicializar();
        }
        private void inicializar()
        {
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
            coneccion = new MySqlConnection(stringConeccion);
        }
        public bool abrirConeccion()
        {
            try
            {
                coneccion.Open();

                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("No abri la conexion");
            }
            return false;
        }
        public bool cerrarConeccion()
        {
            try
            {
                coneccion.Close();
                return true;
            }
            catch (MySqlException ex)
            {

            }
            return false;
        }
    }
}