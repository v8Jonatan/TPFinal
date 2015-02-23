using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;



namespace RN
{
    public abstract class Socio
    {

        private int id;
        private string correo;
        private string nombre;
        private string apellido;
        private int telefono;
        private int dni;
        List<Prestamo> prestamos; //Tanto vigentes como no vigentes. Para saber los vigentes se debe verificar Prestamo.Devolucion
        List<Reserva> reservas;

        public Socio(int ident, string c, string nom, string ape, int tel, int dni)
        {
            id = ident;
            correo = c;
            nombre = nom;
            apellido = ape;
            telefono = tel;
            this.dni = dni;
            prestamos = new List<Prestamo>();
            reservas = new List<Reserva>();
        }
        public abstract DateTime fechaDevolucion(DateTime fechaInicio);
       
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
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

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public List<Prestamo> Prestamos
        {
            get { return prestamos; }
            set { prestamos = value; }
        }

        public List<Reserva> Reservas
        {
            get { return reservas; }
            set { reservas = value; }
        }
        public abstract string getTipo();

        ~Socio()
        {

        }

    }

}