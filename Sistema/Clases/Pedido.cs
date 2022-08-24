using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Sistema.Clases
{
    class Pedido
    {
        int idPedido, idProducto;
        DateTime fechaRecep, fechaEntrega;
        String estadoPedido;
        float cantidadAlcPedido, abono;
        String numIdentificacion;
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public String NumIdentificacion { get => numIdentificacion; set => numIdentificacion = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public float CantidadAlcPedido { get => cantidadAlcPedido; set => cantidadAlcPedido = value; }
        public float Abono { get => abono; set => abono = value; }
        public String Estado { get => estadoPedido; set => estadoPedido = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public DateTime FechaRecep { get => fechaRecep; set => fechaRecep = value; }

        //----------------------------------- METODOS FUNCIONALES ------------------------------------------

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Listar Productos-----------------------------------------
        //--------------------------------------------------------------------------------------------------

        public static List<Pedido> listadoPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();
            ConeccionBD coneccion = new ConeccionBD();
            String query = "Select * from pedido";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Pedido pedido = new Pedido();
                        pedido.idPedido = Convert.ToInt32(reader["idPedido"]);

                        pedido.idProducto = Convert.ToInt32(reader["idProducto"]);
                        pedido.numIdentificacion = reader["numIdentificacion"].ToString();
                        int valor = Convert.ToInt32(reader["estadoPedido"]);
                        if (valor == 0)
                        {
                            pedido.estadoPedido = "Pendiente";
                        }
                        else
                        {
                            pedido.estadoPedido = "Entregado";

                        }
                        pedido.cantidadAlcPedido = float.Parse(reader["cantidadAlcPedido"].ToString());
                        pedido.abono = float.Parse(reader["abono"].ToString());
                        pedido.fechaEntrega = Convert.ToDateTime(reader["fechaEntrega"]).Date;
                        pedido.fechaRecep = Convert.ToDateTime(reader["fechaRecep"]).Date;

                        pedidos.Add(pedido);
                    }
                    coneccion.cerrarConeccion();
                }
            }
            return pedidos;
        }


        public static Boolean registrarPedido(Pedido auxPedido)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "insert into pedido (fechaRecep,cantidadAlcPedido,abono,estadoPedido,fechaEntrega,numIdentificacion,idProducto)" +
                "values (Now(),@cantidadAlcPedido,@abono,0,@fechaEntrega,@numIdentificacion,@idProducto)";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@cantidadAlcPedido", auxPedido.cantidadAlcPedido);
                command.Parameters.AddWithValue("@abono", auxPedido.cantidadAlcPedido);
                command.Parameters.AddWithValue("@fechaEntrega", auxPedido.fechaEntrega);
                command.Parameters.AddWithValue("@numIdentificacion", auxPedido.numIdentificacion);
                command.Parameters.AddWithValue("@idProducto", auxPedido.idProducto);


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
        //------------------------------------------Buscar cliente-----------------------------------------
        //--------------------------------------------------------------------------------------------------

        public static Boolean buscarNumIdentificacion(String auxidProd)
        {
            ConeccionBD coneccion = new ConeccionBD();
            MySqlDataReader reader;
            String query = "select * from pedido where numIdentificacion=@numIdentificacion";

            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@numIdentificacion", auxidProd);
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
        //------------------------------------------Obtener Pedido numIdenficacion----------------------
        //--------------------------------------------------------------------------------------------------
        public static Pedido obtenerPedidoDesdeCliente(String numIdentificacion)
        {
            Pedido auxPedido = new Pedido();
            ConeccionBD coneccion = new ConeccionBD();
            String query = "select * from pedido where numIdentificacion=@numIdentificacion";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@numIdentificacion", numIdentificacion);
                MySqlDataReader reader2 = command.ExecuteReader();
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {

                        auxPedido.idPedido = Convert.ToInt32(reader2["idPedido"]);
                        auxPedido.numIdentificacion = reader2["numIdentificacion"].ToString();
                        int valor = Convert.ToInt32(reader2["estadoPedido"]);
                        if (valor == 0)
                        {
                            auxPedido.estadoPedido = "Pendiente";
                        }
                        else
                        {
                            auxPedido.estadoPedido = "Entregado";

                        }
                        auxPedido.cantidadAlcPedido = float.Parse(reader2["cantidadAlcPedido"].ToString());
                        auxPedido.abono = float.Parse(reader2["abono"].ToString());
                        auxPedido.fechaEntrega = Convert.ToDateTime(reader2["fechaEntrega"]).Date;
                        auxPedido.fechaRecep = Convert.ToDateTime(reader2["fechaRecep"]).Date;

                    }
                }
            }
            return auxPedido;
        }

        //--------------------------------------------------------------------------------------------------
        //----------------------------------Buscar pedido por cedula del cliente-------------------
        //--------------------------------------------------------------------------------------------------
        public static List<Pedido> buscarPedidos(string parametro)
        {
            List<Pedido> pedidos = new List<Pedido>();
            ConeccionBD coneccion = new ConeccionBD();
            MySqlCommand command;
            MySqlDataReader reader;
            String query = "SELECT * from pedido where (INSTR(numIdentificacion,@parametro) > 0);";
            if (coneccion.abrirConeccion())
            {
                //Busqueda por cedula
                command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@parametro", parametro);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Pedido pedido = new Pedido();
                        pedido.idPedido = Convert.ToInt32(reader["idPedido"]);
                        pedido.numIdentificacion = reader["numIdentificacion"].ToString();
                        int valor = Convert.ToInt32(reader["estadoPedido"]);
                        if (valor == 0)
                        {
                            pedido.estadoPedido = "Pendiente";
                        }
                        else
                        {
                            pedido.estadoPedido = "Entregado";

                        }
                        pedido.cantidadAlcPedido = float.Parse(reader["cantidadAlcPedido"].ToString());
                        pedido.abono = float.Parse(reader["abono"].ToString());
                        pedido.fechaEntrega = Convert.ToDateTime(reader["fechaEntrega"]).Date;
                        pedido.fechaRecep = Convert.ToDateTime(reader["fechaRecep"]).Date;

                        pedidos.Add(pedido);

                    }
                    Console.WriteLine(pedidos.Count);
                }
                coneccion.cerrarConeccion();
            }
            return pedidos;
        }

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Modificar Pedido---------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static Boolean modificarPedido(Pedido auxPedido)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "UPDATE pedido SET cantAlcPedido=@cantAlcPedido, " +
                "abono=@abono, " +
                "estadoPedido=@estadoPedido, " +
                "fechaEntrega=@fechaEntrega, " +
                "idProducto=@idProducto " +
                "WHERE idPedido=@idPedido";

            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@cantidadAlcPedido", auxPedido.cantidadAlcPedido);
                command.Parameters.AddWithValue("@abono", auxPedido.cantidadAlcPedido);
                command.Parameters.AddWithValue("@fechaEntrega", auxPedido.fechaEntrega);
                command.Parameters.AddWithValue("@idProducto", auxPedido.idProducto);
                command.Parameters.AddWithValue("@estadoPedido", auxPedido.estadoPedido);


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
