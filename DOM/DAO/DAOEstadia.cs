using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Dominio;
using FrbaHotel.DOM;
using DOM.Interfaces;

namespace DOM
{
    public class DAOEstadia : SqlConnector, DAAOEstadia
    {

        #region DAAOEstadia Members

        public List<Estadia> getAllEstadia()
        {
            throw new NotImplementedException();
        }

        public Estadia addEstadia(Estadia habitacion)
        {
            throw new NotImplementedException();
        }

        public Estadia getEstadia(int codigoReserva)
        {
            throw new NotImplementedException();
        }

        public void updateEstadia(Estadia habitacion)
        {
            throw new NotImplementedException();
        }

        public void deteleEstadia(int codigoReserva)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
