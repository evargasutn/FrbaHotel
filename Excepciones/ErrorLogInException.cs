using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class ErrorLogInException : Exception
    {
        public ErrorLogInException() : base("Error al intentar el logueo: usuario o contraseña incorrectos, o el usuario no esta habilitado")
        {
        }
        public ErrorLogInException(string Mensaje) : base(Mensaje)
        {
        }
        public ErrorLogInException(string Mensaje, Exception anidada)
            : base(Mensaje, anidada)
        {
        }
    }
}
