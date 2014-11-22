using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using FrbaHotel.DOM;
using DOM.Dominio;
using System.Data;

namespace DOM
{
    public class DAOReserva : SqlConnector
    {
        #region Obtener
        public static DataTable obtenerTabla()
        {
            return retrieveDataTable("getReserva", entero_nulo);
        }

        public static List<Reserva> obtenerTodos()
        {
            return transductor(obtenerTabla());
        }

        public static DataTable obtenerTabla(int codReserva)
        {
            return retrieveDataTable("getReserva", codReserva);
        }

        public static Reserva obtener(int codReserva)
        {
            List<Reserva> lista = transductor(obtenerTabla(codReserva));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }
        #endregion

        #region obtener Detalle_Reserva
        public static DataTable obtenerDetalleTabla(int codReserva)
        {
            return retrieveDataTable("getReserva", codReserva);
        }

        public static Detalle_Reserva obtenerDetalleTodos(int codReserva)
        {
            List<Detalle_Reserva> lista = transductor_detalle(obtenerTabla(codReserva));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }
        #endregion

        public static bool agregar(Reserva reserva)
        {
            int idHuesped = reserva.Huesped;
            string usr = reserva.Usr;
            string fecDesde = reserva.Fecha_Inicio;
            string fecHasta = reserva.Fecha_Fin;
            string fecReserva = reserva.Fecha_Reserva;
            int regimen = reserva.CodigoRegimen;
            return executeProcedure("insertReserva", idHuesped, usr, regimen, fecDesde, fecHasta, fecReserva);
        }
        public static bool agregarHabitacion(Detalle_Reserva detalle)
        {
            int codReserva = detalle.CodigoReserva;
            int codHotel = detalle.CodigoHotel;
            int habitacion = detalle.Habitacion;
            return executeProcedure("insertDetalleReserva", codReserva, codHotel, habitacion);
        }

        public static DataTable habitacionDisponiblesTabla(int codHotel, string fechaDesde, string fechaHasta)
        {
            return retrieveDataTable("existenHab", codHotel ,fechaDesde, fechaHasta);
        }
        public static List<Habitacion> habitacionDisponibles(int codHotel, string fechaDesde, string fechaHasta)
        {
            return DAOHabitacion.transductor(habitacionDisponiblesTabla(codHotel, fechaDesde, fechaHasta));
        }




        #region Transductores
        public static List<Reserva> transductor(DataTable dt)
        {
            List<Reserva> lista = new List<Reserva>();
            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Reserva reserva = new Reserva();
                    reserva.CodigoReserva = Convert.ToInt32(fila["codReserva"]);
                    reserva.CodigoRegimen = Convert.ToInt32(fila["codRegimen"]);
                    reserva.Fecha_Fin_struct = Convert.ToDateTime(fila["fecHasta"]);
                    reserva.Fecha_Inicio_struct = Convert.ToDateTime(fila["fecDesde"]);
                    reserva.Fecha_Reserva_struct = Convert.ToDateTime(fila["fecReserva"]);
                    reserva.Usr = Convert.ToString(fila["usr"]);
                    //Transcribir
                    lista.Add(reserva);
                }
            }
            return lista;
        }
        public static List<Detalle_Reserva> transductor_detalle(DataTable dt)
        {
            List<Detalle_Reserva> lista = new List<Detalle_Reserva>();
            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Detalle_Reserva detalle = new Detalle_Reserva();
                    detalle.CodigoReserva = Convert.ToInt32(fila["codReserva"]);
                    detalle.CodigoHotel = Convert.ToInt32(fila["codHotel"]);
                    detalle.Habitacion = Convert.ToInt32(fila["habitacion"]);
                    //Transcribir
                    lista.Add(detalle);
                }
            }
            return lista;
        }

        #endregion
    }
}
