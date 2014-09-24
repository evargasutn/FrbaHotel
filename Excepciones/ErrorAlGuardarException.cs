using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class ErrorAlGuardarException : Exception
    {
        public ErrorAlGuardarException() : base("Error al Guardar: Se genero un error al guardad la Entidad.")
        {
        }
        public ErrorAlGuardarException(string Mensaje) : base(Mensaje)
        {
        }
        public ErrorAlGuardarException(Exception ex)
            : base("Error al Guardar: Se genero un error al guardad la Entidad: " + ex.Message)
        {
        }
        public ErrorAlGuardarException(string Mensaje, Exception anidada)
            : base(Mensaje, anidada)
        {
        }
    }
}
