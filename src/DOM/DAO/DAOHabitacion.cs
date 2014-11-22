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

        #region Tipo Habitacion
        public static DataTable obtenerTipoTabla(int tipoCodigo)
        {
            return retrieveDataTable("getTipoHabitacion", tipoCodigo);
        }

        public static List<Tipo_Habitacion> obtenerTipoTodos()
        {
            return transductor_tipo(obtenerTipoTabla(entero_nulo));
        }

        public static List<Tipo_Habitacion> obtenerTipo(int tipoCodigo)
        {
            return transductor_tipo(obtenerTipoTabla(tipoCodigo));
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
                    tipo.Porcentual = Convert.ToInt32(fila["tipoPorcentual"]);
                    //Transcribir
                    lista.Add(tipo);
                }
            }
            return lista;
        }

        #endregion
    }
}
