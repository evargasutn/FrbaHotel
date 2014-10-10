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
        private string descripcion;
        #endregion

        #region Setters&Getters
        public int Id_funcionalidad
        {
            get { return id_funcionalidad; }
            set { id_funcionalidad = value; }
        }
        public string Descripcioion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        #endregion
    }
}
