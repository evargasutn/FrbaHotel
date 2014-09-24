using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class NoExisteEntidadException : Exception
    {
        public NoExisteEntidadException() : base("La entidad que se intentó buscar no fue encontrada")
        {
        }
        public NoExisteEntidadException(string Mensaje) : base(Mensaje)
        {
        }
        public NoExisteEntidadException(string Mensaje, Exception anidada)
            : base(Mensaje, anidada)
        {
        }
    }
}
