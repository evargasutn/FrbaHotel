using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM
{
    class Rol
    {
        private string nombreRol { get { return nombreRol; } set { nombreRol = value; } }
        private string estado { get { return estado; } set { estado = value; } }
        private List<Funcionalidad> funcionalidades { get { return funcionalidades; } set { funcionalidades = value; } }
    }
}
