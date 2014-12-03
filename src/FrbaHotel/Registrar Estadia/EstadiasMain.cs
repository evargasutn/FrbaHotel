using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;
using DOM.Dominio;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class EstadiasMain : Form
    {
        Reserva reserva_seleccionada;
        Huesped datos_huesped;
        public EstadiasMain()
        {
            InitializeComponent();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            limpiar();
            if(textEstadia.Text == "")
            {
                showToolTip("Ingrese un número de reserva.", textEstadia, textEstadia.Location);
                return;
            }
            reserva_seleccionada = DAOReserva.obtener(Int32.Parse(textEstadia.Text));
            if (reserva_seleccionada == null)
            {
                showToolTip("Ingrese un número de reserva válido.", textEstadia, textEstadia.Location);
                return;
            }
            datos_huesped = DAOHuesped.obtener(reserva_seleccionada.Huesped);
            textHuesped.Text = datos_huesped.Nombre + " " + datos_huesped.Apellido;
            textFecReserva.Text = reserva_seleccionada.Fecha_Reserva_struct.Value.ToShortDateString();
            textFecInicio.Text = reserva_seleccionada.Fecha_Inicio_struct.Value.ToShortDateString();
            textFecFin.Text = reserva_seleccionada.Fecha_Fin_struct.Value.ToShortDateString(); 

        }

        private void botonCheckIn_Click(object sender, EventArgs e)
        {
            if (textHuesped.Text != "")
            {
                new Check_In(reserva_seleccionada).Show();
                Globals.deshabilitarAnterior(this);
            }
            else
                showToolTip("Debe ingresar un número de reserva para poder hacer el Check In", textEstadia, textEstadia.Location);

        }

        private void botonCheckOut_Click(object sender, EventArgs e)
        {
            if (textHuesped.Text != "")
            {
                new Check_Out(reserva_seleccionada).Show();
                Globals.deshabilitarAnterior(this);
            }
            else
                showToolTip("Debe ingresar un número de reserva para poder hacer el Check Out", textEstadia, textEstadia.Location);
        }

        private void limpiar()
        {
            textHuesped.Text = "";
            textFecInicio.Text = "";
            textFecFin.Text = "";
            textFecReserva.Text = "";
        }


        private void textEstadia_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente números.", textEstadia, textEstadia.Location);
        }

        private void showToolTip(string msj, Control ventana, Point pos)
        {
            toolTip.Hide(ventana);
            toolTip.SetToolTip(ventana, "Entrada Invalida");
            toolTip.Show(msj, ventana, 50, 10, 5000);
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            // Confirm user wants to close
            Globals.habilitarAnterior();
        }
    }
}
