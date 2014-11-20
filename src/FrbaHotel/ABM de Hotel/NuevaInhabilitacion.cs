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
        public NuevaInhabilitacion(int codHotel, string nombreHotel)
        {
            InitializeComponent();
            hotel = codHotel;
            textHotel.Text = nombreHotel;
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
            if (dateTimeInicio.Value.CompareTo(dateTimeFin.Value) >= 0)
            {
                MessageBox.Show("Rango de Fechas inválido. Intente nuevamente.",
                "Error Grave", MessageBoxButtons.OK);
                return;
            }
            Inhabilitacion inhab = new Inhabilitacion();

            int respuesta = DAOHotel.estaVacio(hotel, dateTimeInicio.Value, dateTimeFin.Value);
            if (respuesta > 0)
            {
                inhab.Hotel = hotel;
                inhab.Fecha_Inicio_struct = dateTimeInicio.Value;
                inhab.Fecha_Fin_struct = dateTimeFin.Value;
                inhab.Motivo = (textMotivo.Text != null) ? textMotivo.Text : "";

                DAOHotel.borrar(inhab);

                ((HotelBajaMod)Globals.VentanaAnterior).updateGrid();
                this.Close();
            }
            else
            {
                if (respuesta == -1)
                {
                    MessageBox.Show("Error al conectar con la Base de Datos.",
                    "Error Grave", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Hotel con reservas o huespedes alojados para esas fechas. No es posible dar la baja.",
                "", MessageBoxButtons.OK);
            }            
        }
    }
}
