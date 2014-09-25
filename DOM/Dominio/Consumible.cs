using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    class Consumible
    {
        #region Atributos
        private int codigo;
        private string descripcion;
        private int importe;
        #endregion

        #region Propuedades
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        #endregion

    }
}
