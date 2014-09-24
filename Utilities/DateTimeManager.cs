using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades
{
    public class DateTimeManager
    {
        public static bool EsFecha(string fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DateTime GetValue(object obj)
        {
            try
            {
                return Convert.ToDateTime(obj.ToString());
            }
            catch
            {
                return DateTime.MinValue;
            }
        }
        public static object GetToDataBase(object obj)
        {
            if (Convert.ToDateTime(obj.ToString()) != DateTime.MinValue)
            {
                return Convert.ToDateTime(obj.ToString());
            }
            else
            {
                return DBNull.Value;
            }
        }
        public static bool Between(DateTime valor, DateTime minimo, DateTime maximo)
        {
            return (valor >= minimo && valor <= maximo);
        }
    }
}
