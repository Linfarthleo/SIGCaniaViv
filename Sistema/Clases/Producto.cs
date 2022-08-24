using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Sistema.Clases
{
    public class Producto
    {
        private int idProducto, gradosAlcohol, idTrabajo;
        private float cantidadAlcohol;
        private String detalleProducto;


        //----------------------------------- METODOS GETTERS Y SETTERS -----------------------------------
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int GradosAlcohol { get => gradosAlcohol; set => gradosAlcohol = value; }
        public int IDTrabajo { get => idTrabajo; set => idTrabajo = value; }
        public float CantidadAlcohol { get => cantidadAlcohol; set => cantidadAlcohol = value; }
        public String DetalleProducto { get => detalleProducto; set => detalleProducto = value; }


        //----------------------------------- METODOS FUNCIONALES ------------------------------------------

        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Listar Productos-----------------------------------------
        //--------------------------------------------------------------------------------------------------

        public static List<Producto> listadoProductos()
        {
            List<Producto> productos = new List<Producto>();
            ConeccionBD coneccion = new ConeccionBD();
            String query = "Select * from producto";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto.cantidadAlcohol = Convert.ToInt32(reader["cantidadAlchol"]);
                        producto.gradosAlcohol = Convert.ToInt32(reader["gradosAlcohol"]);
                        producto.detalleProducto = reader["detalleProd"].ToString();
                        producto.IdProducto = Convert.ToInt32(reader["idProducto"]);
                        productos.Add(producto);
                    }
                    coneccion.cerrarConeccion();
                }
            }
            return productos;
        }


        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Registrar Producto---------------------------------------
        //--------------------------------------------------------------------------------------------------

        public static Boolean registrarProducto(Producto auxProducto)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "insert into producto (cantidadAlchol,gradosAlcohol,detalleProd)" +
                "values (@cantidadAlchol,@gradosAlcohol,@detalleProd)";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@cantidadAlchol", auxProducto.cantidadAlcohol);
                command.Parameters.AddWithValue("@gradosAlcohol", auxProducto.gradosAlcohol);
                command.Parameters.AddWithValue("@detalleProd", auxProducto.detalleProducto);

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
        //------------------------------------------Buscar iDProducto-----------------------------------------
        //--------------------------------------------------------------------------------------------------

        public static Boolean buscarIDProducto(String auxidProd)
        {
            ConeccionBD coneccion = new ConeccionBD();
            MySqlDataReader reader;
            String query = "select * from producto where idProducto=@idProducto";

            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@idProducto", auxidProd);
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
        //------------------------------------------Obtener Producto con el iDProducto----------------------
        //--------------------------------------------------------------------------------------------------
        public static Producto obtenerProductoDesdeId(String idProducto)
        {
            Producto auxProducto = new Producto();
            ConeccionBD coneccion = new ConeccionBD();
            String query = "select * from producto where idProducto=@idProducto";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@idProducto", idProducto);
                MySqlDataReader reader2 = command.ExecuteReader();
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        auxProducto.cantidadAlcohol = Convert.ToInt32(reader2["cantidadAlchol"]);
                        auxProducto.gradosAlcohol = Convert.ToInt32(reader2["gradosAlcohol"]);
                        auxProducto.detalleProducto = reader2["detalleProd"].ToString();
                    }
                }
            }
            return auxProducto;
        }


        //--------------------------------------------------------------------------------------------------
        //------------------------------------------Modificar Producto---------------------------------------
        //--------------------------------------------------------------------------------------------------
        public static Boolean editarProducto(Producto aux)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "UPDATE producto SET cantidadAlchol=@cantidadAlchol, " +
               "gradosAlcohol=@gradosAlcohol, " +
               "detalleProd=@detalleProd";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@cantidadAlchol", aux.cantidadAlcohol);
                command.Parameters.AddWithValue("@gradosAlcohol", aux.gradosAlcohol);
                command.Parameters.AddWithValue("@detalleProd", aux.detalleProducto);


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
        //------------------------------------------Metodos para ventas----------------------
        //--------------------------------------------------------------------------------------------------

        public static float cantidadDeProductoAEditar;


        public static float consultarCantidadDeProductoAEditar(String idProducto)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "select * from producto where idProducto=@idProducto";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@idProducto", idProducto);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cantidadDeProductoAEditar = float.Parse(reader["cantidadAlchol"].ToString());
                    }
                }
            }
            return cantidadDeProductoAEditar;
        }

        public static Boolean actualizarCantidad(int idProducto, float cantidadAlchol)
        {
            ConeccionBD coneccion = new ConeccionBD();
            String query = "UPDATE producto SET cantidadAlchol=@cantidadAlchol where idProducto = @idProducto;";
            if (coneccion.abrirConeccion())
            {
                MySqlCommand command = new MySqlCommand(query, coneccion.coneccion);
                command.Parameters.AddWithValue("@idProducto", idProducto);
                command.Parameters.AddWithValue("@cantidadAlchol", cantidadAlchol);
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
