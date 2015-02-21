using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
namespace RN
{
    public class Biblioteca
    {
        private List<Socio> socios;
        private List<Libro> libros;
        private List<Reserva> reservas;
        private List<Prestamo> prestamos;
        private List<Autor> autores;


        public Biblioteca()
        {
            socios = new List<Socio>();
            libros = new List<Libro>();
            reservas = new List<Reserva>();
            prestamos = new List<Prestamo>();
            autores = new List<Autor>();
        }
        public List<Socio> Socios
        {
            get { return socios; }
            set { socios = value; }
        }
        public List<Libro> Libros
        {
            get { return libros; }
            set { libros = value; }
        }
        public List<Reserva> Reservas
        {
            get { return reservas; }
            set { reservas = value; }
        }
        public List<Prestamo> Prestamos
        {
            get { return prestamos; }
            set { prestamos = value; }
        }
        public List<Autor> Autores
        {
            get { return autores; }
            set { autores = value; }
        }

        //Caso de Uso 1 Agregar Socio
        public Socio buscarDni(int dni)
        {
            return socios.Find(x => x.Dni == dni);
        }

        public Socio buscarNroSocio(int nroSocio)
        {
            return socios.Find(x => x.Id == nroSocio);
        }

        /*El metodo toma los datos por parametro
        * Buscamos al socio por dni primero para ver si ya existe despues lo agregamos a la 
        * base de datos y recuperamos el mismo como objeto para traer el idSocio (que es autonumerico)
        */
        public void agregarSocio(Socio ns)
        {
            //busca el socio podemos hacer una funcion para recorrer el list
            Socio socioAntiguo = socios.Find(x => x.Dni == ns.Dni);
            if (socioAntiguo == null)
            {
                // este metodo se podria mejorar capaz haciendo dos metodos distintos por que 
                // asi como esta hace el insert y tambien asigna el id que recupera de la base de datos

                //(Sebas) Me parece que está perfecto así, ya que usamos funciones diferentes por cada caso de uso. A menos que necesitemos reutilizar, sino no.
                Datos.Datos d = new Datos.Datos();
                ns.Id = d.altaSocio(ns.Nombres, ns.Apellido, ns.Correo, ns.Telefono, ns.Dni, ns.getTipo());
                if (ns.Id != 0) //borrar este condicional una vez hecha exception en clase datos
                    socios.Add(ns);
            }
            else
            {
                throw new Exception("El socio ya existe");
            }


        }
        // me parece buena idea usar para las altas stored procedures y
        // hacer todo lo de recuperar de la bd con linq todavia no probe ninguno
        // pero podriamos hacer objetos de datos para enviarlos desde la capa datos
        //algo asi como una estructura
        public Biblioteca recuperarse()
        {
            Biblioteca biblioteca = new Biblioteca();
            Datos.Datos d = new Datos.Datos();
            
           // biblioteca.Socios = d.cargarSocios();
            Socio socio;
            foreach( SocioDO s in d.cargarSocios())
            {
                if(s.Tipo.Equals("COMUN"))
                    socio = new Comun(s.Id,s.Correo,s.Nombres,s.Apellido,s.Telefono,s.Dni);
                else 
                    socio = new Especial(s.Id, s.Correo, s.Nombres, s.Apellido, s.Telefono, s.Dni);

                biblioteca.Socios.Add(socio);
            }
            /*
            biblioteca.Libros = d.cargarLibros();
            biblioteca.Reservas = d.cargarReservas();
            biblioteca.Prestamos = d.cargarPrestamos();
            biblioteca.Autores = d.cargarAutores();
            */
            return biblioteca;
        }



        public void agregarLibro(Libro l)
        {
            /*  buscamos el libro por si ya existe por isbn
             *  si isbn es " " u otra forma de  
             *  identificar cuando el libro no posee ISBN, va a considerarse que el libro no existe
             */
            Libro libro = buscarLibro(l);
            if (libro != null)
            {
                throw new Exception("El libro ISBN= " + libro.Isbn + ", Titulo: " + libro.Titulo + " ya existe");
            }
            else
            {
                libro = l;
                Datos.Datos d = new Datos.Datos();
                d.altaLibro(libro.Titulo,libro.Genero,libro.Isbn,libro.Ejemplares.Count,1);

            }

        }
        private Libro buscarLibro(Libro l)
        {
            //posibidad de buscar por otro atributo tambien
            
            if (l.Isbn == " ")//identificar ausencia de isbn
            {
                l = null;
            }
            else
            {
                l = libros.Find(x => x.Isbn == l.Isbn);

            }
            return l;

        }
        

        // este es uno de prueba que hice yo
        public void cargarse()
        {


            recuperarSocios();

        }
        //Asi me quedo usando una forma parecida a lo que haciamos en clase
        private void recuperarSocios()
        {
            Datos.Datos d = new Datos.Datos();
            List<String> datos = d.recuperarSocios(); // este metodo devuelve todo en string 

            Socio s;
            for (int i = 0; i < datos.Count - 6; i += 7)
            {
                if (datos[i + 5].Equals("COMUN"))
                {
                    s = new Comun(int.Parse(datos[i]), datos[i + 6], datos[i + 3], datos[i + 2], int.Parse(datos[i + 4]), int.Parse(datos[i + 1]));
                }
                else
                {
                    if (datos[i + 5].Equals("ESPECIAL"))
                        s = new Especial(int.Parse(datos[i]), datos[i + 6], datos[i + 3], datos[i + 2], int.Parse(datos[i + 4]), int.Parse(datos[i + 1]));
                    else
                        s = null;
                }
                if (s != null)
                    socios.Add(s);
            }


        }
    }
}
