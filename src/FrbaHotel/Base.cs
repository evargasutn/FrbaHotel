﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DOM;
using DOM.Dominio;
using System.Security.Cryptography;
namespace FrbaHotel
{
    public class Base
    {
       
        /// <summary>
        /// ////
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="opciones"></param>
        
        public static void cargarEnComboBox(ComboBox combo, List <Object>opciones)
        {
           foreach(Object opcion in opciones ){
               combo.Items.Add(opcion);
           }
       }

        
        public string pasarASha256(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();
            ///transforma a secuencia de bytes,codificacion
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            ///calcula a valor hash
            byte[] hashedBytes = provider.ComputeHash(inputBytes);
            /// cadena de caracteres modificable
            StringBuilder output = new StringBuilder();
            ///formatea como string hex,anexa el valor hash.
            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());
            return output.ToString();
        }

        public static void cargarEnDataGridView(DataGridView unDataGrid, string consultaSelect)
        {

           SqlConnection con = new SqlConnection(@""+ Globals.getConnectionString()+""  );
           con.Open();
           SqlCommand cmd = con.CreateCommand();
           cmd.CommandType = CommandType.Text;
           cmd.CommandText = consultaSelect;
           DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(dt);
           unDataGrid.DataSource = dt;
           con.Close();    
       }
       public static void establecerVentanaAnterior(Form ventanaAVolver)
       {
           Globals.VentanaAnterior = ventanaAVolver;
           ventanaAVolver.Enabled = false;
       
       }


    }
}
