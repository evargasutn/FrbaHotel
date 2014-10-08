 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DOM.Interfaces
{
    public interface DAAOUsuario
    {
        List<Usuario> getAllUsuarios();
        Usuario addUsuario(Usuario usuario);
        Usuario getUsuario(string usr_id);
        void updateUsuario(Usuario usuario);
        void deteleUsuario(string usr_id);
        List<Usuario> transductor(DataTable tabla);
    }
}
