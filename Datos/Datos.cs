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
             //strcon="server=localhost;user id=v8jonatan;database=biblioteca;pwd=v8jonatan"; 
             con = new MySqlConnection(strcon);
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
                throw new Exception(ex.Message,ex);
        
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
            
                if (openConnection()) 
                {
                    cmd = new MySqlCommand();
                    cmd.CommandText = "altaSocio"; 
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;

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
                    // Devuelve parametro de salida
                    return (int)idSocio.Value;
                }
                else
                    return 0;   //Reemplazar por MessageBox que no se puede conectar por clase exception y modificar clase Biblioteca que llama a esta funcion 
            
            
        }

      

        public List<SocioDO> cargarSocios()

        {
            openConnection();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.CommandText = "recuperarSocios";
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "socios");
            DataTable dt = ds.Tables["socios"];
            closeConnection();


            SocioDO s, s2;
            s=new SocioDO();
            List<SocioDO> socios = new List<SocioDO>();
            foreach (DataRow row in dt.Rows)
            {
                s.Id = row.Field<int>("id_socio");
                s.Telefono = row.Field<int>("telefono");
                s.Dni = row.Field<int>("DNI");
                s.Correo = row.Field<string>("email");
                s.Apellido = row.Field<string>("apellido");
                s.Nombres = row.Field<string>("nombres");
                s.Tipo = row.Field<string>("tipo"); 
                s2 = new SocioDO(s.Id, s.Telefono, s.Dni, s.Correo, s.Nombres, s.Apellido, s.Tipo);
                socios.Add(s2);
            }
            return socios;
        }
        public int altaAutor(string nacio, string apenom)
        {
            if (openConnection())
            {
                cmd = new MySqlCommand();
                cmd.CommandText = "altaAutor";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                // parametro de salida 
                MySqlParameter idAutor = new MySqlParameter("paramId", MySqlDbType.Int32);
                idAutor.Direction = ParameterDirection.Output;
                idAutor.Value = 0;
                cmd.Parameters.Add(idAutor);

                MySqlParameter nacionalidad = new MySqlParameter("paramNacionalidad",nacio);
                cmd.Parameters.Add(nacionalidad);
                MySqlParameter apenombre = new MySqlParameter("paramApenom",apenom);
                cmd.Parameters.Add(apenombre);

                cmd.ExecuteNonQuery();

                closeConnection();
                return (int)idAutor.Value;
            }
            return 0;
           

        }
        public int altaLibro(string tit, string gen, string _isbn,int cantEjemplares,int autor,string ed)
        {
            if (openConnection())
            {
                cmd = new MySqlCommand();
                cmd.CommandText = "altaLibro";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                // parametro de salida 
                MySqlParameter idLibro = new MySqlParameter("paramId", MySqlDbType.Int32);
                idLibro.Direction = ParameterDirection.Output;
                idLibro.Value = 0;
                cmd.Parameters.Add(idLibro);

                MySqlParameter titulo = new MySqlParameter("paramTitulo",tit);
                cmd.Parameters.Add(titulo);
                MySqlParameter genero = new MySqlParameter("paramGenero", gen);
                cmd.Parameters.Add(genero);
                MySqlParameter isbn = new MySqlParameter("paramIsbn", _isbn);
                cmd.Parameters.Add(isbn);
                MySqlParameter ejemplares = new MySqlParameter("paramEjemplar", cantEjemplares);
                cmd.Parameters.Add(ejemplares);
                MySqlParameter idAutor = new MySqlParameter("paramId_Autor", autor);
                cmd.Parameters.Add(idAutor);
                MySqlParameter editorial = new MySqlParameter("paramEditorial", ed);
                cmd.Parameters.Add(editorial);
               

                cmd.ExecuteNonQuery();

                closeConnection();

                return (int)idLibro.Value;
            }
            return 0;
        }
        
        public DataTable cargarLibros()
        {
            openConnection();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "recuperarLibros"; 
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "libros");
            DataTable dt = ds.Tables["libros"];
            closeConnection();
            return dt;
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
