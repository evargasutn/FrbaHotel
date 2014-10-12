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
    public partial class FormLsMod : Form
    {
        public FormLsMod()
        {
            InitializeComponent();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            ////
        }

       

        private void dataGridViewRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {         
           ///detecta la seleccion de la columna
            if (this.dataGridViewRol.Columns[e.ColumnIndex].Name == "ColumnSeleccionar")
            {
               ////
                ////abrir fr para seleccionar las funcionaidades
            }
        
        }

       

        

       
    }
}
