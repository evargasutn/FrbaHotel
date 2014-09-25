using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Dominio;

namespace DOM.Interfaces
{
    interface DAAOConsumible
    {
        List<Consumible> getAllConsumible();
        Consumible addConsumible(Consumible consumible);
        Consumible getConsumible(int codigoConsumible);
        void updateConsumible(Consumible consumible);
        void deteleConsumible(int codigoConsumible);
    }
}
