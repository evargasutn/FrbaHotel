using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class ErrorFechaIngresadaException : Exception
    {
        public ErrorFechaIngresadaException()
            : base("Error al cargar los controles del formulario.")
        {
        }
        public ErrorFechaIngresadaException(string Mensaje)
            : base(Mensaje)
        {
        }
        public ErrorFechaIngresadaException(string Mensaje, Exception anidada)
            : base(Mensaje, anidada)
        {
        }
    }
}
