using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class ValidarRelacionesException : Exception
    {
         public ValidarRelacionesException() : base("Ocurrio un error al validar las relaciones de la entidad")
        {
        }
        public ValidarRelacionesException(string Mensaje) : base(Mensaje)
        {
        }
        public ValidarRelacionesException(string Mensaje, Exception anidada)
            : base(Mensaje, anidada)
        {
        }
    }
}
