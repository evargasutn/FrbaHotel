using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    public class CancelacionReserva
    {
        #region Atributos
        private int codReserva = -1;
        private string motivo = "";
        private DateTime? fechaCancelacion = null;
        private int estado = -1;
        private string usr = "";
        #endregion

        #region Setters&Getters
        public int Codigo_Reserva
        {
            get { return codReserva; }
            set { codReserva = value; }
        }

        public string Usr
        {
            get { return usr; }
            set { usr = value; }
        }

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        public string Fecha_Cancelacion
        {
            get { return ((DateTime) fechaCancelacion).ToString("yyyyMMdd"); }
            set { fechaCancelacion = DateTime.Parse(value); }
        }

        public DateTime Fecha_Cancelacion_struct
        {
            get { return (DateTime) fechaCancelacion; }
            set { fechaCancelacion = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion
    }
}
