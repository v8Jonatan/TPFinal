using System;
using System.Collections.Generic;
using System.Text;
using System.IO;




namespace RN {
	public class Comun : Socio {

        // los 
		private static int diasRetiro=3;

        public Comun(int ident, string c, string nom, string ape, int tel,int dni):base(ident,c,nom,ape,tel,dni)
        {

		}
        public override string getTipo()
        {
            return "COMUN"; 
        }


		~Comun(){

		}

	}

}