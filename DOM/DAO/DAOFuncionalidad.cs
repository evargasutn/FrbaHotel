using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using DOM.Dominio;
using System.Data;
namespace DOM
{
    public class DAOFuncionalidad : SqlConnector
    {

        public static DataTable getFuncionalidadTable()
        {
            return retrieveDataTable("getFuncionalidad", entero_nulo);
        }
        public static DataTable getFuncionalidadTable(string nombreRol)
        {
            string rol = nombreRol;
            if (rol == "")
                rol = "''";
            return retrieveDataTable("JoinRolFunc", rol);
        }
        public static List<Funcionalidad> getTodasFuncionalidades()
        {
            return transductor(getFuncionalidadTable());
        }
        public static List<Funcionalidad> getFuncionalidad(string nombreRol)
        {
            return transductor(retrieveDataTable("getFuncionalidad", nombreRol));
        }

        public static List<Funcionalidad> transductor(DataTable tabla)
        {
            List<Funcionalidad> lista = new List<Funcionalidad>();
            if(tabla != null)
                foreach (DataRow fila in tabla.Rows)
                {
                    //Transcribir
                    Funcionalidad user = new Funcionalidad();
                    user.Id_funcionalidad = Convert.ToInt32(fila["idFuncionalidad"]);
                    user.Descripcion = Convert.ToString(fila["descripcion"]);
                    lista.Add(user);
                }
            return lista;
        }

        public static void updateFuncXRol(string rol, List<Funcionalidad> alta, List<Funcionalidad> baja)
        {
            foreach(Funcionalidad f in alta)
                agregarFuncionalidad(rol, f.Id_funcionalidad);
            foreach (Funcionalidad f in baja)
                removerFuncionalidad(rol, f.Id_funcionalidad);
        }

        private static void removerFuncionalidad(string rol, int p)
        {
            throw new NotImplementedException();
        }

        private static void agregarFuncionalidad(string rol, int p)
        {
            throw new NotImplementedException();
        }
    }
}
