using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RN
{
    public class Prestamo
    {
        private int codigo;
        private Socio socio;
        private DateTime fechaInicio;
        private DateTime fechaVencimiento;
        private bool devolucion;
        private Libro libro;

        public Prestamo(int cod, Socio s, DateTime fi, DateTime fv, Libro l)
        {
            codigo = cod;
            socio = s;
            fechaInicio = fi;
            fechaVencimiento = fv;
            devolucion = false;
            libro = l;
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public Socio Socio
        {
            get { return socio; }
            set { socio = value; }
        }
        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        public DateTime FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }
        public bool Devolucion
        {
            get { return devolucion; }
            set { devolucion = value; }
        }
        public Libro Libro
        {
            get { return libro; }
            set { libro = value; }
        }
    }
}
