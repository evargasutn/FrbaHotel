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
        private Documento documento;
        private string nombre;
        private string apellido;
        private MailAddress email;
        private int telefono;
        private DireccionStruct direccion; //Direccion con formato
        private string localidad;
        private string pais;
        private string nacionalidad;
        private DateTime fecha_nacimiento;
        private bool campo_baja;//Campo Baja
        #endregion

        #region Constructor

        public Huesped()
        {
            documento = new Documento();
            direccion = new DireccionStruct();
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
            set { documento.tipoDoc = (DocumentoTipoEnum)value; }
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

        public DireccionStruct Direccion
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
            get { return fecha_nacimiento.ToString("yyyyMMdd"); }
            set { fecha_nacimiento = DateTime.Parse(value); }
        }

        public bool Campo_Baja
        {
            get { return campo_baja; }
            set { campo_baja = value; }
        }
        #endregion


    }
}
