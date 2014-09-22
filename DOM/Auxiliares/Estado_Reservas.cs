using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Auxiliares
{
    interface EstadoReserva
    {
        string nombreEstado();
    }
    class EstadoCorrecta : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            return "Reserva Correcta";
        }

        #endregion
    }
    class EstadoModificada : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            return "Reserva Modificada";
        }

        #endregion
    }
    class EstadoCanceladaRecepcion : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            return "Reserva Cancelada por Recepcion";
        }

        #endregion
    }
    class EstadoCanceladaCliente : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            return "Reserva Cancelada por Cliente";
        }

        #endregion
    }
    class EstadoCanceladaNoShow : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            return "Reserva Cnacelada por No-Show";
        }

        #endregion
    }

    class EstadoEfectivizada : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            return "Reserva Efectivizada";
        }

        #endregion
    }
}
