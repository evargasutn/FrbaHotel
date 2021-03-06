﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.DOM;
using System.Data;
using DOM.Dominio;

namespace DOM.DAO
{
    public class DAORegimen : SqlConnector
    {
        public static DataTable obtenerTabla()
        {
            return retrieveDataTable("getRegimen", entero_nulo);
        }

        public static List<Regimen> obtenerTodos()
        {
            return transductor(obtenerTabla());
        }

        public static DataTable obtenerTabla(int codRegimen)
        {
            return retrieveDataTable("getRegimen", codRegimen);
        }

        public static Regimen obtener(int codRegimen)
        {
            List<Regimen> lista = transductor(obtenerTabla(codRegimen));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }

        public static DataTable obtenerTablaByHotel(int codHotel)
        {
            return retrieveDataTable("getRegimenByHotel", codHotel);
        }

        public static List<Regimen> obtenerByHotel(int codHotel)
        {
            return transductor(obtenerTablaByHotel(codHotel));
        }

        public static bool borrar(int codRegimen)
        {
            return executeProcedure("deteleRegimen", codRegimen);
        }

        public static bool insertar(Regimen regimen)
        {
            string descripcion = regimen.Descripcion;
            double precio = regimen.Precio;
            int campoBaja = (regimen.Estado) ? 1 : 0;
            return executeProcedure("insertRegimen", descripcion, precio, campoBaja);
        }

        public static bool actualizar(Regimen regimen)
        {
            int codRegimen = regimen.CodRegimen;
            string descripcion = regimen.Descripcion;
            double precio = regimen.Precio;
            int campoBaja = (regimen.Estado) ? 1 : 0;
            return executeProcedure("insertRegimen", codRegimen, descripcion, precio, campoBaja);
        }

        //Relacion de muchos a muchos
        public static bool insertarPorHotel(int codRegimen, int codHotel)
        {
            return executeProcedure("insertRegimenXHotel", codRegimen, codHotel);
        }

        public static bool quitarPorHotel(int codRegimen, int codHotel)
        {
            return executeProcedure("deleteRegimenXHotel", codRegimen, codHotel);
        }

        #region Convertidor de DataTable
        private static List<Regimen> transductor(DataTable dataTable)
        {
            List<Regimen> lista = new List<Regimen>();
            if (dataTable != null)
            {
                foreach (DataRow fila in dataTable.Rows)
                {
                    Regimen regimen = new Regimen();
                    regimen.CodRegimen = Convert.ToInt32(fila["codRegimen"]);
                    regimen.Descripcion = Convert.ToString(fila["descripcion"]);
                    regimen.Precio = Convert.ToDouble(fila["precio"]);
                    regimen.Estado = Convert.ToBoolean(fila["estado"]);
                    lista.Add(regimen);
                }
            }
            return lista;
        }
        #endregion
    }
}
