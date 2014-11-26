using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using System.Net.Mail;
using FrbaHotel.DOM;
using System.Data;
using System.Security.Cryptography;

namespace DOM
{
    /// <summary>
    /// Clase que representa a la entidad Usuario, almacenada en una fuente de datos
    /// </summary>
    /// 
    /// Tomas Ferraro     24/09/2014    Creación
    ///
    public class DAOUsuario : SqlConnector
    {
        public static DataTable obtenerTabla()
        {
            return retrieveDataTable("getUsuario",cadena_nula);
        }

        public static List<Usuario> obtenerTodos()
        {
            return transductor(obtenerTabla());
        }

        public static DataTable obtenerTabla(string usr)
        {
            return retrieveDataTable("getUsuario",usr);
        }
        
        public static Usuario obtener(string usr)
        {
            List<Usuario> lista = transductor(obtenerTabla(usr));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }

        public static bool insertar(Usuario usuario)
        {
            string usr = usuario.Usr;
            string password = usuario.Password;
            string nombre = usuario.Nombre;
            string apellido = usuario.Apellido;
            string email = usuario.Mail;
            string doc_tipo = usuario.TipoDocu;
            int doc_num = usuario.NroDocu;
            int telefono = usuario.Telefono;
            string dir_calle = usuario.Direccion.calle_direccion;
            int dir_altura = usuario.Direccion.calle_altura;
            string fecha_nacimiento = usuario.Fecha_nacimiento;
            int piso = usuario.Direccion.calle_piso;
            string dpto = usuario.Direccion.calle_dpto;
            return executeProcedure("insertUsuario", usr, password, nombre, apellido, doc_tipo, doc_num, email, telefono, dir_calle, dir_altura, piso, dpto, fecha_nacimiento);
        }

        public static bool borrar(string usr)
        {
            return executeProcedure("deleteUsuario", usr);
        }

        public static bool actualizar(Usuario usuario)
        {
            string usr = usuario.Usr;
            string password = usuario.Password;
            string nombre = usuario.Nombre;
            string apellido = usuario.Apellido;
            string email = usuario.Mail;
            string doc_tipo = usuario.TipoDocu;
            int doc_num = usuario.NroDocu;
            int telefono = usuario.Telefono;
            string dir_calle = usuario.Direccion.calle_direccion;
            int dir_altura = usuario.Direccion.calle_altura;
            int dir_piso = usuario.Direccion.calle_piso;
            string dir_dpto = usuario.Direccion.calle_dpto;
            string fecha_nacimiento = (usuario.Fecha_nacimiento_struct == null) ? usuario.Fecha_nacimiento : cadena_nula;
            int campoBaja = (usuario.CampoBaja) ? 1 : 0;
            return executeProcedure("updateUsuario", usr, password, nombre, apellido,
                doc_tipo, doc_num, email, telefono, dir_calle, dir_altura, dir_piso,
                dir_dpto, fecha_nacimiento, campoBaja);
        }
        
        public static bool registrarIntentoFallido(string usr)
        {
            return executeProcedure("intentoFallidoUsuario", usr);
        }

        public static bool getIntentosFallidos(string usr)
        {
            return executeProcedure("getIntentosFallidosUsuario", usr);
        }

        public static bool insertarHotelUsuario(string usr, string nombreHotel)
        {
            return executeProcedure("insertHotelUsuario", usr, nombreHotel);
        }

        public static bool borrarHotelUsuario(string usr, string nombreHotel)
        {
            return executeProcedure("deleteHotelUsuario", usr, nombreHotel);
        }

        #region Convertir DataTable
        public static List<Usuario> transductor(DataTable tabla)
        {
            List<Usuario> lista = new List<Usuario>();
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    //Transcribir
                    Usuario user = new Usuario();
                    user.Usr = Convert.ToString(fila["usr"]);
                    user.Password = Convert.ToString(fila["password"]);
                    user.Nombre = Convert.ToString(fila["nombre"]);
                    user.Apellido = Convert.ToString(fila["apellido"]);
                    user.TipoDocu = Convert.ToString(fila["tipoDocu"]);
                    user.NroDocu = Convert.ToInt32(fila["numDocu"]);
                    user.Direccion.calle_direccion = Convert.ToString(fila["direccionCalle"]);
                    user.Direccion.calle_altura = Convert.ToInt32(fila["direccionNumero"]);
                    user.Fecha_nacimiento_struct = Convert.ToDateTime(fila["fecNacimiento"]);
                    user.CampoBaja = Convert.ToBoolean(fila["campoBaja"]);
                    //Campos Nulleables
                    user.Mail = Convert.ToString(fila["mail"]);
                    if(!(fila["telefono"] is DBNull))
                        user.Telefono = Convert.ToInt32(fila["telefono"]);
                    if (!(fila["direccionPiso"] is DBNull))
                        user.Direccion.calle_piso = Convert.ToInt32(fila["direccionPiso"]);
                    user.Direccion.calle_dpto = Convert.ToString(fila["direccionDepto"]);

                    //Falta traer las listas de hoteles y roles

                    lista.Add(user);
                }
            }
            return lista;
        }
        #endregion


        #region Hash Password
        public static string hashPassword(string password)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] hash = SHA256.Create().ComputeHash(data);

            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }
        #endregion

    }
}