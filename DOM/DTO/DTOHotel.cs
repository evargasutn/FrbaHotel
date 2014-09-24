using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace DOM
{
    class DTOHotel
    {
        private string nombre;
        private MailAddress email;
        private DateTime fecha_creacion;
        private int telefono;
        private Direccion direccion; //Direccion con formato
        private string Ciudad;
        private string Pais;
        private int estrellas;

        private List<DTOReserva> reservas;
        private List<DTOHabitacion> habitaciones;
        //Regimenes
        //Inabilitaciones
    }
}
