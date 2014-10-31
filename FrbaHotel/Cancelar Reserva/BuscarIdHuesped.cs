using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Cancelar_Reserva
{
    public partial class BuscarIdHuesped : Form
    {
        public BuscarIdHuesped()
        {
            InitializeComponent();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textNroDocumento.Text = "";
            comboTipoDocumento.SelectedItem = null;
            foreach (DataGridViewRow dgvr in dataGridHuesped.Rows)
                if (dgvr.Selected == true)
                    dataGridHuesped.Rows.Remove(dgvr);


        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
          /// filtrar la tabla y cargar el data gridView con las reservas mecheando la id huesped
          /// y id reserva
        }

        private void dataGridHuesped_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColumnSeleccionar.DisplayIndex) confirmarHuesped(e.RowIndex);
        }
        
        private void confirmarHuesped(int rowSeleccionada){
    
           //tomar el id del huesped y devolverlo al formulario q abrio a este
            }


    }
}
