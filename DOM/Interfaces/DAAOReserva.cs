using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Dominio;

namespace DOM.Interfaces
{
    interface DAAOReserva
    {
        List<Reserva> getAllReserva();
        Reserva addReserva(Reserva rol);
        Reserva getReserva(int codigoReserva);
        void updateReserva(Reserva rol);
        void deteleReserva(int codigoReserva);
    }
}
