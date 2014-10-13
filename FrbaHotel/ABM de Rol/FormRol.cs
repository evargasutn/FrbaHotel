using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class FormRol : Form
    {
        public FormRol()
        {
            InitializeComponent();
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            FormRolAlta alta = new FormRolAlta();
            mostrarVentana(alta);
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            FormRolMod modificacion = new FormRolMod();
            mostrarVentana(modificacion);
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            FormRolBaja baja = new FormRolBaja();
            mostrarVentana(baja);
        }
        private void mostrarVentana(Form ventana)
        {
            ventana.Show();
            Base.establecerVentanaAnterior(this);
        }

        private void FormRol_Load(object sender, EventArgs e)
        {

        }
    }
}
