using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using System.Net.Mail;
using DOM.Interfaces;
using FrbaHotel.DOM;

namespace DOM
{
    public class DAOGuest : SqlConnector, DAAOGuest
    {

        #region DAAOGuest Members

        public List<DOM.Dominio.Guest> getAllGuest()
        {
            throw new NotImplementedException();
        }

        public DOM.Dominio.Guest addGuest(DOM.Dominio.Guest invitado)
        {
            throw new NotImplementedException();
        }

        public DOM.Dominio.Guest getGuest(Documento documento)
        {
            throw new NotImplementedException();
        }

        public void updateGuest(DOM.Dominio.Guest invitado)
        {
            throw new NotImplementedException();
        }

        public void deteleGuest(Documento documento)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
