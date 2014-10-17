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
        string T_FUNCIONALIDAD = "COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES";
        #region DAAOFuncionalidad Members

        public static List<Funcionalidad> getAllFuncionalidades()
        {
            //string consulta = "SELECT * FROM " + T_FUNCIONALIDAD;
            //Armar Consulta
            //return transductor(obtenerTablaSegunScript(consulta));
            throw new NotImplementedException();
        }

        public Funcionalidad addFuncionalidad(Funcionalidad funcionalidad)
        {
            throw new NotImplementedException();
        }

        public Funcionalidad getFuncionalidad(string id)
        {
            string consulta = "SELECT * FROM " + T_FUNCIONALIDAD + " WHERE usr='" + id + "'";
            //Armar Consulta
            List<Funcionalidad> resultadosConsulta = transductor(obtenerTablaSegunScript(consulta));
            if (resultadosConsulta.Count > 0)
                return resultadosConsulta[0];
            else
                return null;
        }

        public void updateFuncionalidad(Funcionalidad funcionalidad)
        {
            throw new NotImplementedException();
        }

        public void deteleFuncionalidad(string id)
        {
            throw new NotImplementedException();
        }

        #endregion

        public List<Funcionalidad> transductor(DataTable tabla)
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

        public static List<Funcionalidad> getFuncionalidades(string nombreRol)
        {
            throw new NotImplementedException();
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
