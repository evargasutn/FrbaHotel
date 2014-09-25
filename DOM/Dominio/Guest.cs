using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using System.Net.Mail;

namespace DOM.Dominio
{
    class Guest
    {
        #region Atributos
        private Documento documento;
        private string nombre;
        private string apellido;
        private MailAddress email;
        private int telefono;
        private Direccion direccion; //Direccion con formato
        private string localidad;
        private string pais;
        private string nacionalidad;
        private DateTime fecha_nacimiento;
        //Campo Baja
        #endregion

        #region Constructor

        public Guest()
        {
            documento = new Documento();
            direccion = new Direccion();
        }
        #endregion

        #region Propiedades

        public Documento Documento
        {
            get { return documento;}
            set { documento = value;}
        }
        public int? TipoDocu
        {
            get { return (int?)documento.tipoDoc; }
            set { documento.tipoDoc = (Documento.tipo)value; }
        }

        public int? NroDocu
        {
            get { return documento.nroDoc; }
            set { documento.nroDoc = (int)value; }
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

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string DireccionReal
        {
            get { return direccion.obtenerDireccion(); }
        }

        public Direccion Direccion
        {
            set { direccion = value; }
        }
        
        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public string Fecha_nacimiento
        {
            get { return fecha_nacimiento.ToString("s"); }
            set { fecha_nacimiento = DateTime.Parse(value); }
        }
        #endregion


    }
}
