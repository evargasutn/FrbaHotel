using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Dominio;
using FrbaHotel.DOM;
using System.Data;

namespace DOM
{
    public class DAOEstadia : SqlConnector
    {
        public static DataTable obtenerTabla(int codReserva)
        {
            return retrieveDataTable("getConsumibles", codReserva);
        }

        public static DataTable obtenerTablaTodos()
        {
            return obtenerTabla(entero_nulo);
        }

        public static List<Estadia> obtener()
        {
            return transductor(obtenerTabla(entero_nulo));
        }

        public static Estadia obtener(int codReserva)
        {
            List<Estadia> lista = transductor(obtenerTabla(codReserva));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }

        public static bool facturar(int codReserva, string tipoPago, string tarjeta)
        {
            return executeProcedure("facturar", codReserva, tipoPago, tarjeta);
        }

        #region Conversores a Estadia desde DataTable

        public static List<Estadia> transductor(DataTable tabla)
        {
            List<Estadia> lista = new List<Estadia>();
            if (tabla != null)
                foreach (DataRow fila in tabla.Rows)
                {
                    //Transcribir
                    Estadia estadia = new Estadia();
                    estadia.CodigoReserva = Convert.ToInt32(fila["codReserva"]);
                    estadia.Fecha_Ingreso_struct = Convert.ToDateTime(fila["fecIngreso"]);
                    estadia.Fecha_Egreso_struct = Convert.ToDateTime(fila["fecEgreso"]);
                    Usuario usrIngreso = DAOUsuario.obtener(Convert.ToString(fila["usrIngreso"]));
                    Usuario usrEgreso = DAOUsuario.obtener(Convert.ToString(fila["usrEgreso"]));
                    estadia.Usuario_Ingreso = usrIngreso;
                    estadia.Usuario_Egreso = usrEgreso;
                    lista.Add(estadia);
                }
            return lista;
        }

        #endregion


    }
}
