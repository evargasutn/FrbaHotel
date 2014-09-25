﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using System.Net.Mail;
using DOM.Dominio;

namespace DOM
{
    /// <summary>
    /// Clase que representa el modelo de Negocio Usuario
    /// </summary>
    /// 
    /// Tomas Ferraro     24/09/2014    Creación
    ///
    public class Usuario
    {
        #region Atributos
        private string usr;
        private string password; //password encriptado con SHA256
        private string nombre;
        private string apellido;
        private MailAddress email = null;
        private Documento documento;
        private int? telefono;
        private Direccion direccion; //Direccion con formato
        private DateTime fecha_nacimiento;
        private List<Hotel> hoteles = new List<Hotel>();
        private List<Rol> roles = new List<Rol>();
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

        public int TipoDocu
        {
            get { return (int)documento.tipoDoc; }
            set { documento.tipoDoc = (DocumentoTipoEnum)value; }
        }

        public int? NroDocu
        {
            get { return documento.nroDoc; }
            set { documento.nroDoc = (int)value; }
        }

        public int? Telefono
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

        public string Fecha_nacimiento
        {
            get { return fecha_nacimiento.ToString("s"); }
            set { fecha_nacimiento = DateTime.Parse(value); }
        }

        #endregion

        #region Listas

        public void agregarHotel(Hotel hotel)
        {
            hoteles.Add(hotel);
        }

        public Hotel obtenerHotel(int id)
        {
            if ((id >= 0) && (id <= hoteles.Count))
                return hoteles[id];
            return null;
        }

        public void removerHotel(Hotel hotel)
        {
            hoteles.Remove(hotel);
        }

        public void agregarRol(Rol rol)
        {
            roles.Add(rol);
        }

        public Rol obtenerRol(int id)
        {
            if ((id >= 0) && (id <= roles.Count))
                return roles[id];
            return null;
        }

        public void removerRol(Rol rol)
        {
            roles.Remove(rol);
        }

        #endregion

        #region Constructor
        public Usuario()
        {
            documento = new Documento();
            direccion = new Direccion();
        }

        #endregion
    }
}