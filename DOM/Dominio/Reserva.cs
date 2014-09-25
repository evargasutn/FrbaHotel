using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        private DTOHotel hotel;
        private List<DTOHabitacion> habitaciones;
        private DTOGuest guest;
        private DTOEstadia datosEstadia;
    }
}
