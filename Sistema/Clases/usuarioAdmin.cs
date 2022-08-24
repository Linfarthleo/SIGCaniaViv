using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Sistema.Clases
{
    class UsuarioAdmin
    {
        private int idadministrador;
        private string nombres;
        private string apellidos;
        private string cedula;
        private string nombreusuario;
        private string contrasena;

        //----------------------------------- METODOS GETTERS Y SETTERS -----------------------------------
        public int Idadministrador { get => idadministrador; set => idadministrador = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }

        //----------------------------------- METODOS FUNCIONALES ------------------------------------------

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Listar Usuarios-----------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static List<UsuarioAdmin> usuarioAdmins()
        {
            List<UsuarioAdmin> usuariosadmin = new List<UsuarioAdmin>();
            ConeccionBD coneccion = new ConeccionBD();
            String query = "Select * from administrador";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UsuarioAdmin usuarioadmin = new UsuarioAdmin();
                        usuarioadmin.idadministrador = Convert.ToInt32(reader["idadministrador"]);
                        usuarioadmin.nombres = reader["nombres"].ToString();
                        usuarioadmin.apellidos = reader["apellidos"].ToString();
                        usuarioadmin.cedula = reader["cedula"].ToString();
                        usuarioadmin.contrasena = reader["contrasena"].ToString();
                        usuariosadmin.Add(usuarioadmin);
                    }
                    coneccion.cerrarConeccion();
                }
            }
            return usuariosadmin;
        }
        //--------------------------------------------------------------------------------------------------
        //----------------------------------Buscar Usuario por nombres apellidos o cedula-------------------
        //--------------------------------------------------------------------------------------------------
        public static List<UsuarioAdmin> buscarusuarioadmin(string parametro)
        {
            List<UsuarioAdmin> usuarios = new List<UsuarioAdmin>();
            ConeccionBD coneccion = new ConeccionBD();
            MySqlCommand command;
            MySqlDataReader reader;
            String query = "SELECT * from administrador where (INSTR(nombres,@parametro) > 0) OR (INSTR(apellidos,@parametro) > 0) OR (INSTR(cedula,@parametro) > 0);";
            if (coneccion.abrirConeccion())
            {
                //Busqueda por nombres
                command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@parametro", parametro);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UsuarioAdmin usuarioadmin = new UsuarioAdmin();
                        usuarioadmin.idadministrador = Convert.ToInt32(reader["idadministrador"]);
                        usuarioadmin.nombres = reader["nombres"].ToString();
                        usuarioadmin.apellidos = reader["apellidos"].ToString();
                        usuarioadmin.nombreusuario = reader["nombreUsuario"].ToString();
                        usuarioadmin.cedula = reader["cedula"].ToString();
                        usuarioadmin.contrasena = reader["contrasena"].ToString();
                        usuarios.Add(usuarioadmin);
                    }
                    Console.WriteLine(usuarios.Count);
                }
                coneccion.cerrarConeccion();
            }
            return usuarios;
        }

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Registrar Usuario---------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static Boolean registraruser(UsuarioAdmin auxuser)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "insert into administrador (nombres,apellidos,nombreUsuario,contrasena,cedula) " +
                "values (@nombres,@apellidos,@nombreUsuario,@contrasena,@cedula)";

            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@nombres", auxuser.nombres);
                command.Parameters.AddWithValue("@apellidos", auxuser.apellidos);
                command.Parameters.AddWithValue("@nombreUsuario", auxuser.nombreusuario);
                command.Parameters.AddWithValue("@contrasena", auxuser.contrasena);
                command.Parameters.AddWithValue("@cedula", auxuser.cedula);

                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    coneccion.cerrarConeccion();
                    return true;
                }
                else
                {
                    coneccion.cerrarConeccion();
                    return false;
                }
            }
            return false;
        }

    }
}