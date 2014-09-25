using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using DOM.Auxiliares;

namespace DOM.Dominio
{
    class Hotel
    {
        #region Atributos
        private string nombre;
        private MailAddress email;
        private DateTime fecha_creacion;
        private int telefono;
        private Direccion direccion; //Direccion con formato
        private string ciudad;
        private string pais;
        private int estrellas;
        private List<Reserva> reservas = new List<Reserva>();
        private List<Habitacion> habitaciones = new List<Habitacion>();

        //Regimenes
        //Inabilitaciones
        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Mail
        {
            get { return email.Address; }
            set { email = new MailAddress(value); }
        }
        public string Fecha_creacion
        {
            get { return fecha_creacion.ToString("s"); }
            set { fecha_creacion = DateTime.Parse(value); }
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

        #endregion

        #region Listas

        public void agregarHabitaciones(Habitacion habitacion)
        {
            habitaciones.Add(habitacion);
        }

        public Habitacion obtenerReserva(int id)
        {
            if ((id >= 0) && (id <= habitaciones.Count))
                return habitaciones[id];
            return null;
        }

        public void removerHotel(Habitacion habitacion)
        {
            habitaciones.Remove(habitacion);
        }

        public void agregarReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }

        public Reserva obtenerReserva(int id)
        {
            if ((id >= 0) && (id <= reservas.Count))
                return reservas[id];
            return null;
        }

        public void removerHotel(Reserva reserva)
        {
            reservas.Remove(reserva);
        }

        #endregion
    }
}
