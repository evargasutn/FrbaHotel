using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using FrbaHotel.DOM;

namespace DOM
{
    public class DAOHotel : SqlConnector
    {

        #region DAAOHotel Members

        public List<DOM.Dominio.Hotel> getAllHotel()
        {
            throw new NotImplementedException();
        }

        public DOM.Dominio.Hotel addHotel(DOM.Dominio.Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public DOM.Dominio.Hotel getHotel(string nombre)
        {
            throw new NotImplementedException();
        }

        public void updateHotel(DOM.Dominio.Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public void deteleHotel(string nombre)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
