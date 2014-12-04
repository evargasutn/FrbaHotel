using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    public class Factura
    {
        #region Atributos
        private int numFactura = -1;
        private int codReserva = -1;
        private double monto = -1;
        private DateTime? fecha = null;
        private int idHuesped = -1;
        private List<ItemsFactura> items = new List<ItemsFactura>();
        #endregion

        #region Getters&Setters
        public int NumFactura
        {
            get { return numFactura; }
            set { numFactura = value; }
        }
        public int CodReserva
        {
            get { return codReserva; }
            set { codReserva = value; }
        }
        public int IdHuesped
        {
            get { return idHuesped; }
            set { idHuesped = value; }
        }

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public string Fecha
        {
            get { return ((DateTime)fecha).ToString("yyyyMMdd"); }
            set { fecha = DateTime.Parse(value); }
        }

        public DateTime Fecha_struct
        {
            get { return (DateTime) fecha; }
            set { fecha = value; }
        }

        #endregion
    }
}
