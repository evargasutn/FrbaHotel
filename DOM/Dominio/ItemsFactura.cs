using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    public class ItemsFactura
    {
        private int numItem;
        private string descripcion;
        private double monto;

        public int NumItem
        {
            get { return numItem; }
            set { numItem = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

    }
}
