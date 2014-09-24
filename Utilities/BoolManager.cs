using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades
{
    public class BoolManager
    {
        public static bool GetValue(object obj)
        {
            return Convert.ToBoolean(obj);
        }
        public static bool EsBool(object obj)
        {
            try
            {
                bool.Parse(obj.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
