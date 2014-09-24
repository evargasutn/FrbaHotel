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
        private Documento documento;
        private int? telefono = null;
        private Direccion direccion; //Direccion con formato
        private DateTime fecha_nacimiento;
        private List<DTOHotel> hoteles;
        private List<DTORol> roles;
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

        public string Mail
        {
            get { return email.Address; }
            set { email = new MailAddress(value); }
        }

        public int? TipoDocu
        {
            get { return (int?) documento.tipoDoc; }
            set { documento.tipoDoc = (Documento.tipo) value; }
        }

        public int? NroDocu
        {
            get { return documento.nroDoc; }
            set { documento.nroDoc = (int) value; }
        }

        public int? Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion.obtenerDireccion(); }
        }

        public Direccion Direccion
        {
            set { direccion = value; }
        }

        public string Fecha_nacimiento
        {
            get { return fecha_nacimiento.ToString("s"); }
            set { fecha_nacimiento = DateTime.Parse(value); }
        }

        #endregion

        #region Listas

        public void agregarHotel(DTOHotel hotel)
        {
            hoteles.Add(hotel);
        }

        public DTOHotel obtenerHotel(int id)
        {
            if ((id >= 0) && (id <= hoteles.Count))
                return hoteles[id];
            return null;
        }

        public void removerHotel(DTOHotel rol)
        {
            hoteles.Remove(rol);
        }

        public void agregarRol(DTORol rol)
        {
            roles.Add(rol);
        }

        public DTORol obtenerRol(int id)
        {
            if ((id >= 0) && (id <= roles.Count))
                return roles[id];
            return null;
        }

        public void removerRol(DTORol rol)
        {
            roles.Remove(rol);
        }

        #endregion

        #region Constructor
        public DTOUsuario()
        {
            documento = new Documento();
            direccion = new Direccion();

        }

        #endregion
    }
}