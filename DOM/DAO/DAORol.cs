﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using DOM.Interfaces;

namespace DOM
{
    public class DAORol : SqlConnector, DAAORol
    {

        #region DAAORol Members

        public List<DOM.Dominio.Rol> getAllRol()
        {
            throw new NotImplementedException();
        }

        public DOM.Dominio.Rol addRol(DOM.Dominio.Rol rol)
        {
            throw new NotImplementedException();
        }

        public DOM.Dominio.Rol getRol(string nombreRol)
        {
            throw new NotImplementedException();
        }

        public void updateRol(DOM.Dominio.Rol rol)
        {
            throw new NotImplementedException();
        }

        public void deteleRol(string nombreRol)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
