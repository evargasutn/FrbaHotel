using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using DOM.Interfaces;
using System.Windows.Forms;

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

        #region Singletons Ventanas
        private static Form ventanaAnterior;

        public static Form VentanaAnterior
        {
            get { return ventanaAnterior; }
            set { ventanaAnterior = value; }
        }

        #endregion

        #region TextBoxes
        private static TextBox textBoxAnterior;
        public static TextBox TextBoxAnterior
        {
            get { return textBoxAnterior; }
            set { textBoxAnterior = value; }
        }

        private static List<TextBox> conjuntoDeTextBox;
        public static List<TextBox> ConjuntoDeTextBox
        {
            get { return conjuntoDeTextBox; }
            set { conjuntoDeTextBox = value; }
        }

        public static void cargarConjuntoDeTextBoxAnteriores(List<TextBox> conjuntoTextBoxActual)
        {
            var i = 0;
            foreach (TextBox unTextBox in conjuntoTextBoxActual)
            {
                conjuntoDeTextBox[i++].Text = unTextBox.Text;

            }

        }

        #endregion


        #region DAO
        private static DAAOUsuario usuario = new DAOUsuario();
        private static DAAORol rol = new DAORol();
        private static DAAOFuncionalidad funcionalidad = new DAOFuncionalidad();

        public static DAAOUsuario USUARIOS
        {
            get { return usuario; }
        }
        public static DAAORol ROL
        {
            get { return rol; }
        }
        public static DAAOFuncionalidad FUNCIONALIDAD
        {
            get { return funcionalidad; }
        }

        #endregion
    }
}
