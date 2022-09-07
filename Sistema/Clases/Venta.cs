using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Sistema.Clases
{
    class Venta
    {
        int idVenta, idProducto;
        DateTime fecha;
        String formaPago, numIdentificacion;
        float valorTotal, cantAlcoholVendida;

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public String NumIdentificacion { get => numIdentificacion; set => numIdentificacion = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public float CantAlcoholVendida { get => cantAlcoholVendida; set => cantAlcoholVendida = value; }
        public float ValorTotal { get => valorTotal; set => valorTotal = value; }
        public String FormaPago { get => formaPago; set => formaPago = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        //----------------------------------- METODOS FUNCIONALES ------------------------------------------

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Listar Productos-----------------------------------------
        //--------------------------------------------------------------------------------------------------

        public static List<Venta> listadoVentas()
        {
            List<Venta> ventas = new List<Venta>();
            ConeccionBD coneccion = new ConeccionBD();
            String query = "Select * from venta";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Venta venta = new Venta();
                        venta.idVenta = Convert.ToInt32(reader["idVenta"]);
                        venta.numIdentificacion = reader["numIdentificacion"].ToString();
                        venta.idProducto = Convert.ToInt32(reader["idProducto"]);
                        venta.cantAlcoholVendida = float.Parse(reader["cantAlcoholVendida"].ToString());
                        venta.valorTotal = float.Parse(reader["valorTotal"].ToString());
                        venta.formaPago = reader["formaPago"].ToString();
                        venta.fecha = Convert.ToDateTime(reader["fecha"]).Date;

                        ventas.Add(venta);
                    }
                    coneccion.cerrarConeccion();
                }
            }
            return ventas;
        }


        public static Boolean registrarVenta(Venta auxVenta)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "insert into venta (fecha,formaPago,valorTotal,numIdentificacion,idProducto,cantAlcoholVendida)" +
                "values (Now(),@formaPago,@valorTotal, @numIdentificacion,@idProducto,@cantAlcoholVendida)";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@formaPago", auxVenta.formaPago);
                command.Parameters.AddWithValue("@valorTotal", auxVenta.valorTotal);
                command.Parameters.AddWithValue("@numIdentificacion", auxVenta.numIdentificacion);
                command.Parameters.AddWithValue("@idProducto", auxVenta.idProducto);
                command.Parameters.AddWithValue("@cantAlcoholVendida", auxVenta.cantAlcoholVendida);

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
        //----------------------------------Buscar venta por cedula del cliente-------------------
        //--------------------------------------------------------------------------------------------------
        public static List<Venta> buscarVentas(string parametro)
        {
            List<Venta> ventas = new List<Venta>();
            ConeccionBD coneccion = new ConeccionBD();
            MySqlCommand command;
            MySqlDataReader reader;
            String query = "SELECT * from venta where (INSTR(numIdentificacion,@parametro) > 0);";
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

                        Venta venta = new Venta();
                        venta.idVenta = Convert.ToInt32(reader["idVenta"]);
                        venta.numIdentificacion = reader["numIdentificacion"].ToString();
                        venta.idProducto = Convert.ToInt32(reader["idProducto"]);
                        venta.cantAlcoholVendida = float.Parse(reader["cantAlcoholVendida"].ToString());
                        venta.valorTotal = float.Parse(reader["valorTotal"].ToString());
                        venta.formaPago = reader["formaPago"].ToString();
                        venta.fecha = Convert.ToDateTime(reader["fecha"]).Date;

                        ventas.Add(venta);

                    }
                    Console.WriteLine(ventas.Count);
                }
                coneccion.cerrarConeccion();
            }
            return ventas;
        }
        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Obtener venta de idVenta----------------------
        //--------------------------------------------------------------------------------------------------
        public static Venta buscarVenta(int parametro)
        {
            Venta venta = new Venta();
            ConeccionBD coneccion = new ConeccionBD();
             
            
            String query = "SELECT * from venta where (INSTR(idVenta,@parametro) > 0);";
            if (coneccion.abrirConeccion())
            {
                //Busqueda por cedula
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@parametro", parametro);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        venta.idVenta = Convert.ToInt32(reader["idVenta"]);
                        venta.numIdentificacion = reader["numIdentificacion"].ToString();
                        venta.idProducto = Convert.ToInt32(reader["idProducto"]);
                        venta.cantAlcoholVendida = float.Parse(reader["cantAlcoholVendida"].ToString());
                        venta.valorTotal = float.Parse(reader["valorTotal"].ToString());
                        venta.formaPago = reader["formaPago"].ToString();
                        venta.fecha = Convert.ToDateTime(reader["fecha"]).Date;
                    }
                }
                coneccion.cerrarConeccion();
            }
            return venta;
        }

        //--------------------------------------------------------------------------------------------------
        //----------------------------------Buscar ultima venta para id-------------------
        //--------------------------------------------------------------------------------------------------

        public static int ultimaVenta;

        public static int buscarUltimaVenta()
        {

            ConeccionBD coneccion = new ConeccionBD();
            MySqlCommand command;
            MySqlDataReader reader;
            String query = "SELECT * FROM venta ORDER BY idVenta DESC LIMIT 1;";
            if (coneccion.abrirConeccion())
            {
                command = new MySqlCommand(query, coneccion.coneccion);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ultimaVenta = Convert.ToInt32(reader["idVenta"]);
                    }

                }
                coneccion.cerrarConeccion();
            }
            return ultimaVenta;
        }

        public static float cantidadDeAlcoholDeVenta;
        public static float consultarCantidadDeAlcoholDeVenta(String idVenta)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "select * from venta where idVenta=@idVenta";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@idVenta", idVenta);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cantidadDeAlcoholDeVenta= float.Parse(reader["cantAlcoholVendida"].ToString());
                    }
                }
            }
            return cantidadDeAlcoholDeVenta;
        }

        public static int idProductoVenta;
        public static int consultarIdProductoventa(String idVenta)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "select * from venta where idVenta=@idVenta";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@idVenta", idVenta);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idProductoVenta = Convert.ToInt32(reader["idProducto"]);
                    }
                }
            }
            return idProductoVenta;
        }


    }
}
