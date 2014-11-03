using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using System.Net.Mail;

namespace DOM.Dominio
{
    public class Huesped
    {
        #region Atributos
        private int idHuesped;
        private Documento documento;
        private string nombre = "''";
        private string apellido = "''";
        private MailAddress email = null;
        private int telefono = -1;
        private DireccionStruct direccion; //Direccion con formato
        private string localidad = "''";
        private string nacionalidad = "''";
        private DateTime? fecha_nacimiento = null;
        private bool campo_baja = true;//Campo Baja
        #endregion

        #region Constructor

        public Huesped()
        {
            documento = new Documento();
            direccion = new DireccionStruct();
        }
        #endregion

        #region Propiedades

        public int Id
        {
            get { return idHuesped; }
            set { idHuesped = value; }
        }

        public Documento Documento
        {
            get { return documento;}
            set { documento = value;}
        }
        public string TipoDocu
        {
            get { return documento.tipoDoc; }
            set { documento.tipoDoc = value; }
        }

        public int NroDocu
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

        public DireccionStruct Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public string Fecha_nacimiento
        {
            get { return ((DateTime)fecha_nacimiento).ToString("yyyyMMdd"); }
            set { fecha_nacimiento = DateTime.Parse(value); }
        }

        public DateTime? Fecha_nacimiento_struct
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }

        public bool Campo_Baja
        {
            get { return campo_baja; }
            set { campo_baja = value; }
        }
        #endregion
    }
}
