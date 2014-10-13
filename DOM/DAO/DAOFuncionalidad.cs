using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using DOM.Interfaces;
using DOM.Dominio;
using System.Data;
namespace DOM
{
    public class DAOFuncionalidad : SqlConnector, DAAOFuncionalidad
    {
        string T_FUNCIONALIDAD = "COMPUMUNDO_HIPER_MEGA_RED.FUNCIONALIDADES";
        #region DAAOFuncionalidad Members

        public List<Funcionalidad> getAllFuncionalidades()
        {
            string consulta = "SELECT * FROM " + T_FUNCIONALIDAD;
            //Armar Consulta
            return transductor(retrieveDataTable(consulta));
            //throw new NotImplementedException();
        }

        public Funcionalidad addFuncionalidad(Funcionalidad funcionalidad)
        {
            throw new NotImplementedException();
        }

        public Funcionalidad getFuncionalidad(string id)
        {
            string consulta = "SELECT * FROM " + T_FUNCIONALIDAD + " WHERE usr='" + id + "'";
            //Armar Consulta
            List<Funcionalidad> resultadosConsulta = transductor(retrieveDataTable(consulta));
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
    }
}
