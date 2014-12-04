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
            return retrieveDataTable("getEstadia", codReserva);
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

        public static bool ingresarEntrada(Estadia estadia)
        {
            int codReserva = estadia.CodigoReserva;
            string usr = estadia.Usuario_Ingreso.Usr;
            return executeProcedure("insertEstadia", codReserva, usr);
        }

        public static bool ingresarSalida(Estadia estadia)
        {
            int codReserva = estadia.CodigoReserva;
            string usr = estadia.Usuario_Egreso.Usr;
            return executeProcedure("updateEstadia", codReserva, usr);
        }

        public static bool facturar(int codReserva, string tipoPago, string tarjeta)
        {
            return executeProcedure("facturar", codReserva, tipoPago, tarjeta);
        }

        public static DataTable obtenerFacturasTabla(int codReserva)
        {
            return retrieveDataTable("getFacturaReserva", codReserva);
        }

        public static Factura obtenerFactura(int codReserva)
        {
            List<Factura> lista = transductor_facturas(obtenerFacturasTabla(codReserva));
            if (lista.Count == 0)
                return null;
            return lista[0];
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
                    if (!(fila["fecEgreso"] is DBNull))
                        estadia.Fecha_Egreso_struct = Convert.ToDateTime(fila["fecEgreso"]);
                    if (!(fila["usrEgreso"] is DBNull))
                    {
                        Usuario usrEgreso = DAOUsuario.obtener(Convert.ToString(fila["usrEgreso"]));
                        estadia.Usuario_Egreso = usrEgreso;
                    }
                    Usuario usrIngreso = DAOUsuario.obtener(Convert.ToString(fila["usrIngreso"]));
                    estadia.Usuario_Ingreso = usrIngreso;
                    lista.Add(estadia);
                }
            return lista;
        }

        public static List<Factura> transductor_facturas(DataTable tabla)
        {
            List<Factura> lista = new List<Factura>();
            if (tabla != null)
                foreach (DataRow fila in tabla.Rows)
                {
                    //Transcribir
                    Factura factura = new Factura();
                    factura.CodReserva = Convert.ToInt32(fila["codReserva"]);
                    factura.Fecha_struct = Convert.ToDateTime(fila["fecha"]);
                    factura.Monto = Convert.ToDouble(fila["montoTotal"]);
                    factura.IdHuesped = Convert.ToInt32(fila["idHuesped"]);
                    lista.Add(factura);
                }
            return lista;
        }

        #endregion


    }
}
