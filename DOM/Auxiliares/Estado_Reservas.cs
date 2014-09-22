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
            throw new NotImplementedException();
        }

        #endregion
    }
    class EstadoModificada : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    class EstadoCanceladaRecepcion : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    class EstadoCanceladaCliente : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    class EstadoCanceladaNoShow : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    class EstadoEfectivizada : EstadoReserva
    {
        #region EstadoReserva Members

        public string nombreEstado()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
