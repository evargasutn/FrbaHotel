﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOM.Dominio;
using DOM;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class ConfirmarReserva : Form
    {
        public ConfirmarReserva(Reserva reserva)
        {
            InitializeComponent();
        }

        private void ConfirmarReserva_Load(object sender, EventArgs e)
        {

        } 

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            Globals.habilitarAnterior();
            //Globals.VentanaAnterior.Dispose();
            //Globals.habilitarAnterior();
        }
     
    }
}
