using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

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
        public List<Libro> buscarLibro(string busqueda,string tipo)
        {
            List<Libro> lista = new List<Libro>();
            foreach (Libro l in libros)
            {
                if (l.like(busqueda))
                    lista.Add(l);
            }
            return lista;
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

        public void agregarSocio(Socio ns)
        {
            Socio socioAntiguo = socios.Find(x => x.Dni == ns.Dni);
            if (socioAntiguo == null)
            {
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

        // Reserva si para la fecha de reserva libro no esta reservado o entra en conflicto con un reserva
        // Version 1 No revisa si el ejemplar esta prestado actualmente
        // Para la web tener un metodo que me permite ver las reservas disponibles de un libro
        // Otro posible metodo reserva la fecha de reserva posible mas proxima 
        public void reservar(Socio s , int codLibro, DateTime fechaReserva)
        {
            Libro libro = libros.Find(x => x.Codigo == codLibro);
            Reserva reserva;
            Datos.Datos d = new Datos.Datos();
            if (libro != null)
            {

                // buscar el primer ejemplar disponible
                int i=0;
                bool disponible=false;
                DateTime fechaDev = s.fechaDevolucion(fechaReserva);
                while(i< libro.Ejemplares.Count && !disponible)
                {
                    // al iniciar se supone disponible
                    disponible=true;
                    foreach (Reserva r in reservas)
                    {
                        //si al menos una reserva lo pone en no disponible
                        if (!r.disponibleEjemplar(fechaReserva,fechaDev))
                            disponible = false;
                    }
                    if(!disponible)
                        i++;// para que no se pase el indice
                }
                if(disponible)
                {
                   //Realizo la reserva
                }
            }

        }


        //Jony, disculpame si modifica mucho, pero le agregué a socios una lista con los prestamos vigentes para facilitar el ver prestamos
        public void RealizarPrestamo(int codLibro,Socio s)
        {
            // Metodo para traer los buscar un ejemplar disponible.
            // Version 2 si ejemplar disponible y ninguna reserva impide el prestamo
            // sig version recorrer todos los ejemplares posible
            Libro libro = libros.Find(x => x.Codigo == codLibro);
            Prestamo prestamo;
            Datos.Datos d= new Datos.Datos();
            if (libro == null)
            {
                libro = new Libro("conejo", "ge", "555", "ateneo", 4);
                libro.Codigo = 3;
                libros.Add(libro);
            }
            if (libro != null)
            {
                Ejemplar ejemplar= libro.disponible();
                if (ejemplar != null)
                {
                    DateTime hoy = DateTime.Now;
                    DateTime fechaDev = s.fechaDevolucion(hoy);

                    bool disponible = true;
                    // comprueba que ninguna reserva impide prestar el ejemplar
                     foreach (Reserva r in reservas)
                     {
                         if (r.Ejemplar.Equals(ejemplar))
                         {
                             if(! r.disponibleEjemplar(hoy, s.fechaDevolucion(hoy)) )
                             {
                                 disponible = false;
                             }
                         }

                     }
                     if (disponible)
                     {
                         prestamo = new Prestamo(0, s, hoy, fechaDev, ejemplar);
                         prestamo.Codigo = d.altaPrestamo(s.Id, hoy, fechaDev, ejemplar.Libro.Codigo, ejemplar.Numero);
                         ejemplar.EstadoActual = "PRESTADO";
                         prestamos.Add(prestamo);
                     }

                }
                else
                {
                    // avisar ejemplares no disponibles
                }
               
            }

        }

        public Biblioteca recuperarse()
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Socios = recuperarSocios();
            biblioteca.Autores = recuperarAutores();
            biblioteca.Libros = recuperarLibros();
            recuperarEjemplares();
            biblioteca.Reservas = recuperarReservas();
            biblioteca.Prestamos = recuperarPrestamos();
            return biblioteca;
        }

        public List<Socio> recuperarSocios()
        {
            List<Socio> lista = new List<Socio>();
            Socio socio;
            Datos.Datos d = new Datos.Datos();
            //Se encarga de cargar los socios
            foreach (SocioDO s in d.cargarSocios())
            {
                if (s.Tipo.Equals("COMUN"))
                    socio = new Comun(s.Id, s.Correo, s.Nombres, s.Apellido, s.Telefono, s.Dni);
                else
                    socio = new Especial(s.Id, s.Correo, s.Nombres, s.Apellido, s.Telefono, s.Dni);

                lista.Add(socio); //Le falta agregar los reservas
            }
            return lista;
        }

        public List<Autor> recuperarAutores()
        {
            List<Autor> lista = new List<Autor>();
            Autor autor;
            Datos.Datos d = new Datos.Datos();
            foreach (AutorDO a in d.cargarAutores())
            {
                autor = new Autor(a.Codigo,a.Apenom,a.Nacionalidad);
                lista.Add(autor); 
            }
            //Carga autores pero todavía no le pongo  los libros
            return lista;
        }

        public List<Libro> recuperarLibros()
        {
            List<Libro> lista = new List<Libro>();
            Libro libro;
            Autor aux;
            Datos.Datos d = new Datos.Datos();
            //Este foreach se encarga de cargar libros sin ejemplares
            foreach (LibroDO l in d.cargarLibros())
            {
                libro = new Libro(l.Codigo, l.Titulo, l.Genero, l.Isbn, l.Editorial);
                aux = autores.Find(x => x.Codigo == l.Autor);
                libro.Autor = aux;          //Al libro le pongo el autor
                aux.Libros.Add(libro);      //Al autor le pongo el libro en su lista
                lista.Add(libro);           //Lista que contiene todos los libros
            }
            return lista;
        }

        public void recuperarEjemplares()
        {
            //Este foreach se encarga de cargar los ejemplares y el libro correspondiente
            //Asi como tambien agregarle a los libros sus ejemplares
            Ejemplar ej;
            Datos.Datos d = new Datos.Datos();
            foreach (EjemplarDO ejem in d.cargarEjemplares())
            {
                Libro libro = libros.Find(x => x.Codigo == ejem.Libro);
                ej = new Ejemplar(ejem.Numero, libro , ejem.EstadoActual);
                libro.Ejemplares.Add(ej);
            }
        }

        public List<Prestamo> recuperarPrestamos()
        {
            List<Prestamo> lista = new List<Prestamo>();
            Prestamo prestamo;
            Socio s;
            Ejemplar ej;
            Libro l;
            Datos.Datos d = new Datos.Datos();
            foreach(PrestamoDO p in d.cargarPrestamos())
            {
                s = socios.Find(x => x.Id == p.Socio);          //Busco al socio correspondiente al prestamo
                l = libros.Find(x => x.Codigo == p.Libro);      //Busco el libro correspondiente
                ej = l.Ejemplares.Find(x => x.Numero == p.Ejemplar);        //Busco el ejemplar
                prestamo = new Prestamo(p.Codigo, s, p.FechaInicio, p.FechaVencimiento, ej);  
                prestamo.Devolucion = p.Devolucion;             //Pongo si fue devuelto o no ya que el inicializador pone false
                s.Prestamos.Add(prestamo);              //Agrego el prestamo al socio
                lista.Add(prestamo);                    //Agrego a la lista de la biblioteca
            }
            return lista;
        }

        public List<Reserva> recuperarReservas()
        {
            List<Reserva> lista = new List<Reserva>();
            Reserva reserva;
            Socio s;
            Ejemplar ej;
            Libro l;
            Datos.Datos d = new Datos.Datos();
            foreach(ReservaDO r in d.cargarReservas())
            {
                s = socios.Find(x => x.Id == r.Socio);      //Busco socio
                l = libros.Find(x => x.Codigo == r.Libro);  //Busco libro
                ej = l.Ejemplares.Find(x => x.Numero == r.Ejemplar);    //Busco ejemplar (se necesita para reserva)
                reserva = new Reserva(r.Codigo, ej, s, r.FechaReserva, r.FechaRetiro); 
                reserva.Retirado = r.Retirado;  //El inicializador lo pone en false, hay que cargarlo de la bd
                s.Reservas.Add(reserva);    //La agrego a la lista del socio
                lista.Add(reserva);         //La agrego a lista de la biblioteca
            }
            return lista;
        }

        public void agregarAutor(Autor au)
        {
            if (au != null)
            {
                Datos.Datos d = new Datos.Datos();
                au.Codigo = d.altaAutor(au.Nacionalidad,au.Apenom);
                autores.Add(au);
            }
        }
        
        //Caso de uso : Agregar libro

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
                
                l.Codigo=d.altaLibro(libro.Titulo,libro.Genero,libro.Isbn.ToString(),libro.Ejemplares.Count,1,l.Editorial);
                libros.Add(l);

            }

        }
        
        private Libro buscarLibro(Libro l)
        {
            //posibidad de buscar por otro atributo tambien
            
            if (l.Isbn == 0)//identificar ausencia de isbn
            {
                l = null;
            }
            else
            {
                l = libros.Find(x => x.Isbn == l.Isbn);

            }
            return l;

        }

        
 

    }
}
