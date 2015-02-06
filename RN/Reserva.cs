using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RN
{
    public class Reserva
    {
        private int codigo;
        private Ejemplar ejemplar;
        private Socio socio;
        public DateTime fechaRetiro;
        public DateTime fechaReserva;
        public bool retirado; //En la base de datos se guarda 0=false, 0!= true;

        public Reserva(int c,Ejemplar ej, Socio s, DateTime fret, DateTime freser)
        {
            codigo = c;
            ejemplar = ej;
            socio = s;
            fechaRetiro = fret;
            fechaReserva = freser;
            retirado = false;
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public Ejemplar Ejemplar
        {
            get { return ejemplar; }
            set { ejemplar = value; }
        }
        public Socio Socio
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
