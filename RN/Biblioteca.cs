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

        //Caso de Uso 1 Agregar Socio
        public  Socio buscarDni(int dni)
        {
            return socios.Find(x => x.Dni==dni);
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
                if(ns.Id!=0) //borrar este condicional una vez hecha exception en clase datos
                    socios.Add(ns);
            }
            else
            {
                throw new Exception("El socio ya existe");
            }

            
        }
        
        public Biblioteca recuperarse()
        {
            Biblioteca biblioteca = new Biblioteca();
            Datos.Datos d = new Datos.Datos();
            biblioteca.recuperarSocios(d.cargarSocios());
            //biblioteca.recuperarLibros(d.cargarLibros());
            //biblioteca.recuperarReservas(d.cargarReservas());
            //biblioteca.recuperarPrestamos(d.cargarPrestamos());
            //biblioteca.recuperarAutores(d.cargarAutores());

            return biblioteca;
        }
          
          
        public void recuperarSocios(DataTable dt)
        {
            Socio s;
            int id;
            int dni;
            string apellido;
            string nombres;
            int telefono;
            string correo;

            foreach(DataRow row in dt.Rows)
            {
                id = row.Field<int>("id_socio");
                dni = row.Field<int>("DNI");
                apellido = row.Field<string>("apellido");
                nombres = row.Field<string>("nombres");
                telefono = row.Field<int>("telefono");
                correo = row.Field<string>("email");
                if (row.Field<string>("tipo").Trim().Equals("COMUN"))
                    s = new Comun(id, correo, nombres, apellido, telefono, dni);
                else
                    s = new Especial(id, correo, nombres, apellido, telefono, dni);
                socios.Add(s);
            }
        }

        public void recuperarLibros(DataTable dt)
        {
            Libro l;
            int codigo;
            string autor;
            string titulo;
            string genero;
            int isbn;
            string editorial;
            foreach (DataRow row in dt.Rows)
            {
                codigo = row.Field<int>("id_libro");
                titulo = row.Field<string>("titulo");
                genero = row.Field<string>("genero");
                isbn = row.Field<int>("ISBN");
                editorial = row.Field<string>("editorial");
                autor = row.Field<string>("apenom");
                l = new Libro(codigo, autor, titulo, genero, isbn, editorial);
                libros.Add(l);
            }
        }

        public void recuperarReservas()
        {

        }

        public void recuperarPrestamos()
        {

        }

        public void recuperarAutores()
        {

        }
 
    }
}
