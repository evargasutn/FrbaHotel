using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class ErrorAlCargarObjetoException : Exception
    {
        public ErrorAlCargarObjetoException() : base("Error al guardar: Se genero un error al cargar la Entidad desde los controles.")
        {
        }
        public ErrorAlCargarObjetoException(string Mensaje) : base(Mensaje)
        {
        }
        public ErrorAlCargarObjetoException(string Mensaje, Exception anidada)
            : base(Mensaje, anidada)
        {
        }
    }
}
