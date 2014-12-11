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

        public static List<Rol> obtenerTodos(string usr)
        {
            List<Rol> lista = transductor_usr(retrieveDataTable("JoinUsrRol", usr));
            return lista;
        }

        public static List<Rol> obtenerRolesDeUsuario(string nombreRol)
        {
            List<Rol> lista = transductor_usr(retrieveDataTable("getRolOfUser", nombreRol));
            return lista;
        }
   
        public static bool insertar(Rol rol)
        {
           
            return executeProcedure("insertRol", rol.Nombre, rol.Estado);
        }

        public static bool guardar(Rol rol)
        {

            //int estado = (rol.Estado) ? 1 : 0;
            return executeProcedure("updateRol", rol.Nombre, rol.Estado);
        }

        public static bool borrar(string rolAbaja)
        {
            return executeProcedure("deleteRol", rolAbaja);
        }

        public static List<Rol> traerTodosLosRolesPosibles()
        {
            List<Rol> filtrada = transductor(obtenerTabla()).Where(elemento => elemento.Nombre != "Guest").ToList();
            return filtrada;
        }

        public static bool insertarRolUsuario(string rol, string usr)
        {
            return executeProcedure("insertRolUsuario", rol, usr);
        }

        public static bool borrarRolUsuario(string rol, string usr)
        {
            return executeProcedure("deleteRolUsuario", rol, usr);
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

        private static List<Rol> transductor_usr(DataTable tabla)
        {
            List<Rol> lista = new List<Rol>();
            if (tabla != null)
                foreach (DataRow fila in tabla.Rows)
                {
                    //Transcribir
                    Rol rol = new Rol();
                    rol.Nombre = Convert.ToString(fila["nombreRol"]);
                    rol.Estado = Convert.ToBoolean(fila["estado"]);
                    rol.Usr = Convert.ToString(fila["usr"]);
                    lista.Add(rol);
                }
            return lista;
        }
    }
}
