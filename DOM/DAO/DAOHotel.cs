using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using FrbaHotel.DOM;
using System.Data;
using DOM.Dominio;

namespace DOM
{
    public class DAOHotel : SqlConnector
    {
        public static DataTable obtenerTabla()
        {
            return retrieveDataTable("getHotel", entero_nulo);
        }
        
        public static List<Hotel> obtenerTodos()
        {
            return tranductor(obtenerTabla());
        }

        public static DataTable obtenerTabla(int codHotel)
        {
            return retrieveDataTable("getHotel", codHotel); 
        }

        public static Hotel obtener(int codHotel)
        {
            List<Hotel> lista = tranductor(obtenerTabla(codHotel));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }

        public static DataTable obtenerByUsr(string usr)
        {
            return retrieveDataTable("getHotelByUsuario", usr);
        }

        public static List<Hotel> obtenerTodos(string usr)
        {
            return tranductor(obtenerByUsr(usr));
        }

        public static bool insertar(Hotel hotel)
        {
            int codHotel = hotel.CodHotel;
            string nombre = hotel.Nombre;
            string mail = hotel.Mail;
            int telefono = hotel.Telefono;
            string dir_calle = hotel.Direccion.calle_direccion;
            int dir_numero = hotel.Direccion.calle_altura;
            string ciudad = hotel.Ciudad;
            string pais = hotel.Pais;
            int estrellas = hotel.Estrellas;
            return executeProcedure("insertHotel", codHotel, nombre, mail, telefono, dir_calle, dir_numero, ciudad, pais, estrellas);
        }

        public static bool borrar(int codHotel, DateTime fecha_inicio, DateTime fecha_fin,string motivo)
        {
            string inicio = fecha_inicio.ToString("yyyyMMdd");
            string fin = fecha_fin.ToString("yyyyMMdd");
            return executeProcedure("deleteHotel", codHotel, inicio, fin, motivo);
        }

        public static bool actualizar(Hotel hotel)
        {
            int codHotel = hotel.CodHotel;
            string nombre = hotel.Nombre;
            string mail = hotel.Mail;
            int telefono = hotel.Telefono;
            string dir_calle = hotel.Direccion.calle_direccion;
            int dir_numero = hotel.Direccion.calle_altura;
            string ciudad = hotel.Ciudad;
            string pais = hotel.Pais;
            int estrellas = hotel.Estrellas;
            return executeProcedure("updateHotel", codHotel, nombre, mail, telefono, dir_calle, dir_numero, ciudad, pais, estrellas);
        }

        #region Convertir DataTable

        private static List<Hotel> tranductor(DataTable dataTable)
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}
