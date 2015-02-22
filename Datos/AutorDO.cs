using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public class AutorDO
    {
        private int codigo;
        private string apenom;
        private string nacionalidad;

        public AutorDO(int cod, string an, string nac)
        {
            codigo = cod;
            apenom = an;
            nacionalidad = nac;
        }

        public AutorDO() { }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Apenom
        {
            get { return apenom; }
            set { apenom = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
    }
}
