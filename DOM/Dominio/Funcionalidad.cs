using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    public class Funcionalidad
    {
        #region Atributos
        private int id_funcionalidad;
        private string descripcion; ////
        #endregion

        #region Setters&Getters
        public int Id_funcionalidad
        {
            get { return id_funcionalidad; }
            set { id_funcionalidad = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        #endregion


        public bool matchFuncionalidadWithDescrp(List<Funcionalidad> lista)
        {
            if (descripcion == null)
                return false;
            for (int i = 0; i < lista.Count; i++)
            {
                if(descripcion == lista[i].descripcion)
                {
                    id_funcionalidad = lista[i].id_funcionalidad;
                    return true;
                }
            }
            return false;
        }
    }
}
