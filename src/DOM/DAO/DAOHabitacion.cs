using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using System.Data;
using DOM.Dominio;

namespace DOM
{
    public class DAOHabitacion : SqlConnector
    {
        public static DataTable obtenerTabla()
        {
            return retrieveDataTable("getHabitacion", entero_nulo, entero_nulo);
        }
        
        public static List<Habitacion> obtenerTodos()
        {
            return transductor(obtenerTabla());
        }

        public static DataTable obtenerTabla(int habitacion, int codHotel)
        {
            return retrieveDataTable("getHabitacion", habitacion, codHotel);
        }

        public static Habitacion obtener(int habitacion, int codHotel)
        {
            List<Habitacion> lista = transductor(obtenerTabla(habitacion, codHotel));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }

        public static bool insertar(Habitacion habitacion)
        {
            int codHotel = habitacion.CodHotel;
            int id = habitacion.Id_Habitacion;
            int piso = habitacion.Piso;
            string ubicacion = habitacion.Ubicacion;
            int tipoCodigo = habitacion.Tipo_codigo;
            string descripcion = habitacion.Descripcion;
            return executeProcedure("insertHabitacion", id, piso, ubicacion, tipoCodigo, codHotel, descripcion);
        }

        public static bool borrar(int habitacion, int codHotel)
        {
            return executeProcedure("deleteHabitacion", habitacion, codHotel);
        }

        public static bool actualizar(Habitacion habitacion)
        {
            int codHotel = habitacion.CodHotel;
            int id = habitacion.Id_Habitacion;
            int piso = habitacion.Piso;
            string ubicacion = habitacion.Ubicacion;
            int tipoCodigo = habitacion.Tipo_codigo;
            string descripcion = habitacion.Descripcion;
            return executeProcedure("updateHabitacion", habitacion, piso, ubicacion, tipoCodigo, codHotel, descripcion);
        }

        #region Convertir DataTable

        public static List<Habitacion> transductor(DataTable dt)
        {
            List<Habitacion> lista = new List<Habitacion>();
            if(dt != null)
            {
                foreach(DataRow fila in dt.Rows)
                {
                    Habitacion habitacion = new Habitacion();
                    habitacion.CodHotel = Convert.ToInt32(fila["codHotel"]);
                    habitacion.Id_Habitacion = Convert.ToInt32(fila["habitacion"]);
                    habitacion.Piso = Convert.ToInt32(fila["piso"]);
                    habitacion.Tipo_codigo = Convert.ToInt32(fila["tipo_codigo"]);
                    habitacion.Descripcion = Convert.ToString(fila["ubicacion"]);
                    habitacion.CampoBaja = Convert.ToBoolean(fila["campoBaja"]);
                    //Transcribir
                    lista.Add(habitacion);
                }
            }
            return lista;
        }

        #endregion
    }
}
