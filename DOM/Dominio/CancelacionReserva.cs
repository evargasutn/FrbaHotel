using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    class CancelacionReserva
    {
        #region Atributos
        private int codReserva;
        private string motivo;
        private DateTime fechaCancelacion;
        private int usr;
        #endregion

        #region Setters&Getters
        public int Codigo_Reserva
        {
            get { return codReserva; }
            set { codReserva = value; }
        }

        public int Usr
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
            get { return fechaCancelacion.ToString("yyyyMMdd"); }
            set { fechaCancelacion = DateTime.Parse(value); }
        }

        public DateTime Fecha_Cancelacion_struct
        {
            get { return fechaCancelacion; }
            set { fechaCancelacion = value; }
        }
        #endregion
    }
}
