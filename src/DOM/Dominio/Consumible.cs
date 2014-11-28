using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    public class Consumible
    {
        #region Atributos
        private int codigo;
        private string descripcion;
        private double importe;
        private int cantidad;
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
        public double Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        #endregion

    }
}
