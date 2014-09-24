using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class ErrorDatosIngresadosException : Exception
    {
        public ErrorDatosIngresadosException() : base("Error al cargar los controles del formulario.")
        {
        }
        public ErrorDatosIngresadosException(string Mensaje) : base(Mensaje)
        {
        }
        public ErrorDatosIngresadosException(string Mensaje, Exception anidada)
            : base(Mensaje, anidada)
        {
        }
    }
}
