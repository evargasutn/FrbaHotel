using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using System.Net.Mail;

namespace DOM
{
    public class Usuario
    {
        #region Atributos Privados
        private string usr;
        private string password; //password encriptado con SHA256
        private string nombre;
        private string apellido;
        private MailAddress email;
        private Documento documento;
        private int telefono;
        private Direccion direccion; //Direccion con formato
        private DateTime fecha_nacimiento;
        private List<Hotel> hoteles;
        private List<Rol> roles;
        #endregion

    }
}
