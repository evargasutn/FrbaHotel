using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class ErrorAlGuardarEstructurasInternasException : Exception
    {
        public ErrorAlGuardarEstructurasInternasException(string Mensaje)
            : base("Se genero un error al guardar las estructuras internas: " + Mensaje)
        {

        }
    }
}
