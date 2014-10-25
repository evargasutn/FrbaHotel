using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using System.Data;
using DOM.Dominio;

namespace DOM
{
    public class DAORol : SqlConnector
    {

        public static DataTable obtenerTabla()
        {
            return retrieveDataTable("getRol", cadena_nula);
        }

        public static Rol obtener(string nombreRol)
        {
            List<Rol> lista = transductor(retrieveDataTable("getRol", nombreRol));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }

        public static bool insertar(Rol rol)
        {
            string estado = "0";
            if (rol.Estado)
                estado = "1";
            return executeProcedure("insertRol", rol.Nombre, estado);
        }

        public static bool guardar(Rol rol)
        {
            int estado = (rol.Estado) ? 1 : 0;
            return executeProcedure("updateRol", rol.Nombre, estado);
        }

        public static bool borrar(string rolAbaja)
        {
            return executeProcedure("deleteRol", rolAbaja);
        }

        private static List<Rol> transductor(DataTable tabla)
        {
            List<Rol> lista = new List<Rol>();
            if (tabla != null)
                foreach (DataRow fila in tabla.Rows)
                {
                    //Transcribir
                    Rol rol = new Rol();
                    rol.Nombre = Convert.ToString(fila["nombreRol"]);
                    rol.Estado = Convert.ToBoolean(fila["estado"]);
                    lista.Add(rol);
                }
            return lista;
        }
    }
}
