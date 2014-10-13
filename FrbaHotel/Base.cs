using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DOM;
using DOM.Dominio;
namespace FrbaHotel
{
    public class Base
    {
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="opciones"></param>
        
        public static void cargarEnComboBox(ComboBox combo, List <Object>opciones)
        {
           foreach(Object opcion in opciones ){
               combo.Items.Add(opcion);
           }
       }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unDataGrid"></param> la grilla de datos a mostrar
        /// <param name="consultaSelect"></param> la consulta de todos los campos de la tabla -->select * from tabla......LIKE
        /// <param name="con"></param> Conexion con la base de datos
       public static void cargarEnDataGridView(DataGridView unDataGrid,string consultaSelect) {


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



    }
}
