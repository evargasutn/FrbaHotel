using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace DOM
{
    class Hotel
    {
        private string nombre;
        private MailAddress email;
        private DateTime fecha_creacion;
        private int telefono;
        //Direccion
        private string Ciudad;
        private string Pais;
        private int estrellas;
        
        //Reservas
        private List<Habitacion> habitaciones;
        //Regimenes
        //Inabilitaciones
    }
}
