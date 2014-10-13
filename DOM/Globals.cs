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


        //Fecha:10/13/2014
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
        ///
        //Fecha:10/13/2014
        #region VentanasViajeras
        public static IList<Form> conjuntoDeVentanas = new List<Form>();
        public static IList<Form> ConjuntoDeVentanas
        {
            get { return conjuntoDeVentanas; }
            set { conjuntoDeVentanas = value; }
        }
        public static int indexVentanas = 0;
        public static int IndexVentanas
        {
            get { return indexVentanas; }
            set { indexVentanas = value; }
        }


        /// <summary>
        /// agrega a la lista la ventana ventana actual(anterior)
        /// </summary>
        /// <param name="unaVentanaADondeVolver"></param>
        public static void establecerVentanaAVolver(Form unaVentanaADondeVolver)
        {
            unaVentanaADondeVolver.Enabled = false;
            ConjuntoDeVentanas.Add(unaVentanaADondeVolver);

        }

        /// <summary>
        /// Abre una nueva ventana ,y la establece la ventana a volver
        /// </summary>
        /// <param name="ventanaNueva"></param>
        public static void irANuevaVentana(Form ventanaAAbrir, Form ventanaAnterior)
        {
            establecerVentanaAVolver(ventanaAnterior);
            ventanaAAbrir.Show();
        }

        //
        /// <summary>
        /// Cierra la ventana actual y saca de la lista la ventana a la que se vuelve
        /// Se debe colocar este metodo en dispose de cada formulario , tare a corregir
        /// </summary>
        /// <param name="ventanaActual"></param>
        public static void volverAAnteriorVentana(Form ventanaActual)
        {
            var index = ConjuntoDeVentanas.Count - 1;
            ConjuntoDeVentanas[index].Enabled = true;
            ConjuntoDeVentanas.RemoveAt(index);
        }


        /// <summary>
        /// //Acordate q el metodo dispose llama a volverALaVentanaAnterior
        /// </summary>
        /// <param name="ventanaActual"></param>
        public static void cerrarVentana(Form ventanaActual)
        {

            ventanaActual.Dispose();
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
