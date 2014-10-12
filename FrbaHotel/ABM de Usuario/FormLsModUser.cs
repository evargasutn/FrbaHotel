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
    public partial class FormLsModUser : Form
    {
        public FormLsModUser()
        {
            InitializeComponent();
        }

        private void dataGridViewUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          /////detecta boton seleccionar
            if (this.dataGridViewUsuario.Columns[e.ColumnIndex].Name == "ColumnSelectora")
            { 
                ///
               ///abrir nuevo formulario de modificacion
            }
        


        }
    }
}
