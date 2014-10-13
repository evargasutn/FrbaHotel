using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using DOM.Interfaces;

namespace DOM
{
    public class DAORol : SqlConnector, DAAORol
    {
        string T_ROL = "ROLES";

        #region DAAORol Members

        public List<DOM.Dominio.Rol> getAllRoles()
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

        #region DAAORol Members


        public bool createRolConFuncionalidad(DOM.Dominio.Rol rol, int id_funcionalidad)
        {
            //Transaccion que agrega un Rol a la tabla ROLES y una entrada Rol.id con id_funcionalidad en la tabla ROLES_X_FUNCIONALIDADES
            return false;
            //throw new NotImplementedException();
        }

        #endregion
    }
}
