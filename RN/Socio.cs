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
using System.Data;



namespace RN {
	public abstract class Socio {

        private int id;
        private string correo;
		private string nombre;
        private string apellido;
        private int telefono;
        private int dni;

        
        

        public Socio(int ident, string c, string nom, string ape, int tel, int dni)
        {
            id = ident;
            correo = c;
            nombre = nom;
            apellido = ape;
            telefono = tel;
            this.dni = dni;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Dni
        {
            get { return dni; }
        }
        public string Correo
        {
            get { return correo; }
        }
        public string Nombres
        {
            get { return nombre; }
        }
        public string Apellido
        {
            get { return apellido; }
        }
      
        public int Telefono
        {
            get { return telefono; }
        }
        public abstract string getTipo();
        
		~Socio(){

		}

	}//end Socio

}//end namespace Clases