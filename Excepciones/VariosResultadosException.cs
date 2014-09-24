using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class VariosResultadosException : Exception
    {
        public VariosResultadosException() : base("La entidad que se intentó buscar trajo varios resultados")
        {
        }
        public VariosResultadosException(string Mensaje) : base(Mensaje)
        {
        }
        public VariosResultadosException(string Mensaje, Exception anidada)
            : base(Mensaje, anidada)
        {
        }
    }
}
