using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Dominio;

namespace DOM.Interfaces
{
    public interface DAAOFuncionalidad
    {
        List<Funcionalidad> getAllFuncionalidades();
        Funcionalidad addFuncionalidad(Funcionalidad funcionalidad);
        Funcionalidad getFuncionalidad(string id);
        void updateFuncionalidad(Funcionalidad funcionalidad);
        void deteleFuncionalidad(string id);
    }
}
