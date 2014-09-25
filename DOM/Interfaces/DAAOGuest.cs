using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Dominio;
using DOM.Auxiliares;

namespace DOM.Interfaces
{
    interface DAAOGuest
    {
        List<Guest> getAllGuest();
        Guest addGuest(Guest invitado);
        Guest getGuest(Documento documento);
        void updateGuest(Guest invitado);
        void deteleGuest(Documento documento);
    }
}
