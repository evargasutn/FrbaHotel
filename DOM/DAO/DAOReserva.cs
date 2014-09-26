using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using FrbaHotel.DOM;
using DOM.Interfaces;
using DOM.Dominio;

namespace DOM
{
    public class DAOReserva : SqlConnector, DAAOReserva
    {

        #region DAAOReserva Members

        public List<Reserva> getAllReserva()
        {
            throw new NotImplementedException();
        }

        public Reserva addReserva(Reserva rol)
        {
            throw new NotImplementedException();
        }

        public Reserva getReserva(int codigoReserva)
        {
            throw new NotImplementedException();
        }

        public void updateReserva(Reserva rol)
        {
            throw new NotImplementedException();
        }

        public void deteleReserva(int codigoReserva)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
