using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using System.Net.Mail;
using FrbaHotel.DOM;
using DOM.Interfaces;

namespace DOM
{
    /// <summary>
    /// Clase que representa a la entidad Usuario, almacenada en una fuente de datos
    /// </summary>
    /// 
    /// Tomas Ferraro     24/09/2014    Creación
    ///
    public class DAOUsuario : SqlConnector, DAAOUsuario
    {

        #region DAAOUsuario Members

        public List<Usuario> getAllUsuarios()
        {
            throw new NotImplementedException();
        }

        public Usuario addUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario getUsuario(string usr_id)
        {
            throw new NotImplementedException();
        }

        public void updateUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void deteleUsuario(string usr_id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}