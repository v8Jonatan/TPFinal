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
        private DateTime fechaRetiro;
        private DateTime fechaReserva;
        private bool retirado; //En la base de datos se guarda 0=false, 0!= true;

        public Reserva(int c,Ejemplar ej, Socio s, DateTime fret, DateTime freser)
        {
            codigo = c;
            ejemplar = ej;
            socio = s;
            fechaRetiro = fret;
            fechaReserva = freser;
            retirado = false;
        }

        // version 2
        public Boolean disponibleEjemplar(DateTime fechaIni, DateTime fechDev)
        {
            // version 1 (borrada )servia para reservar hoy
            // version 2 deberia servir para hoy o cualquier dia
            // si reserva caduco la reserva ya paso la fecha de la reserva
            if (fechaReserva < DateTime.Now)
            {
                return true;
            }
            else // 1 comprobar que la fechaDev sea menor a la fecha reserva entonces disponible 
            {
                if (fechDev < fechaReserva)
                {
                    return true;
                }
                else
                {
                    // si fecha de inicio es despues de fechaReserva hay dos casos
                    // caso 1 : el socio es comun y si retirara el libro no esta disponible hasta 3 dias despues de la reserva
                    //caso 2:el socio es especial y si retirara el libro no esta disponible hasta 5 dias despues de la reserva

                    if (fechaIni > fechaReserva)
                    {
                        //caso 1 resuelve caso 2 tambien
                        DateTime fechaDisponible = socio.fechaDevolucion(fechaReserva);
                        if (fechaIni > fechaDisponible)
                            return true;
                        else
                            return false;

                    }
                    else
                    {
                        return false;
                    }
                
                }


            }
            

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
