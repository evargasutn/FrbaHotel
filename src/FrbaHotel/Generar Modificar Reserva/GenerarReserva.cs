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
using DOM.DAO;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class GenerarReserva : Form
    {
        Hotel hotel = Globals.infoSesion.Hotel;
        List<Regimen> lista_regimenes;
        public GenerarReserva()
        {
            InitializeComponent();
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {
            lista_regimenes = DAORegimen.obtenerByHotel(hotel.CodHotel);
            foreach (Regimen reg in lista_regimenes)
                comboBoxTipoRegimen.Items.Add(reg.Descripcion);
            comboBoxTipoRegimen.SelectedIndex = -1; //Asi no esta ninguno por defecto
            limpiar();
        }

        private void limpiar()
        {
            textFecha.Value = Globals.getFechaSistema();
            dateTimeEntrada.Value = Globals.getFechaSistema();
            dateTimeSalida.Value = Globals.getFechaSistema();
            comboBoxTipoRegimen.SelectedIndex = -1;
            textCantHuespedes.Text = "";
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void botonReservar_Click(object sender, EventArgs e)
        {
            //Reservar
        }

        private void textCantHuespedes_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solamente números.", textCantHuespedes, textCantHuespedes.Location);
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
