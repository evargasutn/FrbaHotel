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

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class MainReservas : Form
    {
        public MainReservas()
        {
            InitializeComponent();
        }

        private void textReserva_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            showToolTip("Ingrese solo números.", textReserva, textReserva.Location);
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            if (textReserva.Text == "")
            {
                showToolTip("Ingrese un número de Reserva.", textReserva, textReserva.Location);
                return;
            }
            Reserva reserva = DAOReserva.obtener(Int32.Parse(textReserva.Text));
            if (reserva == null)
            {
                showToolTip("Número de Reserva inválido. Ingrese su número nuevamente.", textReserva, textReserva.Location);
                return;
            }
            new ModificarReserva(reserva).Show();
            this.Dispose();
        }

        private void altaDeRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GenerarReserva().Show();
            this.Dispose();
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
