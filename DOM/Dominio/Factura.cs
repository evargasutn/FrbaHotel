using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    class Factura
    {
        #region Atributos
        private int numFactura;
        private int codReserva;
        private DateTime fecha;
        private int idHuesped;
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

        public string Fecha
        {
            get { return fecha.ToString("yyyyMMdd"); }
            set { fecha = DateTime.Parse(value); }
        }

        public DateTime Fecha_struct
        {
            get { return fecha; }
            set { fecha = value; }
        }

        #endregion
    }
}
