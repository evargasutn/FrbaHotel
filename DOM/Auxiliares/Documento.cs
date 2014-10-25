 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Auxiliares
{
    public enum DocumentoTipoEnum { DNI = 0, LC = 1, LE = 2, Pasaporte = 3 };

    public class Documento
    {
        public static string[] string_docu = new string[4] {"DNI", "LC", "LE", "PASAPORTE"};
        private string tipoDocumento;
        private int numero;

        public int nroDoc
        {
            get {return numero; }
            set {numero = value; }
        }
        public string tipoDoc
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }

        #region Constructores

        public Documento() { }

        public Documento(string tipoDocu, int num)
        {
            tipoDocumento = tipoDocu;
            numero = num;
        }

        #endregion
    }
}
