using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace FrbaHotel
{
    public class Base
    {
       public static void cargarEnComboBox(ComboBox combo, List <Object>opciones)
        {
           foreach(Object opcion in opciones ){
               combo.Items.Add(opcion);

           }
       
       }


    }
}
