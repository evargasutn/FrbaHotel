using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using System.Data;
using DOM.Dominio;
using DOM.Auxiliares;

namespace DOM
{
    public class DAOHabitacion : SqlConnector
    {
        public static DataTable obtenerTabla(int codHotel)
        {
            return retrieveDataTable("getHabitacion", entero_nulo, codHotel);
        }

        public static List<Habitacion> obtenerTodos(int codHotel)
        {
            return transductor(obtenerTabla(codHotel));
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

        #region Tipo Habitacion
        public static DataTable obtenerTipoTabla(int tipoCodigo)
        {
            return retrieveDataTable("getTipoHabitacion", tipoCodigo);
        }

        public static List<Tipo_Habitacion> obtenerTipoTodos()
        {
            return transductor_tipo(obtenerTipoTabla(entero_nulo));
        }

        public static Tipo_Habitacion obtenerTipo(int tipoCodigo)
        {
            List<Tipo_Habitacion> lista = transductor_tipo(obtenerTipoTabla(tipoCodigo));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }

        public static DataTable obtenerTipoReservaTabla(int codReserva)
        {
            return retrieveDataTable("getTipoHabitacionByReserva", codReserva);
        }

        public static Tipo_Habitacion obtenerTipoByReserva(int codReserva)
        {
            List<Tipo_Habitacion> lista = transductor_tipo(obtenerTipoReservaTabla(codReserva));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }

        public static int obtenerCantHabitacionesByReserva(int codReserva)
        {
            DataTable tabla = obtenerTipoReservaTabla(codReserva);
            if(tabla != null)
            {
                int cant = tabla.Rows.Count;
                int peso_hab = Convert.ToInt32(tabla.Rows[0]["tipoCantidad"]);
                return cant * peso_hab;
            }
            return 0;
        }

        #endregion

        public static bool insertar(Habitacion habitacion)
        {
            int codHotel = habitacion.CodHotel;
            int id = habitacion.Id_Habitacion;
            int piso = habitacion.Piso;
            string ubicacion = habitacion.Ubicacion;
            int tipoCodigo = habitacion.Tipo_codigo;
            string descripcion = habitacion.Descripcion;
            return executeProcedure("insertHabitacion", codHotel, id, piso, ubicacion, tipoCodigo, descripcion);
        }

        public static bool borrar(int habitacion, int codHotel)
        {
            return executeProcedure("deleteHabitacion", codHotel, habitacion);
        }

        public static bool actualizar(Habitacion habitacion)
        {
            int codHotel = habitacion.CodHotel;
            int id = habitacion.Id_Habitacion;
            int piso = habitacion.Piso;
            string ubicacion = habitacion.Ubicacion;
            int tipoCodigo = habitacion.Tipo_codigo;
            string descripcion = habitacion.Descripcion;
            bool campoBaja = habitacion.CampoBaja;
            return executeProcedure("updateHabitacion", codHotel, id, piso, ubicacion, tipoCodigo, descripcion, campoBaja);
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
                    habitacion.Tipo_codigo = Convert.ToInt32(fila["tipoCodigo"]);
                    habitacion.Ubicacion = Convert.ToString(fila["ubicacion"]);
                    habitacion.Descripcion = Convert.ToString(fila["descripcion"]);
                    habitacion.CampoBaja = Convert.ToBoolean(fila["campoBaja"]);
                    //Transcribir
                    lista.Add(habitacion);
                }
            }
            return lista;
        }

        public static List<Tipo_Habitacion> transductor_tipo(DataTable dt)
        {
            List<Tipo_Habitacion> lista = new List<Tipo_Habitacion>();
            if (dt != null)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Tipo_Habitacion tipo = new Tipo_Habitacion();
                    tipo.TipoCodigo = Convert.ToInt32(fila["tipoCodigo"]);
                    tipo.Descripcion = Convert.ToString(fila["tipoDescripcion"]);
                    tipo.Porcentual = Convert.ToDouble(fila["tipoPorcentual"]);
                    tipo.CantPersonas = Convert.ToInt32(fila["tipoCantidad"]);
                    //Transcribir
                    lista.Add(tipo);
                }
            }
            return lista;
        }

        #endregion
    }
}
