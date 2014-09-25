using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Dominio
{
    class Estadia
    {
        private int codigoReserva;
        private DateTime fecha_ingreso;
        private Usuario usr_ingreso_estadia;
        private DateTime fecha_egreso;
        private Usuario usr_egreso_estadia;
        private int cod_factura;
        private DateTime fecha_factura;
        private List<Consumible> consumibles = new List<Consumible>();
    }  
}
