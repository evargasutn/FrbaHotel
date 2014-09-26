using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using DOM.Interfaces;

namespace DOM
{
    public class DAOConsumible : SqlConnector, DAAOConsumible
    {

        #region DAAOConsumible Members

        public List<DOM.Dominio.Consumible> getAllConsumible()
        {
            throw new NotImplementedException();
        }

        public DOM.Dominio.Consumible addConsumible(DOM.Dominio.Consumible consumible)
        {
            throw new NotImplementedException();
        }

        public DOM.Dominio.Consumible getConsumible(int codigoConsumible)
        {
            throw new NotImplementedException();
        }

        public void updateConsumible(DOM.Dominio.Consumible consumible)
        {
            throw new NotImplementedException();
        }

        public void deteleConsumible(int codigoConsumible)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
