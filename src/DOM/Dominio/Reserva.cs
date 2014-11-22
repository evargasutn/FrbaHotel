using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;

namespace DOM.Dominio
{
    public class Reserva
    {
        #region Atributos
        private int codigoReserva = -1;
        private int codRegimen = -1;
        private int huesped = -1;
        private DateTime? fecha_inicio = null;
        private DateTime? fecha_fin = null;
        private DateTime? fecha_reserva = null;
        private string usr = "''";
        private int estado = 1;
        #endregion

        #region Propiedades
        public int CodigoReserva
        {
            get { return codigoReserva; }
            set { codigoReserva = value; }
        }
        public int CodigoRegimen
        {
            get { return codRegimen; }
            set { codRegimen = value; }
        }
        public int Huesped
        {
            get { return huesped; }
            set { huesped = value; }
        }
        public string Fecha_Inicio
        {
            get { return ((DateTime)fecha_inicio).ToString("yyyyMMdd"); }
            set { fecha_inicio = DateTime.Parse(value); }
        }
        public DateTime? Fecha_Inicio_struct
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }
        public string Fecha_Fin
        {
            get { return ((DateTime)fecha_fin).ToString("yyyyMMdd"); }
            set { fecha_fin = DateTime.Parse(value); }
        }
        public DateTime? Fecha_Fin_struct
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }
        public string Fecha_Reserva
        {
            get { return ((DateTime)fecha_reserva).ToString("yyyyMMdd"); }
            set { fecha_reserva = DateTime.Parse(value); }
        }
        public DateTime? Fecha_Reserva_struct
        {
            get { return fecha_reserva; }
            set { fecha_reserva = value; }
        }
        public string Usr
        {
            get { return usr; }
            set { usr = value; }
        }
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion

        //No es para datos, solo de transicion cuando sea necesaria
        public List<Detalle_Reserva> detalles_reserva = new List<Detalle_Reserva>();
        public int cantHabitaciones = 0;
    }

    public class Detalle_Reserva
    {
        #region Atributos
        private int codReserva = -1;
        private int codHotel = -1;
        private int habitacion = -1;
        #endregion

        #region Propiedades
        public int CodigoReserva
        {
            get { return codReserva; }
            set { codReserva = value; }
        }
        public int CodigoHotel
        {
            get { return codHotel; }
            set { codHotel = value; }
        }
        public int Habitacion
        {
            get { return habitacion; }
            set { habitacion = value; }
        }
        #endregion
    }
}