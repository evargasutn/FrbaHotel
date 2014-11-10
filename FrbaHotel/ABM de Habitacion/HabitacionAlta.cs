using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class HabitacionAlta : Form
    {
        public HabitacionAlta()
        {
            InitializeComponent();
           
        }

        public Boolean camposCompletos(){
            if (textDescripcion.Text == "")
                return false;
            else if (textNumero.Text == "")
                return false;
            else if (textPiso.Text == "")
                return false;
            return true;
        }

    }
}
