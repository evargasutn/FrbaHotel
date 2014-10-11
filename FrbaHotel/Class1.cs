using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace FrbaHotel
{
    class Class1
    {
       public static void cargarEnComboBox(ComboBox combo, List <object>opciones)
        {
           foreach( object opcion in opciones ){
               combo.Items.Add(opcion);

           }
       
       }


    }
}
