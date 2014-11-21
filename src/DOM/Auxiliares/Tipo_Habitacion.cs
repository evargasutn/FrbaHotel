using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOM.Auxiliares
{
    public class Tipo_Habitacion
    {
        public int TipoCodigo;
        public string Descripcion;
        public int Porcentual;

        public static int getCodeByDescription(string descripcion, List<Tipo_Habitacion> lista)
        {
            foreach (Tipo_Habitacion tipo in lista)
            {
                if (tipo.Descripcion.CompareTo(descripcion) == 0)
                    return tipo.TipoCodigo;
            }
            return -1;
        }
    } 
}
