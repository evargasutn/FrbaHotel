using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Auxiliares
{
    class Documento
    {
        public enum tipo { DNI, LC, LE, Pasaporte };
        private tipo tipoDocumento;
        private int numero;

        public int nroDoc
        {
            get {return numero; }
            set {numero = value; }
        }
        public tipo tipoDoc
        {
            get {return tipoDocumento;}
            set { tipoDocumento = value;}

    }
}
