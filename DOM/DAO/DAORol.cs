using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using DOM.Interfaces;
using System.Data;

namespace DOM
{
    public class DAORol : SqlConnector, DAAORol
    {
        string T_ROL = "COMPUMUNDO_HIPER_MEGA_RED.ROLES";

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

        public bool createRolConFuncionalidad(DOM.Dominio.Rol rol, int id_funcionalidad)
        {
            //Transaccion que agrega un Rol a la tabla ROLES y una entrada Rol.id con id_funcionalidad en la tabla ROLES_X_FUNCIONALIDADES
            return false;
            //throw new NotImplementedException();
        }

        public DataTable buscarRoles(string nombreRol, int id_funcionalidad)
        {
            //Procedimientos:
            //1.- Segun un nombreRol, busca todos los que matcheen
            //2.- Segun un id_funcionalidad, busca todos los que tengan tal funcionalidad
            //3.- Segun el nombreRol y id_funcionalidad, busca los que matcheen
            if((nombreRol != "") && (id_funcionalidad > -1))
                ;//1.- Retornamos la DataTable
            if(nombreRol != "")
                ;//2.- Retornamos la DataTable
            if (id_funcionalidad > -1)
                ;//1.- Retornamos la DataTable 
            return null;
            //throw new NotImplementedException();
        }

        #endregion
    }
}
