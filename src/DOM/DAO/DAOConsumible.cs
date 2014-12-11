using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using System.Data;
using DOM.Dominio;

namespace DOM
{
    public class DAOConsumible : SqlConnector
    {

        public static DataTable obtenerTabla(int codConsumible)
        {
            return retrieveDataTable("getConsumibles", codConsumible);
        }

        public static DataTable obtenerTablaTodos()
        {
            return obtenerTabla(entero_nulo);
        }

        public static List<Consumible> obtener()
        {
            return transductor(obtenerTabla(entero_nulo));
        }

        public static Consumible obtener(int codConsumible)
        {
            List<Consumible> lista = transductor(obtenerTabla(entero_nulo));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }

        public static Consumible obtener(string descripcion)
        {
            List<Consumible> lista = transductor(retrieveDataTable("getConsumibleByDescripcion", descripcion));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }

        public static DataTable obtenerTablaByEstadia(int codEstadia)
        {
            return retrieveDataTable("getConsumiblesByEstadia", codEstadia);
        }

        public static List<Consumible> obtenerByEstadia(int codEstadia)
        {
            return transductor_ConCant(obtenerTablaByEstadia(codEstadia));
        }

        public static bool insertarConsumibleXEstadia(int codEstadia, int codConsumible, int cant)
        {
            return executeProcedure("insertConsumibleXEstadia", codEstadia, codConsumible, cant);
        }

        public static bool borrarConsumibleXEstadia(int codEstadia, int codConsumible)
        {
            return executeProcedure("deleteConsumibleXEstadia", codEstadia, codConsumible);
        }

        #region Conversores a Consumibles desde DataTable
        public static List<Consumible> transductor(DataTable tabla)
        {
            List<Consumible> lista = new List<Consumible>();
            if (tabla != null)
                foreach (DataRow fila in tabla.Rows)
                {
                    //Transcribir
                    Consumible consumible = new Consumible();
                    consumible.Codigo = Convert.ToInt32(fila["codConsumible"]);
                    consumible.Descripcion = Convert.ToString(fila["descripcion"]);
                    consumible.Importe = Convert.ToDouble(fila["importe"]);
                    lista.Add(consumible);
                }
            return lista;
        }

        public static List<Consumible> transductor_ConCant(DataTable tabla)
        {
            List<Consumible> lista = new List<Consumible>();
            if (tabla != null)
                foreach (DataRow fila in tabla.Rows)
                {
                    //Transcribir
                    Consumible consumible = new Consumible();
                    consumible.Codigo = Convert.ToInt32(fila["codConsumible"]);
                    consumible.Descripcion = Convert.ToString(fila["descripcion"]);
                    consumible.Importe = Convert.ToDouble(fila["importe"]);
                    consumible.Cantidad = Convert.ToInt32(fila["cantidad"]);
                    lista.Add(consumible);
                }
            return lista;
        }
        #endregion
    }
}
