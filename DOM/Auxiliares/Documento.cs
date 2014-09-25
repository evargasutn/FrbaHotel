using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Auxiliares
{
    public enum DocumentoTipoEnum { DNI = 0, LC = 1, LE = 2, Pasaporte = 3 };

    class Documento
    {
        private DocumentoTipoEnum tipoDocumento;
        private int numero;

        public int nroDoc
        {
            get {return numero; }
            set {numero = value; }
        }
        public DocumentoTipoEnum tipoDoc
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }

        #region Constructores

        public Documento() { }

        public Documento(int tipoDocu, int num)
        {
            tipoDocumento = (DocumentoTipoEnum)tipoDocu;
            numero = num;
        }

        #endregion
    }
}
