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
    public partial class BuscarReserva : Form
    {
        public BuscarReserva()
        {
            InitializeComponent();
        }

        private void botonBuscarIdHuesped_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow dgvr in dataGridReserva.Rows) 
                if (dgvr.Selected == true)
                    dataGridReserva.Rows.Remove(dgvr);
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            ///buscar una reserva segun el id del huesped y un rango de fechas

        }

      
    }
}
