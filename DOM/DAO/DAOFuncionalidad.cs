using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using DOM.Interfaces;

namespace DOM
{
    public class DAOFuncionalidad : SqlConnector, DAAOFuncionalidad
    {
        #region DAAOFuncionalidad Members

        public List<DOM.Dominio.Funcionalidad> getAllGuest()
        {
            throw new NotImplementedException();
        }

        public DOM.Dominio.Funcionalidad addGuest(DOM.Dominio.Funcionalidad funcionalidad)
        {
            throw new NotImplementedException();
        }

        public DOM.Dominio.Funcionalidad getGuest(string id)
        {
            throw new NotImplementedException();
        }

        public void updateGuest(DOM.Dominio.Funcionalidad funcionalidad)
        {
            throw new NotImplementedException();
        }

        public void deteleGuest(string id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
