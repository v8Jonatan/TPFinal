using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RN
{
    public class Autor
    {
        private int codigo;
        private string apenom;
        private string nacionalidad;
        private List<Libro> libros;

        public Autor(int cod, string an, string nac)
        {
            codigo = cod;
            apenom = an;
            nacionalidad = nac;
            libros = new List<Libro>();
        }
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
        public List<Libro> Libros
        {
            get { return libros; }
            set { libros = value; }
        }
    }
}
