using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public class PrestamoDO
    {
        private int codigo;
        private int socio;
        private DateTime fechaInicio;
        private DateTime fechaVencimiento;
        private bool devolucion;
        private int libro;

        public PrestamoDO(int cod, int s, DateTime fi, DateTime fv, int l)
        {
            codigo = cod;
            socio = s;
            fechaInicio = fi;
            fechaVencimiento = fv;
            devolucion = false;
            libro = l;
        }
        public PrestamoDO() { }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Socio
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
        public int Libro
        {
            get { return libro; }
            set { libro = value; }
        }
    }
}
