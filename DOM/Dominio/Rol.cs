using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    class Rol
    {
        #region Atributos
        private string nombreRol;
        private string estado;
        private List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombreRol; }
            set { nombreRol = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion

        #region Listas

        public void agregarFuncionalidad(Funcionalidad func)
        {
            funcionalidades.Add(func);
        }

        public Funcionalidad obtenerHotel(int id)
        {
            if ((id >= 0) && (id <= funcionalidades.Count))
                return funcionalidades[id];
            return null;
        }

        public void removerHotel(Funcionalidad func)
        {
            funcionalidades.Remove(func);
        }    

        #endregion
    }
}
