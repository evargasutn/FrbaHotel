using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Auxiliares
{
    public class DireccionStruct
    {
        #region Atributos Privados
        private string calle;
        private int altura;
        private int piso = -1;
        private string dpto = "";
        #endregion

        #region Getters&Setters
        public string calle_direccion
        {
            get { return calle; }
            set { calle = value; }
        }
        public int calle_altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public int calle_piso
        {
            get { return piso; }
            set { piso = value; }
        }
        public string calle_dpto
        {
            get { return dpto; }
            set { dpto = value; }
        }
        #endregion

        #region Metodos Publicos
        public string obtenerDireccion()
        {
            string direccion = calle + altura.ToString();
            if (piso != -10)
            {
                direccion = direccion + piso.ToString();
                if (dpto != null)
                    direccion = direccion + dpto;
            }
            return direccion;
        }
        #endregion
    }
}
