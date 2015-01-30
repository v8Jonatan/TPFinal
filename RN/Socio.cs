///////////////////////////////////////////////////////////
//  Socio.cs
//  Implementation of the Class Socio
//  Generated by Enterprise Architect
//  Created on:      30-nov-2014 06:37:04 p.m.
//  Original author: jonatan
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace RN {
	public abstract class Socio {

        private int id;
        private string correo;
		private string nombre;
        private string apellido;
        private string telefono;
        private int dni;

        
        

        public Socio(int ident, string c, string nom, string ape, string tel, int dni)
        {
            id = ident;
            correo = c;
            nombre = nom;
            apellido = ape;
            telefono = tel;
            this.dni = dni;
		}
        public int Dni
        {
            get { return dni; }
        }

		~Socio(){

		}

	}//end Socio

}//end namespace Clases