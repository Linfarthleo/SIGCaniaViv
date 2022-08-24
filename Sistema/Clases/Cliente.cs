using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Sistema.Clases
{
    public class Cliente
    {
        private int idcliente;
        private string nombres, apellidos, cedula, correo;
        private string telefonofijo, telefonomovil, direccion, telefono2;

        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Correo { get => correo; set => correo = value; }
        ///public string Telefonofijo { get => telefonofijo; set => telefonofijo = value; }
        public string Telefonomovil { get => telefonomovil; set => telefonomovil = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        //public string Telefono2 { get => telefono2; set => telefono2 = value; }


        //----------------------------------- METODOS FUNCIONALES ------------------------------------------

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Listar Clientes-----------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static List<Cliente> listadoclientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            ConeccionBD coneccion = new ConeccionBD();
            String query = "Select * from cliente";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.idcliente = Convert.ToInt32(reader["idCliente"]);
                        cliente.nombres = reader["nombres"].ToString();
                        cliente.apellidos = reader["apellidos"].ToString();
                        cliente.cedula = reader["numIdentificacion"].ToString();
                        cliente.correo = reader["correo"].ToString();
                        cliente.telefonomovil = reader["telfCelu1"].ToString();
                        //cliente.telefonomovil = reader["telfConv"].ToString();
                        cliente.direccion = reader["direccion"].ToString();
                        //cliente.telefono2 = reader["telfCelu2"].ToString();
                        clientes.Add(cliente);
                    }
                    coneccion.cerrarConeccion();
                }
            }
            return clientes;
        }

        //--------------------------------------------------------------------------------------------------
        //----------------------------------Buscar Cliente por nombres apellidos o cedula-------------------
        //--------------------------------------------------------------------------------------------------
        public static List<Cliente> buscarclientes(string parametro)
        {
            List<Cliente> clientes = new List<Cliente>();
            ConeccionBD coneccion = new ConeccionBD();
            MySqlCommand command;
            MySqlDataReader reader;
            String query = "SELECT * from cliente where (INSTR(nombres,@parametro) > 0) OR (INSTR(apellidos,@parametro) > 0) OR (INSTR(numIdentificacion,@parametro) > 0);";
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
                        Cliente cliente = new Cliente();
                        cliente.idcliente = Convert.ToInt32(reader["idCliente"]);
                        cliente.nombres = reader["nombres"].ToString();
                        cliente.apellidos = reader["apellidos"].ToString();
                        cliente.cedula = reader["numIdentificacion"].ToString();
                        cliente.correo = reader["correo"].ToString();
                        cliente.telefonomovil = reader["telfCelu1"].ToString();
                        //cliente.telefonomovil = reader["telfConv"].ToString();
                        cliente.direccion = reader["direccion"].ToString();
                        //cliente.telefono2 = reader["telfCelu2"].ToString();
                        clientes.Add(cliente);
                    }
                    Console.WriteLine(clientes.Count);
                }
                coneccion.cerrarConeccion();
            }
            return clientes;
        }
        //--------------------------------------------------------------------------------------------------
        //----------------------------------Buscar Cliente por cedula---------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static Cliente buscarcliente(string cedula)
        {
            Cliente cliente = new Cliente();
            ConeccionBD coneccion = new ConeccionBD();
            String querycedula = "SELECT * from administrador where (INSTR(numIdentificacion,'@parametro') > 0)";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(querycedula, coneccion.coneccion);
                command.Parameters.AddWithValue("@parametro", cedula);
                MySqlDataReader reader2 = command.ExecuteReader();
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        cliente.idcliente = Convert.ToInt32(reader2["idCliente"]);
                        cliente.nombres = reader2["nombres"].ToString();
                        cliente.apellidos = reader2["apellidos"].ToString();
                        cliente.cedula = reader2["numIdentificacion"].ToString();
                        cliente.correo = reader2["correo"].ToString();
                        cliente.telefonomovil = reader2["telfCelu1"].ToString();
                        //cliente.telefonomovil = reader2["telfConv"].ToString();
                        cliente.direccion = reader2["direccion"].ToString();
                        //cliente.telefono2 = reader2["telfCelu2"].ToString();
                    }
                }
            }
            return cliente;
        }

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Registrar Cliente---------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static Boolean registrarcliente(Cliente auxcliente)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "insert into cliente (nombres,apellidos,numIdentificacion,correo,telfCelu1,direccion) " +
                "values (@nombres,@apellidos,@numIdentificacion,@correo,@telfCelu1,@direccion)";

            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@nombres", auxcliente.nombres);
                command.Parameters.AddWithValue("@apellidos", auxcliente.apellidos);
                command.Parameters.AddWithValue("@numIdentificacion", auxcliente.cedula);
                command.Parameters.AddWithValue("@correo", auxcliente.correo);
                command.Parameters.AddWithValue("@telfCelu1", auxcliente.telefonomovil);
                //command.Parameters.AddWithValue("@telfConv", auxcliente.telefonomovil);
                command.Parameters.AddWithValue("@direccion", auxcliente.direccion);
                //command.Parameters.AddWithValue("@telfCelu2", auxcliente.telefono2);

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

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Modificar Cliente---------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static Boolean modificarcliente(Cliente auxcliente)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "UPDATE cliente SET nombres=@nombres, " +
                "apellidos=@apellidos, " +
                "numIdentificacion=@numIdentificacion, " +
                "correo=@correo, " +
                "telfCelu1=@telfCelu1, " +
                "direccion=@direccion " +
                "WHERE idCliente=@idCliente";

            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@idcliente", auxcliente.idcliente);
                command.Parameters.AddWithValue("@nombres", auxcliente.nombres);
                command.Parameters.AddWithValue("@apellidos", auxcliente.apellidos);
                command.Parameters.AddWithValue("@numIdentificacion", auxcliente.cedula);
                command.Parameters.AddWithValue("@correo", auxcliente.correo);
                command.Parameters.AddWithValue("@telfCelu1", auxcliente.telefonomovil);
                //command.Parameters.AddWithValue("@telfConv", auxcliente.telefonomovil);
                command.Parameters.AddWithValue("@direccion", auxcliente.direccion);
                //command.Parameters.AddWithValue("@telfCelu2", auxcliente.telefono2);

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

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Eliminar Cliente----------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static Boolean eliminarcliente(Cliente auxcliente)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "DELETE FROM cliente WHERE idCliente=@idCliente";

            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@idCliente", auxcliente.idcliente);

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

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Buscar numIdentificacion-----------------------------------------
        //--------------------------------------------------------------------------------------------------

        public static Boolean buscarCedulaCliente(String numIdentificacion)
        {
            ConeccionBD coneccion = new ConeccionBD();
            MySqlDataReader reader;
            String query = "select * from cliente where numIdentificacion=@numIdentificacion";

            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@numIdentificacion", numIdentificacion);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Obtener cliente de numIdentificacion----------------------
        //--------------------------------------------------------------------------------------------------
        public static Cliente obtenerClienteDeNumId(String numIdentificacion)
        {
            Cliente aux = new Cliente();
            ConeccionBD coneccion = new ConeccionBD();
            String query = "select * from cliente where numIdentificacion=@numIdentificacion";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@numIdentificacion", numIdentificacion);
                MySqlDataReader reader2 = command.ExecuteReader();
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        //cedula,nombre,apellido,crreo,telefono
                        aux.nombres = Convert.ToString(reader2["nombres"]);
                        aux.apellidos = Convert.ToString(reader2["apellidos"]);
                        aux.correo = Convert.ToString(reader2["correo"]);
                        aux.telefonomovil = Convert.ToString(reader2["telfCelu1"]);
                        aux.cedula = Convert.ToString(reader2["numIdentificacion"]);
                    }
                }
            }
            return aux;
        }

    }
}