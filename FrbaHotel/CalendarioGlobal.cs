using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;

namespace FrbaHotel
{
    public partial class CalendarioGlobal : Form
    {
        public CalendarioGlobal()
        {
            InitializeComponent();
        }



       

        

            
        

        private void buttonAceptarFecha_Click(object sender, EventArgs e)
        {
            if (textBoxFecha.Text == "")
            {
                MessageBox.Show("Por favor seleccione una fecha", "Error:Fecha");
            }
            else
            {
                Globals.TextBoxAnterior.Text = textBoxFecha.Text;
                this.Dispose();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxFecha.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }







    }
}
