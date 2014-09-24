using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class ErrorEjecutarConsultaException : Exception
    {
        public ErrorEjecutarConsultaException() : base("Se genero un error al ejecutar una consulta")
        {
        }
        public ErrorEjecutarConsultaException(string NombreStored)
            : base("Se genero un error al ejecutar: " + NombreStored)
        {
        }
        public ErrorEjecutarConsultaException(string NombreStored, Exception anidada)
            : base("Se genero un error al ejecutar: " + NombreStored, anidada)
        {
        }
    }
}
