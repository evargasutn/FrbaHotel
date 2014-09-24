using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class NoIdException : Exception
    {
        public NoIdException() : base("Se necesita especificar un ID para realizar el Traer() de un objeto")
        {
        }
        public NoIdException(string Mensaje) : base(Mensaje)
        {
        }
        public NoIdException(string Mensaje, Exception anidada)
            : base(Mensaje, anidada)
        {
        }
    }
}
