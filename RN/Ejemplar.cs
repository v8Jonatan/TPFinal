using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace RN {
	public class Ejemplar {

		private int numero;
        private Libro libro;
        private string estadoActual;

		public Ejemplar(int nro, Libro l, string ea)
        {
            numero = nro;
            libro = l;
            estadoActual = ea;
		}

        public Ejemplar(int nro, string ea)
        {
            numero = nro;
            estadoActual = ea;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public Libro Libro
        {
            get { return libro; }
            set { libro = value; }
        }
        public string EstadoActual
        {
            get { return estadoActual; }
            set { estadoActual = value; }
        }

		~Ejemplar(){

		}

	}//end Ejemplar

}//end namespace Clases