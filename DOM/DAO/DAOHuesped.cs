using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using System.Net.Mail;
using FrbaHotel.DOM;
using DOM.Dominio;
using System.Data;

namespace DOM
{
    public class DAOHuesped : SqlConnector
    {
        public static DataTable obtenerTabla()
        {
            return retrieveDataTable("getHuesped", cadena_nula);
        }

        public static List<Huesped> obtenerTodos()
        {
            return transductor(obtenerTabla());
        }

        public static DataTable obtenerTabla(int id)
        {
            return retrieveDataTable("getHuesped", id);
        }

        public static Huesped obtener(int id)
        {
            List<Huesped> lista = transductor(obtenerTabla(id));
            if (lista.Count == 0)
                return null;
            return lista[0];
        }

        public static bool insertar(Huesped huesped)
        {
            string nombre = huesped.Nombre;
            string apellido = huesped.Apellido;
            string email = huesped.Mail;
            string doc_tipo = huesped.TipoDocu;
            int doc_num = huesped.NroDocu;
            int telefono = huesped.Telefono;
            string dir_calle = huesped.Direccion.calle_direccion;
            int dir_altura = huesped.Direccion.calle_altura;
            string fecha_nacimiento = huesped.Fecha_nacimiento;
            int piso = huesped.Direccion.calle_piso;
            string dpto = huesped.Direccion.calle_dpto;
            return executeProcedure("insertHuesped", nombre, apellido, doc_tipo, doc_num, email, telefono, dir_calle, dir_altura, piso, dpto, fecha_nacimiento);
        }

        public static bool borrar(int id)
        {
            return executeProcedure("deleteHuesped", id);
        }

        public static bool actualizar(Huesped huesped)
        {
            int id = huesped.Id;
            string nombre = huesped.Nombre;
            string apellido = huesped.Apellido;
            string email = huesped.Mail;
            string doc_tipo = huesped.TipoDocu;
            int doc_num = huesped.NroDocu;
            int telefono = huesped.Telefono;
            string dir_calle = huesped.Direccion.calle_direccion;
            int dir_altura = huesped.Direccion.calle_altura;
            int dir_piso = huesped.Direccion.calle_piso;
            string dir_dpto = huesped.Direccion.calle_dpto;
            string fecha_nacimiento = (huesped.Fecha_nacimiento_struct == null) ? huesped.Fecha_nacimiento : cadena_nula;
            int campoBaja = (huesped.Campo_Baja) ? 1 : 0;
            return executeProcedure("updateUsuario", id, nombre, apellido,
                email, doc_tipo, doc_num, telefono, dir_calle, dir_altura, dir_piso,
                dir_dpto, fecha_nacimiento, campoBaja);
        }

        #region Convertir DataTable
        public static List<Huesped> transductor(DataTable tabla)
        {
            List<Huesped> lista = new List<Huesped>();
            foreach (DataRow fila in tabla.Rows)
            {
                //Transcribir
                Huesped huesped = new Huesped();
                huesped.Id = Convert.ToInt32(fila["idHuesped"]);
                huesped.Nombre = Convert.ToString(fila["nombre"]);
                huesped.Apellido = Convert.ToString(fila["apellido"]);
                huesped.TipoDocu = Convert.ToString(fila["tipoDocu"]);
                huesped.NroDocu = Convert.ToInt32(fila["numDocu"]);
                huesped.Localidad = Convert.ToString(fila["localidad"]);
                huesped.Nacionalidad = Convert.ToString(fila["nacionalidad"]);
                huesped.Direccion.calle_direccion = Convert.ToString(fila["direccionCalle"]);
                huesped.Direccion.calle_altura = Convert.ToInt32(fila["direccionNumero"]);
                huesped.Fecha_nacimiento_struct = Convert.ToDateTime(fila["fecNacimiento"]);
                huesped.Campo_Baja = Convert.ToBoolean(fila["campoBaja"]);
                //Campos Nulleables
                huesped.Mail = Convert.ToString(fila["mail"]);
                huesped.Telefono = (fila["telefono"] as Int32?) ?? 0;
                huesped.Direccion.calle_piso = (fila["direccionPiso"] as Int32?) ?? -1;
                huesped.Direccion.calle_dpto = Convert.ToString(fila["direccionDepto"]);

                lista.Add(huesped);
            }
            return lista;
        }
        #endregion
    }
}
