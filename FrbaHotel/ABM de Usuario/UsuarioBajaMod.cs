using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class FormModBajaUser : Form
    {
        public FormModBajaUser()
        {
            InitializeComponent();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

            //Limpiamos la DataGrid
            foreach (DataGridViewRow dgvr in dataGridUsuario.Rows)
                if (dgvr.Selected == true)
                    dataGridUsuario.Rows.Remove(dgvr);
            //Limiamos lo demas?
            textUsuario.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            comboRol.SelectedItem = null;
            





        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            //////
            ///// completar el datagridview de usarios
            /////
        }
    }
}
