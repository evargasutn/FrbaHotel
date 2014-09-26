using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Auxiliares
{
    public interface EstadoReserva
    {
        string nombreEstado();
    }
    public class EstadoCorrecta : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            return "Reserva Correcta";
        }

        #endregion
    }
    public class EstadoModificada : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            return "Reserva Modificada";
        }

        #endregion
    }
    public class EstadoCanceladaRecepcion : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            return "Reserva Cancelada por Recepcion";
        }

        #endregion
    }
    public class EstadoCanceladaCliente : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            return "Reserva Cancelada por Cliente";
        }

        #endregion
    }
    public class EstadoCanceladaNoShow : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            return "Reserva Cnacelada por No-Show";
        }

        #endregion
    }
    public class EstadoEfectivizada : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            return "Reserva Efectivizada";
        }

        #endregion
    }
}
