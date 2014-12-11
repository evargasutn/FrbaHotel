using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    public class Rol
    {
        #region Atributos
        private string nombreRol = "''";
        private bool estado = true;
        private string usr = "''";
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombreRol; }
            set { nombreRol = value; }
        }
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Usr
        {
            get { return usr; }
            set { usr = value; }
        }
        #endregion
    }
}
