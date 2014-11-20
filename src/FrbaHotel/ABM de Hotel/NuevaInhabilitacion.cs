using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;
using DOM.Auxiliares;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class NuevaInhabilitacion : Form
    {
        int hotel;
        public NuevaInhabilitacion(int codHotel)
        {
            InitializeComponent();
            hotel = codHotel;
        }

        private void NuevaInhabilitacion_Load(object sender, EventArgs e)
        {
            dateTimeInicio.Value = Globals.getFechaSistema();
            dateTimeFin.Value = Globals.getFechaSistema();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            Globals.habilitarAnterior();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Inhabilitacion inhab = new Inhabilitacion();

            inhab.Hotel = hotel;
            inhab.Fecha_Inicio_struct = dateTimeInicio.Value;
            inhab.Fecha_Fin_struct = dateTimeFin.Value;
            inhab.Motivo = (textMotivo.Text != null) ? textMotivo.Text : "";

            DAOHotel.borrar(inhab);

            ((HotelBajaMod)Globals.VentanaAnterior).updateGrid();
            this.Close();
        }
    }
}
