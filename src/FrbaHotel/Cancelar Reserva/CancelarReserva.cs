using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;
using DOM.DAO;
using DOM.Dominio;

namespace FrbaHotel.Cancelar_Reserva
{
    public partial class CancelarReserva : Form
    {
        public CancelarReserva(Usuario usuario,string hotel)///UN HUESPED TMB PUEDE CANCELAR UNA RESERVA
        {
            InitializeComponent();
            textUsuario.Text = usuario.Usr;
            //dateTimeCancelacion= fecha del sistema
        }

        private void buttonBuscarNroReserva_Click(object sender, EventArgs e)
        {
            textNroReserva.Text = Convert.ToString(new BuscarIdHuesped() );//devolver un valor(el id de la reserva)
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textNroReserva.Text = "";
            textUsuario.Text = "";
            textMotivo.Text = "";
        }





    }
}
