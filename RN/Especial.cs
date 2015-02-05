using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RN
{
    public class Especial : Socio
    {
        private static int diasRetiro =5;

        public Especial(int ident, string c, string nom, string ape, int tel, int dni):base(ident, c, nom, ape, tel, dni)
        {
            
		}
        public override string getTipo()
        {
            return "ESPECIAL";
        }

    }
}
