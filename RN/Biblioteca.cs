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



        public Biblioteca()
        {
            socios = new List<Socio>();
            libros = new List<Libro>();
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
                ns.Id = Datos.Datos.altaSocio(ns.Nombres, ns.Apellido, ns.Correo, ns.Telefono, ns.Dni, ns.getTipo());
                socios.Add(ns);
            }
            else
            {
                throw new Exception("El socio ya existe");
            }

            
        }
    }
}
