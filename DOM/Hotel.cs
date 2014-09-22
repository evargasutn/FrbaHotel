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
        private Direccion direccion; //Direccion con formato
        private string Ciudad;
        private string Pais;
        private int estrellas;

        private List<Reserva> reservas;
        private List<Habitacion> habitaciones;
        //Regimenes
        //Inabilitaciones
    }
}
