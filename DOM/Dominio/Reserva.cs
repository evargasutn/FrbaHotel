﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;

namespace DOM.Dominio
{
    class Reserva
    {
        private int codigoReserva;
        private int cod_regimen;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private DateTime fecha_reserva;
        private EstadoReserva estado;
        private Hotel hotel;
        private List<Habitacion> habitaciones = new List<Habitacion>();
        private Guest guest;
        private Estadia datosEstadia;
    }
}