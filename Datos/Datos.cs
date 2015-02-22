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
            cmd.CommandText = "recuperarSocios2";
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

        public List<AutorDO> cargarAutores()
        {
            openConnection();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "recuperarAutores";
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "autores");
            DataTable dt = ds.Tables["autores"];
            closeConnection();

            AutorDO a, a2;
            a = new AutorDO();
            List<AutorDO> autores = new List<AutorDO>();
            foreach (DataRow row in dt.Rows)
            {
                a.Codigo = row.Field<int>("id_autor");
                a.Apenom = row.Field<string>("apenom");
                a.Nacionalidad = row.Field<string>("nacionalidad");
                a2 = new AutorDO(a.Codigo, a.Apenom, a.Nacionalidad);
                autores.Add(a2);
            }
            return autores;
        }

        public List<ReservaDO> cargarReservas()
        {
            openConnection();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "recuperarAutores";
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "reservas");
            DataTable dt = ds.Tables["reservas"];
            closeConnection();

            ReservaDO r, r2;
            r = new ReservaDO();
            List<ReservaDO> reservas = new List<ReservaDO>();
            foreach (DataRow row in dt.Rows)
            {
                r.Codigo = row.Field<int>("id_reserva");
                r.Libro = row.Field<int>("id_libro");
                r.Ejemplar = row.Field<int>("id_ejemplar");
                r.Socio = row.Field<int>("id_socio");
                r.FechaRetiro = row.Field<DateTime>("fechaRetiro");
                r.FechaReserva = row.Field<DateTime>("fechaReserva");
                r.Retirado = row.Field<bool>("retirado");
                r2 = new ReservaDO(r.Codigo, r.Libro, r.Ejemplar, r.Socio, r.FechaRetiro, r.FechaReserva, r.Retirado);
                reservas.Add(r2);
            }
            return reservas;
        }

        public List<PrestamoDO> cargarPrestamos()
        {
            openConnection();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "recuperarPrestamos";
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "prestamos");
            DataTable dt = ds.Tables["prestamos"];
            closeConnection();

            PrestamoDO p, p2;
            p = new PrestamoDO();
            List<PrestamoDO> prestamos = new List<PrestamoDO>();
            foreach (DataRow row in dt.Rows)
            {
                p.Codigo = row.Field<int>("id_prestamo");
                p.Socio = row.Field<int>("id_socio");
                p.FechaInicio = row.Field<DateTime>("fechaInicio");
                p.FechaVencimiento = row.Field<DateTime>("fechaVencimiento");
                p.Devolucion = row.Field<bool>("devolucion");
                p2 = new PrestamoDO(p.Codigo, p.Socio, p.FechaInicio, p.FechaVencimiento, p.Libro);
                prestamos.Add(p2);
            }
            return prestamos;
        }

        public List<LibroDO> cargarLibros()
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

            LibroDO l, l2;
            l = new LibroDO();
            List<LibroDO> libros = new List<LibroDO>();
            foreach (DataRow row in dt.Rows)
            {
                l.Codigo = row.Field<int>("id_Libro");
                l.Autor = row.Field<int>("id_autor");
                l.Titulo = row.Field<string>("titulo");
                l.Genero = row.Field<string>("genero");
                l.Editorial = row.Field<string>("editorial");
                l.Isbn = row.Field<int>("ISBN");
                l2 = new LibroDO(l.Codigo, l.Autor, l.Titulo, l.Genero, l.Isbn, l.Editorial);
                libros.Add(l2);
            }
            return libros;
        }

        public int altaLibro(string tit, string gen, string _isbn,int cantEjemplares,int autor)
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

                cmd.ExecuteNonQuery();

                closeConnection();

                return (int)idLibro.Value;
            }
            return 0;
        }
        
        
    }

}
