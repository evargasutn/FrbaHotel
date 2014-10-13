using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;
namespace FrbaHotel.ABM_de_Usuario
{
    public partial class FormAltaUser : Form
    {
        public FormAltaUser()
        {
            InitializeComponent();
        }

        private void buttonSelFecha_Click(object sender, EventArgs e)
        {
            Globals.VentanaAnterior=this;
            this.Enabled = false;
            Globals.TextBoxAnterior=textBoxFechaNac;
            CalendarioGlobal calendarioFechaNacimiento=new CalendarioGlobal();
            calendarioFechaNacimiento.Show();
        }

                  
    }
}
