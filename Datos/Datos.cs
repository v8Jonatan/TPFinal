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
        BibLiOtEcA db;

        public Datos()
        {
            //Conexion para mysql con stored procedures
             //strcon = "server=umsebastianbd.ddns.net;user id=v8jonatan;database=biblioteca;pwd=v8jonatan";
             strcon="server=localhost;user id=v8jonatan;database=biblioteca;pwd=v8jonatan"; 
             con = new MySqlConnection(strcon);
             /*
             //Conexion para linq
             string dbServer = Environment.GetEnvironmentVariable("DbLinqServer") ?? "umsebastianbd.ddns.net";
             // BUG: El contexto debe ser desechable
             string connStr = String.Format("server={0};user id={1}; password={2}; database={3}"
                 , dbServer, "SebastianF", "thiago1311", "biblioteca");
             db = new BibLiOtEcA(new MySqlConnection(connStr));
             */
            
            
             string dbServer = Environment.GetEnvironmentVariable("DbLinqServer") ?? "localhost";
            // BUG: El contexto debe ser desechable
            string connStr = String.Format("server={0};user id={1}; password={2}; database={3}"
                , dbServer, "v8jonatan", "v8jonatan", "biblioteca");
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

        public List<SocioDO> cargarSocios()
        {
            /*Acá no sé como usar el list<>´porque no me funciona
             * castear la lista tipo object. Igualmente una solucion
             * seria usar Arraylist como vimos en clase. Pero es dificil 
             * hacerlo asi que iba a preguntarte como era la forma que
             * usaste vos en tu programa
             */

            /*
             * Yo estaba usando los objetos que te crea linq solo y creo que con 
             * este linq para mysql tambien te los crea solo 
             * pero podriamos usar unos objetos de la clase datos dejo un ejemplo c
             * con el socio SocioDO dataobject 
             */

              List<SocioDO> socios = new List<SocioDO>();
            //Vale por codigo linq para rescatar los socios de la bd

/*            var socios =   from s in db.SoCIoS
                           from u in db.UsUarIoS
                           where s.IDSoCIo==u.IDSoCIo
                           select new  SocioDO(s.IDSoCIo,(int)s.TeLEFOnO,s.DNi,u.Email,s.NoMbReS,s.ApeLLido,s.TipO);
 */
            var consulta = from s in db.SoCIoS

                         select s;

            
                           

            SocioDO so;
            foreach (var s in consulta)
            {
                var consulta2 = from u in db.UsUarIoS
                                where u.IDSoCIo==s.IDSoCIo
                                select u;

                so = new SocioDO(s.IDSoCIo, (int)s.TeLEFOnO, s.DNi,consulta2.FirstOrDefault().Email,s.NoMbReS, s.ApeLLido, s.TipO);
                socios.Add(so);
            }


            return socios;
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
        // devolver un array posibilidad de devolver un objeto de datos
        public List<String> recuperarSocios()
        {
            MySqlDataAdapter da;
            DataTable dt;
            List<String> lista = new List<string>();
            if (openConnection())
            {
                cmd = new MySqlCommand();
                cmd.CommandText = "recuperarSocios";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {

                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        lista.Add(row.ItemArray[i].ToString());
                    }

                }

            }
            return lista;

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
