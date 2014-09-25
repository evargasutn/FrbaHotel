using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Dominio;

namespace DOM.Interfaces
{
    interface DAAOEstadia
    {
        List<Estadia> getAllEstadia();
        Estadia addEstadia(Estadia habitacion);
        Estadia getEstadia(int codigoReserva);
        void updateEstadia(Estadia habitacion);
        void deteleEstadia(int codigoReserva);
    }
}
