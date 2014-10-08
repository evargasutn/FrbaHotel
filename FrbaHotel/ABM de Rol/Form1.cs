using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
         FormAlta alta = new FormAlta();
            alta.Show();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            FormLsMod modificacion = new FormLsMod();
            modificacion.Show();
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            FormLsBaja baja = new FormLsBaja();
            baja.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
