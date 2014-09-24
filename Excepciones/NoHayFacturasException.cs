using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class NoHayFacturasException : Exception
    {
        public NoHayFacturasException()
            : base("Error al Facturar: No se encontraron ventas para facturar.")
        {
        }

    }
}
