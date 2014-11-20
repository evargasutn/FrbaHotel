using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using FrbaHotel.DOM;
using System.Data;
using DOM.Dominio;
using DOM.Auxiliares;

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

        public static bool borrar(Inhabilitacion inhab/*int codHotel, DateTime fecha_inicio, DateTime fecha_fin,string motivo*/)
        {
            string codHotel = inhab.Hotel.ToString();
            string motivo = inhab.Motivo;
            string inicio = inhab.Fecha_Inicio;
            string fin = inhab.Fecha_Fin;
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

        public static int estaVacio(int codHotel, DateTime inicio, DateTime fin)
        {
            string fecha_inicio = inicio.ToString("yyyyMMdd");
            string fecha_fin = fin.ToString("yyyyMMdd");
            //Retorna 1 si esta vacio, 0 si no
            return executeProcedureWithReturnValue("hotelEstaVacio", codHotel, fecha_inicio, fecha_fin);
        }

        #region Convertir DataTable

        private static List<Hotel> tranductor(DataTable dataTable)
        {
            List<Hotel> lista = new List<Hotel>();
            if (dataTable != null)
            {
                foreach(DataRow fila in dataTable.Rows)
                {
                    Hotel hotelito = new Hotel();
                    hotelito.CodHotel = Convert.ToInt32(fila["codHotel"]);
                    hotelito.Nombre = Convert.ToString(fila["nombreHotel"]);
                    hotelito.Mail = Convert.ToString(fila["mail"]);
                    hotelito.Telefono = Convert.ToInt32(fila["telefono"]);
                    hotelito.Direccion.calle_direccion = Convert.ToString(fila["direccionCalle"]);
                    hotelito.Direccion.calle_altura = Convert.ToInt32(fila["direccionNumero"]);
                    hotelito.Ciudad = Convert.ToString(fila["ciudad"]);
                    hotelito.Pais = Convert.ToString(fila["pais"]);
                    hotelito.Estrellas = Convert.ToInt32(fila["cantEstrellas"]);
                    lista.Add(hotelito);
                }
            }
            return lista;
        }

        #endregion


    }
}
