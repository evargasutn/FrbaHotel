using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM
{
    class DTOEstadia
    {
        private DateTime fecha_ingreso;
        private DTOUsuario usr_ingreso_estadia;
        private DateTime fecha_egreso;
        private DTOUsuario usr_egreso_estadia;
        private int cod_factura;
        private DateTime fecha_factura;
        private List<DTOConsumible> consumibles;
    }
}
