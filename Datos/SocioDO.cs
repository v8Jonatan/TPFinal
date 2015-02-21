using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public class SocioDO
    {
        // socioDataObject 
        private int id;
        private string correo;
        private string nombre;
        private string apellido;
        private int telefono;
        private int dni;
        private string tipo;

        public SocioDO(int ident,int tel,int dni,string c,string nom,string ape,string t)
        {
            
        
            id = ident;
            correo = c;
            nombre = nom;
            apellido = ape;
            telefono = tel;
            this.dni = dni;
            tipo = t;
        
        }

        public SocioDO() { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni=value;}
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Nombres
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Tipo
        {
            get { return Tipo; }
            set { tipo = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
