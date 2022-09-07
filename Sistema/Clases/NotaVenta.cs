using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Sistema.Clases
{
    class NotaVenta
    {
        int idNota, idVenta;
        DateTime fecha;
        String estado, numIdentificacion;
        public int IdNota { get => idNota; set => idNota = value; }
        public String NumIdentificacion { get => numIdentificacion; set => numIdentificacion = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public String Estado { get => estado; set => estado = value; }

        public DateTime Fecha { get => fecha; set => fecha = value; }


        public static List<NotaVenta> listadoNotas()
        {
            List<NotaVenta> notas = new List<NotaVenta>();
            ConeccionBD coneccion = new ConeccionBD();
            String query = "Select * from nota_de_venta";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        NotaVenta nota = new NotaVenta();
                        nota.idVenta = Convert.ToInt32(reader["idVenta"]);
                        nota.idNota = Convert.ToInt32(reader["idNota"]);
                        nota.estado = reader["estado"].ToString();
                        nota.numIdentificacion = reader["numIdentificacion"].ToString();
                        nota.fecha = Convert.ToDateTime(reader["fecha"]).Date;

                        notas.Add(nota);
                    }
                    coneccion.cerrarConeccion();
                }
            }
            return notas;
        }

        public static Boolean emitirNota(NotaVenta auxNota)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "insert into nota_de_venta (numIdentificacion, estado,fecha,idVenta)" +
                "values (@numIdentificacion,@estado,Now(),@idVenta)";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@estado", auxNota.estado);
                command.Parameters.AddWithValue("@numIdentificacion", auxNota.numIdentificacion);
                command.Parameters.AddWithValue("@idVenta", auxNota.idVenta);

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
        //----------------------------------Buscar nota de venta por idNota---------------------------
        //--------------------------------------------------------------------------------------------------
        public static List<NotaVenta> buscarNotas(string parametro)
        {
            List<NotaVenta> notas = new List<NotaVenta>();
            ConeccionBD coneccion = new ConeccionBD();
            MySqlCommand command;
            MySqlDataReader reader;
            String query = "SELECT * from nota_de_venta where (INSTR(idNota,@parametro) > 0);";
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
                        NotaVenta nota = new NotaVenta();
                        nota.idVenta = Convert.ToInt32(reader["idVenta"]);
                        nota.idNota = Convert.ToInt32(reader["idNota"]);
                        nota.estado = reader["estado"].ToString();
                        nota.numIdentificacion = reader["numIdentificacion"].ToString();
                        nota.fecha = Convert.ToDateTime(reader["fecha"]).Date;

                        notas.Add(nota);

                    }
                    Console.WriteLine(notas.Count);
                }
                coneccion.cerrarConeccion();
            }
            return notas;
        }

        //--------------------------------------------------------------------------------------------------
        //----------------------------------Buscar nota de venta por identificacion---------------------------
        //--------------------------------------------------------------------------------------------------
        public static List<NotaVenta> buscarNotasPorIdentificacion(string parametro)
        {
            List<NotaVenta> notas = new List<NotaVenta>();
            ConeccionBD coneccion = new ConeccionBD();
            MySqlCommand command;
            MySqlDataReader reader;
            String query = "SELECT * from nota_de_venta where (INSTR(numIdentificacion,@parametro) > 0);";
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
                        NotaVenta nota = new NotaVenta();
                        nota.idVenta = Convert.ToInt32(reader["idVenta"]);
                        nota.idNota = Convert.ToInt32(reader["idNota"]);
                        nota.estado = reader["estado"].ToString();
                        nota.numIdentificacion = reader["numIdentificacion"].ToString();
                        nota.fecha = Convert.ToDateTime(reader["fecha"]).Date;

                        notas.Add(nota);

                    }
                    Console.WriteLine(notas.Count);
                }
                coneccion.cerrarConeccion();
            }
            return notas;
        }

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Anular Factura---------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static Boolean anularFactura(NotaVenta notaVenta)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "UPDATE nota_de_venta SET estado='ANULADA'" +
                "WHERE idNota=@idNota";

            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@idNota", notaVenta.idNota);

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
