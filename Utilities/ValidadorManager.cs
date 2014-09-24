using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades
{
    public class ValidadorManager
    {
        public static string SoloNumeros(string textoAValidar, string nombreEnCasoDeError, bool campoObligatorio)
        {
            string strError = "";
            if(campoObligatorio)
            {
                strError += ValidarNulo(textoAValidar, nombreEnCasoDeError);
            }
            if (strError.Length == 0 && !IntManager.EsNumero(textoAValidar))
            {
                strError += "El campo " + nombreEnCasoDeError + " tiene caracteres invalidos\n";
            }
            return strError;
        }
        public static string SoloTexto(string textoAValidar, string nombreEnCasoDeError, bool campoObligatorio)
        {
            string strError = "";
            if (campoObligatorio)
            {
                strError += ValidarNulo(textoAValidar, nombreEnCasoDeError);
            }else if (!StringManager.EsTexto(textoAValidar))
            {
                strError += "El campo " + nombreEnCasoDeError + " tiene caracteres invalidos\n";
            }
            return strError; 
        }
        public static string SoloFecha(string textoAValidar, string nombreEnCasoDeError, bool campoObligatorio)
        {
            if (campoObligatorio)
            {
                return ValidarNulo(textoAValidar, nombreEnCasoDeError);
            }
            return string.Empty;
        }
        public static string ValidarNulo(string textoAValidar, string nombreEnCasoDeError)
        {
            if (string.IsNullOrEmpty(textoAValidar))
            {
                return "Tiene que ingresar un valor para el campo " + nombreEnCasoDeError + "\n";
            }
            return string.Empty;
        }
        public static string ValidarIguales(string text1, string text2, string nombreEnCasoDeError)
        {
            if (text1 != text2)
            {
                return "Error al verificar la igualdad de " + nombreEnCasoDeError + "\n";
            }
            return string.Empty;
        }
        public static string ValidarNoIguales(string text1, string text2, string nombreEnCasoDeError)
        {
            if (text1 == text2)
            {
                return "Error al verificar la desigualdad de " + nombreEnCasoDeError + "\n";
            }
            return string.Empty;
        }

        public static string ValidarMonto(decimal p, int min)
        {
            if (p > min)
            {
                return string.Empty;
            }

            return "Error al verificar el monto, no supera el minimo \n"; 
        }

        public static string ValidarTipoPago(System.Windows.Forms.RadioButton rdEfectivo, System.Windows.Forms.RadioButton rdTarjeta)
        {
            if (rdTarjeta.Checked == false && rdEfectivo.Checked == false)
            {
                return "Debe seleccionar un tipo de pago.\n" ;
            }
            return string.Empty;
        }
    }
}
