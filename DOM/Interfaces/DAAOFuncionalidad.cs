using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Dominio;

namespace DOM.Interfaces
{
    interface DAAOFuncionalidad
    {
        List<Funcionalidad> getAllGuest();
        Funcionalidad addGuest(Funcionalidad funcionalidad);
        Funcionalidad getGuest(string id);
        void updateGuest(Funcionalidad funcionalidad);
        void deteleGuest(string id);
    }
}
