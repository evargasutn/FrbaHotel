using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class RegistrarConsumibles : Form
    {
        public RegistrarConsumibles()
        {
            InitializeComponent();
        }

        private void RegistrarConsumibles_Load(object sender, EventArgs e)
        {

        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void textCantidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textEstadia_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
