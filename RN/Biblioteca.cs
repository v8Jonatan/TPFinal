using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RN
{
    public class Biblioteca
    {
        private List<Socio> socios;
        private List<Libro> libros;
        

        //Caso de Uso 1 Agregar Socio
        private Socio buscarDni(int dni)
        {
           
            return socios.Find(x => x.Dni==dni);

        }
        
        /*El metodo toma los datos por parametro
         * Buscamos al socio por dni primero para ver si ya existe despues lo agregamos a la 
         * base de datos y recuperamos el mismo como objeto para traer el idSocio (que es autonumerico)
         */
        public void agregarSocio(int dni)
        {
            Socio socioAntiguo = socios.Find(x => x.Dni == dni);
            if (socioAntiguo != null)
            {


            }
            else
            {

            }

            
        }
    }
}
