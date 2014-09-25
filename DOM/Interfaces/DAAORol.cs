using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Interfaces
{
    interface DAAORol
    {
        List<Rol> getAllRol();
        Rol addRol(Rol rol);
        Rol getRol(string nombreRol);
        void updateRol(Rol rol);
        void deteleRol(string nombreRol);
    }
}
