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
    public partial class FormRolBaja : Form
    {//En el listado deben aparecer solo los activos
        //para dar la baja logica a no activo
        public FormRolBaja()
        {
            InitializeComponent();
        }

        private void textBoxNombreRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboDeFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewRol.Columns[e.ColumnIndex].Name == "ColumnSelecBaja")
            {
                ////dar de Baja al rol()inhabilitar
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ////////////
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            //////////
        }

        private void FormLsBaja_Load(object sender, EventArgs e)
        {

        }

    }
    
}
