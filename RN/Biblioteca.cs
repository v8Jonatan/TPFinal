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
        public  Socio buscarDni(int dni)
        {
            return socios.Find(x => x.Dni==dni);
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
        
        /*public Biblioteca cargarse()
        {
            Biblioteca biblioteca = new Biblioteca();

        }*/
    }
}
