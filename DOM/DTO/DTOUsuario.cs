using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using System.Net.Mail;

namespace DOM
{
    /// <summary>
    /// Clase que representa a la entidad Usuario, almacenada en una fuente de datos
    /// </summary>
    /// 
    /// Tomas Ferraro     24/09/2014    Creación
    ///
    public class DTOUsuario
    {
        #region Atributos
        private string usr = null;
        private string password = null; //password encriptado con SHA256
        private string nombre = null;
        private string apellido = null;
        private MailAddress email = null;
        private Documento documento = null;
        private int? telefono = null;
        private Direccion direccion = null; //Direccion con formato
        private DateTime? fecha_nacimiento = null;
        private List<DTOHotel> hoteles = null;
        private List<DTORol> roles = null;
        #endregion

        #region Propiedades

        public string Usr
        {
            get { return usr; }
            set { usr = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        #endregion
    }
}
