using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using System.Net.Mail;
using FrbaHotel.DOM;
using System.Data;

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

        public static Boolean insertar(Usuario usuario)
        {
            string nombre = usuario.Usr;
            string password = usuario.Password;
            string email = usuario.Mail;
            string tipo_doc = usuario.TipoDocu;

            throw new NotImplementedException();

            //return executeProcedure("insertUsuario", "");
        }

        #region Convertir DataTable
        public static List<Usuario> transductor(DataTable tabla)
        {
            List<Usuario> lista = new List<Usuario>();
            foreach(DataRow fila in tabla.Rows)
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
                user.Telefono = (fila["telefono"] as Int32?) ?? 0;
                user.Direccion.calle_piso = (fila["direccionPiso"] as Int32?) ?? -1;
                user.Direccion.calle_dpto = Convert.ToString(fila["direccionDepto"]);

                //Falta traer las listas de hoteles y roles

                lista.Add(user);
            }
            return lista;
        }
        #endregion
    }
}