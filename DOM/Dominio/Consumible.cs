using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    class Consumible
    {
        #region Atributos Privados
        private int codigo;
        private string descripcion;
        private int importe;
        #endregion

        #region Getters&Seters
        public int codigoConsumible
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string descripcionConsumible
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public int importeConsumible
        {
            get { return importe; }
            set { importe = value; }
        }
        #endregion

    }
}
