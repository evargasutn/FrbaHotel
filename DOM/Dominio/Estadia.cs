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
        private int codigoReserva;
        private DateTime fecha_ingreso;
        private Usuario usr_ingreso_estadia;
        private DateTime fecha_egreso;
        private Usuario usr_egreso_estadia;
        private Factura factura;
        private List<EstadiaXConsumible> consumibles = new List<EstadiaXConsumible>();
        #endregion

        #region Setters&Getters
        public int CodigoReserva
        {
            get { return codigoReserva; }
            set { codigoReserva = value; }
        }
        public string Fecha_Ingreso
        {
            get { return fecha_ingreso.ToString("yyyyMMdd"); }
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
        public DateTime Fecha_Ingreso_struct
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }
        public string Fecha_Egreso
        {
            get { return fecha_egreso.ToString("yyyyMMdd"); }
            set { fecha_egreso = DateTime.Parse(value); }
        }
        public DateTime Fecha_Egreso_struct
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
