using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public class EjemplarDO
    {
        private int numero;
        private int libro;
        private string estadoActual;

		public EjemplarDO(int nro, int l, string ea)
        {
            numero = nro;
            libro = l;
            estadoActual = ea;
		}

        public EjemplarDO(){  }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Libro
        {
            get { return libro; }
            set { libro = value; }
        }
        public string EstadoActual
        {
            get { return estadoActual; }
            set { estadoActual = value; }
        }
    }
}
