using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public class ReservaDO
    {
        private int codigo;
        private int libro;
        private int ejemplar;
        private int socio;
        private DateTime fechaRetiro;
        private DateTime fechaReserva;
        private bool retirado; //En la base de datos se guarda 0=false, 0!= true;

        public ReservaDO(int c,int l, int ej, int s, DateTime fret, DateTime freser, bool r)
        {
            codigo = c;
            libro = l;
            ejemplar = ej;
            socio = s;
            fechaRetiro = fret;
            fechaReserva = freser;
            retirado = r;
        }
        public ReservaDO() { }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Libro
        {
            get { return libro; }
            set { libro = value; }
        }
        public int Ejemplar
        {
            get { return ejemplar; }
            set { ejemplar = value; }
        }
        public int Socio
        {
            get { return socio; }
            set { socio = value; }
        }
        public DateTime FechaRetiro
        {
            get { return fechaRetiro; }
            set { fechaRetiro = value; }
        }
        public DateTime FechaReserva
        {
            get { return fechaReserva; }
            set { fechaReserva = value; }
        }
        public bool Retirado
        {
            get { return retirado; }
            set { retirado = value; }
        }

    }
}
