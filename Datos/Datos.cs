using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
namespace Datos
{
    public class Datos
    {
                
        //duvuelve la Idsocio del socio insertado en la base de datos 
        // todavia no lo probe para ver si funciona
        public static int altaSocio(string noms,string ape,string c,int tel,int dni)
        {
            string strcon="server=umsebastianbd.ddns.net;user id=v8jonatan;database=biblioteca";
            //string strcon="server=localhost;user id=v8jonatan;database=biblioteca"; 
            MySqlConnection con= new MySqlConnection(strcon);
            
            con.Open();
            MySqlCommand cmd= new MySqlCommand();
            cmd.CommandText = "altaSocio";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlParameter idSocio = new MySqlParameter("paramId", MySqlDbType.Int32);
            idSocio.Direction = ParameterDirection.Output;
            idSocio.Value = 0;
            cmd.Parameters.Add(idSocio);
            MySqlParameter nombres= new MySqlParameter("paramNombres",noms);
            cmd.Parameters.Add(nombres);
            MySqlParameter apellido= new MySqlParameter("paramApellido",ape);
            cmd.Parameters.Add(apellido);
            MySqlParameter correo= new MySqlParameter("paramCorreo",c);
            cmd.Parameters.Add(correo);
            MySqlParameter telefono= new MySqlParameter("paramTelefono",tel);
            cmd.Parameters.Add(telefono);
            MySqlParameter dniNuevo= new MySqlParameter("paramDNI",dni);
            cmd.Parameters.Add(dniNuevo);

            cmd.ExecuteNonQuery();
            
            con.Close();
            return (int)idSocio.Value;
         
        }
    }

    
    
    

}
