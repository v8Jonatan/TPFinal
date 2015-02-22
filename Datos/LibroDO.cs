using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public class LibroDO
    {
        private int codigo;
        private int autor;
        private string titulo;
        private string genero;
        private int isbn;
        private string editorial;

        public LibroDO(int cod, int a, string t, string g, int isbn, string ed)
        {
            codigo = cod;
            autor = a;
            titulo = t;
            genero = g;
            this.isbn = isbn;
            editorial = ed;
        }
        public LibroDO() {  }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }
    }
}
