using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using DOM.Interfaces;

namespace DOM
{
    public class DAOHabitacion : SqlConnector, DAAOHabitacion
    {

        #region DAAOHabitacion Members

        public List<DOM.Dominio.Habitacion> getAllHabitacion()
        {
            throw new NotImplementedException();
        }

        public DOM.Dominio.Habitacion addHabitacion(DOM.Dominio.Habitacion habitacion)
        {
            throw new NotImplementedException();
        }

        public DOM.Dominio.Habitacion getHabitacion(int id_habitacion)
        {
            throw new NotImplementedException();
        }

        public void updateHabitacion(DOM.Dominio.Habitacion habitacion)
        {
            throw new NotImplementedException();
        }

        public void deteleHabitacion(int id_habitacion)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
