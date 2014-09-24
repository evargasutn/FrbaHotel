using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Utilidades
{
    public class DecimalManager
    {
        public static decimal GetValue(object obj)
        {
            return Convert.ToDecimal(obj.ToString());
        }
        public static bool EsDecimal(object obj)
        {
            try
            {
                float.Parse(obj.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
