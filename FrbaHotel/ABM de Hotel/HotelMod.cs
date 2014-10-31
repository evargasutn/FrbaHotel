using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class HotelMod : Form
    {
        public HotelMod()  // para llevarse a cabo una modificacion del regimen(darlo de baja)
        {                  // se debe tener en cuenta que no debe haber reservas ni huespedes 
            InitializeComponent();//alojadoas en el hotel con dicho regimen
        }
    }
}
