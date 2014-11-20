using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using DOM.Auxiliares;

namespace DOM.Dominio
{
    public class Hotel
    {
        #region Atributos
        private int codHotel = -1;
        private string nombre = "''";
        private MailAddress email = null;
        private DateTime? fecha_creacion = null;
        private int telefono = -1;
        private DireccionStruct direccion = new DireccionStruct(); //Direccion con formato
        private string ciudad = "''";
        private string pais = "''";
        private int estrellas = -1;

        #endregion

        #region Propiedades

        public int CodHotel
        {
            get { return codHotel; }
            set { codHotel = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Mail
        {
            get
            {
                if (email != null)
                    return email.Address;
                else
                    return "''";
            }
            set
            {
                if (value != "")
                    email = new MailAddress(value);
            }
        }
        public string Fecha_creacion
        {
            get { return ((DateTime)fecha_creacion).ToString("yyyyMMdd"); }
            set { fecha_creacion = DateTime.Parse(value); }
        }
        public DateTime? Fecha_creacion_struct
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
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
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        public int Estrellas
        {
            get { return estrellas; }
            set { estrellas = value; }
        }

        #endregion

    }
}
