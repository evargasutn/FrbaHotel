using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Dominio;
using DOM.Auxiliares;

namespace DOM.Interfaces
{
    interface DAAOHuesped
    {
        List<Huesped> getAllGuest();
        Huesped addGuest(Huesped invitado);
        Huesped getGuest(Documento documento);
        void updateGuest(Huesped invitado);
        void deteleGuest(Documento documento);
    }
}
