using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM;
using System.Security.Cryptography;
using System.Data;

namespace FrbaBus
{
    public class SeguridadManager
    {
        public static List<Funcion> lstFuncion;

        private static Usuario oUsuario;
        public static Usuario GetUsuario()
        {
            return oUsuario;
        }
        public static void SetUsuario(Usuario Us)
        {
            
            oUsuario = Us;
        }
        public static void Inicializar()
        {
            FactoryHelper.Inicializar();


            Funcion oFuncion = new Funcion();
            lstFuncion = new List<Funcion>();
            foreach (DataRow item in oFuncion.TraerListado().Tables[0].Rows)
            {
                oFuncion = new Funcion();
                oFuncion.DataRowToObject(item);
                lstFuncion.Add(oFuncion);
            }
        }
        public static string GetSHA256(string text)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            byte[] message = UE.GetBytes(text);
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";

            hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }

        public static void CerrarSession()
        {
            lstFuncion.Clear();
            oUsuario.Limpiar();
        }

        public static string GetCodigoCancelacion()
        {
            string codigo = "";
            // de 10 caracteres alfanumericos
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 10)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            codigo = result;
            //codigo = "genera un codigo random (todo)";
            return codigo;
        }
    }
}
