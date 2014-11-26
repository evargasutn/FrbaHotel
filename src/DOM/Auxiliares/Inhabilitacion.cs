using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Auxiliares
{
    public class Inhabilitacion
    {
        #region Atributos
        private int idHotel = -1;
        private DateTime? fecha_inicio = null;
        private DateTime? fecha_fin = null;
        private string motivo = "''";
        #endregion

        #region Propiedades
        public int Hotel
        {
            get { return idHotel; }
            set { idHotel = value; }
        }

        public string Fecha_Inicio
        {
            get { return ((DateTime)fecha_inicio).ToString("yyyyMMdd"); }
            set { fecha_inicio = DateTime.Parse(value); }
        }

        public DateTime? Fecha_Inicio_struct
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }

        public string Fecha_Fin
        {
            get { return ((DateTime)fecha_fin).ToString("yyyyMMdd"); }
            set { fecha_fin = DateTime.Parse(value); }
        }

        public DateTime? Fecha_Fin_struct
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }
        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }
        #endregion
    }
}
