using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades
{
    public class StringManager
    {
        public static string GetValue(object obj)
        {
            try
            {
                return Convert.ToString(obj.ToString());
            }
            catch(Exception ex)
            {
                return string.Empty;
            }
        }
        public static bool EsTexto(object obj)
        {
            try
            {
                int.Parse(obj.ToString());
                return false;
            }
            catch
            {
                return true;
            }
        }

        public static string GetToDatabase(string Text)
        {
            string nuevoString;
            if (!string.IsNullOrEmpty(Text))
                nuevoString = "%" + Text + "%";
            else
                nuevoString = Text;

            return nuevoString;
        }
    }
}
