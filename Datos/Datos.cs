using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Datos
{
    public class Datos
    {

        string strcon;
        MySqlConnection con;
        MySqlCommand cmd;

        public Datos()
        {
            //Conexion para mysql con stored procedures
            strcon = "server=umsebastianbd.ddns.net;user id=v8jonatan;database=biblioteca;pwd=v8jonatan";
            //string strcon="server=localhost;user id=v8jonatan;database=biblioteca;pwd=v8jonatan"; 
            con = new MySqlConnection(strcon);

            //Conexion para linq
            string dbServer = Environment.GetEnvironmentVariable("DbLinqServer") ?? "umsebastianbd.ddns.net";
            // BUG: El contexto debe ser desechable
            string connStr = String.Format("server={0};user id={1}; password={2}; database={3}"
                , dbServer, "SebastianF", "thiago1311", "biblioteca");
            BibLiOtEcA db = new BibLiOtEcA(new MySqlConnection(connStr));
        }

        private bool openConnection()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                string error = ex.Message;
                return false;
            }
        }

        private bool closeConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                string error = ex.Message;
                return false;
            }
        }

        public int altaSocio(string noms, string ape, string c, int tel, int dni, string t)
        {
            if (openConnection()) //si es verdadero
            {
                cmd = new MySqlCommand();
                cmd.CommandText = "altaSocio"; // el nombre del proceso almacenado
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure; // para que sepa que es un procedimiento almacenado

                // parametro de salida 
                MySqlParameter idSocio = new MySqlParameter("paramId", MySqlDbType.Int32);
                idSocio.Direction = ParameterDirection.Output;
                idSocio.Value = 0;  
                cmd.Parameters.Add(idSocio);

                //parametros del insert se crea cada uno y se lo agrega al mysqlcommand cmd
                MySqlParameter nombres = new MySqlParameter("paramNombres", noms);
                cmd.Parameters.Add(nombres);
                MySqlParameter apellido = new MySqlParameter("paramApellido", ape);
                cmd.Parameters.Add(apellido);
                MySqlParameter correo = new MySqlParameter("paramCorreo", c);
                cmd.Parameters.Add(correo);
                MySqlParameter tipo = new MySqlParameter("paramTipo", t);
                cmd.Parameters.Add(tipo);
                MySqlParameter telefono = new MySqlParameter("paramTelefono", tel);
                cmd.Parameters.Add(telefono);
                MySqlParameter dniNuevo = new MySqlParameter("paramDNI", dni);
                cmd.Parameters.Add(dniNuevo);

                //ejecuta el proceso almacenado
                cmd.ExecuteNonQuery();

                closeConnection();
                // el parametro idSocio de salida tiene el id del objeto insertado en la base de datos
                return (int)idSocio.Value;
            }
            else
                return 0;   //Reemplazar por MessageBox que no se puede conectar por clase exception y modificar clase Biblioteca que llama a esta funcion 
        }

        public List<Object> cargarSocios()
        {
            /*Acá no sé como usar el list<>´porque no me funciona
             * castear la lista tipo object. Igualmente una solucion
             * seria usar Arraylist como vimos en clase. Pero es dificil 
             * hacerlo asi que iba a preguntarte como era la forma que
             * usaste vos en tu programa
             */

            List<Object> socios = new List<Object>();
            //Vale por codigo linq para rescatar los socios de la bd

            return socios;
        }

        public List<Object> cargarLibros()
        {
            List<Object> libros = new List<Object>();
            //Vale por codigo linq para rescatar los libros de la bd

            return libros;
        }

        public List<Object> cargarReservas()
        {
            List<Object> reservas = new List<Object>();
            //Vale por codigo linq para rescatar los reservas de la bd

            return reservas;
        }

        public List<Object> cargarPrestamos()
        {
            List<Object> prestamos = new List<Object>();
            //Vale por codigo linq para rescatar los prestamos de la bd

            return prestamos;
        }

        public List<Object> cargarAutores()
        {
            List<Object> autores = new List<Object>();
            //Vale por codigo linq para rescatar los autores de la bd

            return autores;
        }

    }

    
    
    

}
