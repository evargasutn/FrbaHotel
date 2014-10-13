using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
////
///Funcionalidad que solo se encuetra disponible para el adm del sistema
//Un adm solo puede realizar mod y bajas a usuarios del mismo hotel
namespace FrbaHotel.ABM_de_Usuario
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonAltaUser_Click(object sender, EventArgs e)
        {
            FormAltaUser formAlta=new FormAltaUser();
            formAlta.Show();
        }

       

      
    }
}
