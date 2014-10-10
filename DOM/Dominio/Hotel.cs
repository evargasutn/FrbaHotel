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
        private string nombre;
        private MailAddress email;
        private DateTime fecha_creacion;
        private int telefono;
        private DireccionStruct direccion; //Direccion con formato
        private string ciudad;
        private string pais;
        private int estrellas;
        private List<Reserva> reservas = new List<Reserva>();
        private List<Habitacion> habitaciones = new List<Habitacion>();

        private List<Regimen> regimenes = new List<Regimen>();
        private List<Inhabilitacion> inhabilitaciones = new List<Inhabilitacion>();
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
        public DireccionStruct Direccion
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

        public void agregarInhabilitacion(Inhabilitacion inhabilitacion)
        {
            inhabilitaciones.Add(inhabilitacion);
        }

        public Inhabilitacion obtenerInhabilitacion(int id)
        {
            if ((id >= 0) && (id <= inhabilitaciones.Count))
                return inhabilitaciones[id];
            return null;
        }

        public void removerInhabilitacion(Inhabilitacion inhabilitacion)
        {
            inhabilitaciones.Remove(inhabilitacion);
        }

        public void agregarRegimen(Regimen regimen)
        {
            regimenes.Add(regimen);
        }

        public Regimen obtenerRegimen(int id)
        {
            if ((id >= 0) && (id <= regimenes.Count))
                return regimenes[id];
            return null;
        }

        public void removerRegimen(Regimen regimen)
        {
            regimenes.Remove(regimen);
        }

        public void agregarHabitacion(Habitacion habitacion)
        {
            habitaciones.Add(habitacion);
        }

        public Habitacion obtenerHabitacion(int id)
        {
            if ((id >= 0) && (id <= habitaciones.Count))
                return habitaciones[id];
            return null;
        }

        public void removerHabitacion(Habitacion habitacion)
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
