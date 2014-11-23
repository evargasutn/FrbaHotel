using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using System.Data;
using DOM.Dominio;


namespace DOM
{
    public class DAOReportes : SqlConnector
    {

        public static DataTable HotelesMayorDiasInhabilitado(int opcion, int anio)
        {

            return retrieveDataTable("getHotelesMayorDiasInhabilitado", opcion, anio);
        }

        public static DataTable HotelesMayorCancelaciones(int opcion, int anio)
        {

            return retrieveDataTable("getHotelesMayorCancelaciones", opcion, anio);
        }

        public static DataTable HotelesMayorConsumiblesFacturados(int opcion, int anio)
        {
            return retrieveDataTable("getHotelesMayorConsumiblesFacturados", opcion, anio);
        }

        public static DataTable MejorCliente(int opcion, int anio)
        {
            return retrieveDataTable("getMejorCliente", opcion, anio);
        }

        public static DataTable HabitacionesMayorCantOcupadas(int opcion, int anio)
        {
            return retrieveDataTable("getHabitacionesMayorCantOcupadas", opcion, anio);
        }
    }
}
