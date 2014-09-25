using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Dominio;

namespace DOM.Interfaces
{
    interface DAAOHabitacion
    {
        List<Habitacion> getAllHabitacion();
        Habitacion addHabitacion(Habitacion habitacion);
        Habitacion getHabitacion(int id_habitacion);
        void updateHabitacion(Habitacion habitacion);
        void deteleHabitacion(int id_habitacion);
    }
}
