using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;




namespace RN
{
    public class Libro
    {
        private int codigo;
        private Autor autor;
        private string titulo;
        private string genero;
        private int isbn;
        private string editorial;
        private List<Ejemplar> ejemplares;

        public Libro(int cod, Autor a, string t, string g, int isbn, string ed)
        {
            codigo = cod;
            autor = a;
            titulo = t;
            genero = g;
            this.isbn = isbn;
            editorial = ed;
            ejemplares = new List<Ejemplar>();
        }
        public Libro(int cod, string t, string g, int isbn, string ed)
        {
            codigo = cod;
          
            titulo = t;
            genero = g;
            this.isbn = isbn;
            editorial = ed;
            ejemplares = new List<Ejemplar>();
        }

        public Libro(string t, string g, string isbn,string ed, int cantEjemplares)
        {
            titulo = t;
            genero = g;
            editorial = ed;
            this.isbn = int.Parse(isbn);
            ejemplares = new List<Ejemplar>();
            Ejemplar ejem;
            for (int i = 0; i < cantEjemplares; i++)
            {
                ejem = new Ejemplar(i + 1, this, "DISPONIBLE");
                ejemplares.Add(ejem);
            }

        }
        public Ejemplar disponible()
        {
            // buscar un ejemplar disponible 
            int i=0;
            while(i<ejemplares.Count && !ejemplares[i].EstadoActual.Equals("DISPONIBLE"))
            {
                i++;
            }
            if (i == ejemplares.Count)
                return null;
            else
            {
                return ejemplares[i];
            }
        }
        public bool like(string busqueda)
        {

            string[] vacio = { " ", ",", "." };
            string[] palabrasBusqueda = busqueda.Split(vacio, 10, StringSplitOptions.RemoveEmptyEntries);
            string[] palabrasTitulo = titulo.Split(vacio, 10, StringSplitOptions.RemoveEmptyEntries);
            Boolean coincidencia = false;
   
            foreach (string busq in palabrasBusqueda)
            {
                foreach(string tit in palabrasTitulo)
                {
                    if (busq.Equals(tit))
                        coincidencia = true;
                   
                }

                   
            }
            return coincidencia;
               
            }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public Autor Autor
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
        public List<Ejemplar> Ejemplares
        {
            get { return ejemplares; }
            set { ejemplares = value; }
        }


        ~Libro()
        {

        }

    }

}
