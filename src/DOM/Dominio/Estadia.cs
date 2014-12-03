using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
namespace DOM.Dominio
{
    public class Estadia
    {
        #region Atributos
        private int codigoReserva = -1;
        private DateTime? fecha_ingreso = null;
        private Usuario usr_ingreso_estadia = null;
        private DateTime? fecha_egreso = null;
        private Usuario usr_egreso_estadia = null;
        private Factura factura = null;
        #endregion

        #region Setters&Getters
        public int CodigoReserva
        {
            get { return codigoReserva; }
            set { codigoReserva = value; }
        }
        public string Fecha_Ingreso
        {
            get { return ((DateTime)fecha_ingreso).ToString("yyyyMMdd"); }
            set { fecha_ingreso = DateTime.Parse(value); }
        }
        public Usuario Usuario_Ingreso
        {
            get { return usr_ingreso_estadia; }
            set { usr_ingreso_estadia = value; }
        }
        public Usuario Usuario_Egreso
        {
            get { return usr_egreso_estadia; }
            set { usr_egreso_estadia = value; }
        }
        public DateTime? Fecha_Ingreso_struct
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }
        public string Fecha_Egreso
        {
            get { return ((DateTime)fecha_egreso).ToString("yyyyMMdd"); }
            set { fecha_egreso = DateTime.Parse(value); }
        }
        public DateTime? Fecha_Egreso_struct
        {
            get { return fecha_egreso; }
            set { fecha_egreso = value; }
        }
        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }

        #endregion
    }  
}
