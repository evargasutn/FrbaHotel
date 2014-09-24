using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Utilidades
{
    public class IntManager
    {
        public static int GetValue(object obj)
        {
            return Convert.ToInt32(obj);
        }
        public static bool EsNumero(object obj)
        {
            try
            {
                int.Parse(obj.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool estaEnRango(int valor, int min, int max)
        {
            if ((valor < max) && (valor > min))
                return true;
            else
                return false;
        }
    }
}
    