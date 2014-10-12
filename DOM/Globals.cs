using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using DOM.Interfaces;

namespace DOM
{
    public class Globals
    {
        #region Configuracion
        private static int _userID = 0;

        private static string connectionString = ConfigurationManager.ConnectionStrings["sqlserver2008"].ConnectionString;
        private static bool isLogged = false;

        public static int userID
        {
            get { return _userID; }
            set { _userID = value; }
        }
        public static string getConnectionString()
        {
            return connectionString;
        }

        public static DateTime getFechaSistema()
        {
            return Convert.ToDateTime(ConfigurationSettings.AppSettings["fechaSistema"]);
        }

        public static void setAdminLoggeado(bool status)
        {
            isLogged=status;
        }

        public static bool adminLoggeado()
        {
            return isLogged;
        }
        #endregion

        #region DAO
        private static DAAOUsuario usuario = new DAOUsuario();
        private static DAAOFuncionalidad funcionalidad = new DAOFuncionalidad();

        public DAAOUsuario USUARIOS
        {
            get { return usuario; }
        }
        public DAAOFuncionalidad FUNCIONALIDAD
        {
            get { return funcionalidad; }
        }

        #endregion
    }
}
