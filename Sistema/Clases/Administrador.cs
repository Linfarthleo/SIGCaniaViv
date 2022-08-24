using MySql.Data.MySqlClient;
using System;


namespace Sistema.Clases
{
    public class Administrador
    {
        private int idadministrador;
        private String nombres;
        private String apellidos;
        private String nombreusuario;
        private String contrasena;
        private int cedula;

        //----------------------------------- METODOS GETTERS Y SETTERS -----------------------------------
        public int Idadministrador { get => idadministrador; set => idadministrador = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int Cedula { get => cedula; set => cedula = value; }







        //----------------------------------- METODOS FUNCIONALES ------------------------------------------

        //--------------------------------------------------------------------------------------------------
        //---------------------------------Verificacion de administrador------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static Boolean loginadmin(string auxnombreusuario, string auxcontrasena)
        {
            ConeccionBD coneccion = new ConeccionBD();
            string query = "select * from administrador where nombreUsuario=@nombreUsuario and contrasena=@contrasena";

            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@nombreUsuario", auxnombreusuario);
                command.Parameters.AddWithValue("@contrasena", auxcontrasena);

                int i = command.ExecuteNonQuery();

                if (i >= 0)
                {
                    coneccion.cerrarConeccion();
                    Console.WriteLine(i);
                    return true;
                }
                else
                {
                    Console.WriteLine(i);
                    coneccion.cerrarConeccion();
                    return false;
                }
            }
            return false;
        }

        //--------------------------------------------------------------------------------------------------
        //---------------------------------Consulta de administrador----------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static Administrador infoadmin(string auxnombreusuario, string auxcontrasena)
        {
            ConeccionBD coneccion = new ConeccionBD();
            Administrador auxadmin = new Administrador();
            string query = "select * from administrador where nombreUsuario=@nombreUsuario and contrasena=@contrasena";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("nombreUsuario", auxnombreusuario);
                command.Parameters.AddWithValue("contrasena", auxcontrasena);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        auxadmin.idadministrador = Convert.ToInt32(reader["idAdministrador"]);
                        auxadmin.nombres = reader["nombres"].ToString();
                        auxadmin.apellidos = reader["apellidos"].ToString();
                        auxadmin.nombreusuario = reader["nombreUsuario"].ToString();
                    }
                    coneccion.cerrarConeccion();
                    return auxadmin;
                }
            }
            return null;
        }
    }


}