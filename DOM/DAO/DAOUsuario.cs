using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOM.Auxiliares;
using System.Net.Mail;
using FrbaHotel.DOM;
using DOM.Interfaces;
using System.Data;

namespace DOM
{
    /// <summary>
    /// Clase que representa a la entidad Usuario, almacenada en una fuente de datos
    /// </summary>
    /// 
    /// Tomas Ferraro     24/09/2014    Creación
    ///
    public class DAOUsuario : SqlConnector, DAAOUsuario
    {
        private string T_USUARIOS = "COMPUMUNDO_HIPER_MEGA_RED.USUARIOS";

        #region DAAOUsuario Members

        public List<Usuario> getAllUsuarios()
        {
            string consulta = "SELECT * FROM " + T_USUARIOS;
            //Armar Consulta
            return transductor(retrieveDataTable(consulta));
            //throw new NotImplementedException();
        }

        public Usuario addUsuario(Usuario usuario)
        {
            string cabezal_consulta = "INSERT INTO " + T_USUARIOS + "(";
            string valores = "VALUES (";

            string consulta = completarDatos(cabezal_consulta, valores, usuario);
            executeDynamicQuery(consulta);

            //Falta meterle las listas de hoteles y roles

            return usuario;
            //throw new NotImplementedException();
        }

        public Usuario getUsuario(string usr_id)
        {
            string consulta = "SELECT * FROM " + T_USUARIOS + " WHERE usr='" + usr_id + "'";
            //Armar Consulta
            List<Usuario> resultadosConsulta = transductor(retrieveDataTable(consulta));
            return resultadosConsulta[0];
            //throw new NotImplementedException();
        }

        public void updateUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void deteleUsuario(string usr_id)
        {
            throw new NotImplementedException();
        }

        #endregion

        public string completarDatos(string cabezal, string valores, Usuario usuario)
        {
            string separador = ", ";
            cabezal += "usr"; valores += "'" + usuario.Usr + "'";
            cabezal += separador; valores += separador;

            cabezal += "password"; valores += "'" + usuario.Password + "'";
            cabezal += separador; valores += separador;

            cabezal += "nombre"; valores += "'" + usuario.Nombre + "'";
            cabezal += separador; valores += separador;

            cabezal += "apellido"; valores += "'" + usuario.Apellido + "'";
            cabezal += separador; valores += separador;

            cabezal += "tipoDocu"; valores += "'" + usuario.TipoDocu.ToString() + "'";
            cabezal += separador; valores += separador;

            cabezal += "numDocu"; valores += "'" + usuario.NroDocu.ToString() + "'";
            cabezal += separador; valores += separador;

            cabezal += "direccionCalle"; valores += "'" + usuario.Direccion.calle_direccion + "'";
            cabezal += separador; valores += separador;

            cabezal += "direccionNumero"; valores += "'" + usuario.Direccion.calle_altura + "'";
            cabezal += separador; valores += separador;

            cabezal += "FecNacimiento"; valores += "'" + usuario.Fecha_nacimiento + "'";
            cabezal += separador; valores += separador;

            cabezal += "campoBaja"; valores += "'" + usuario.CampoBaja.ToString() + "'";

            if (usuario.Telefono > 0)
            {
                cabezal += separador; valores += separador;
                cabezal += "telefono"; valores += "'" + usuario.Telefono.ToString() + "'";
            }
            if (usuario.Direccion.calle_piso > -1)
            {
                cabezal += separador; valores += separador;
                cabezal += "direccionPiso"; valores += "'" + usuario.Direccion.calle_piso.ToString() + "'";
            }
            if (!usuario.Direccion.calle_dpto.Equals(""))
            {
                cabezal += separador; valores += separador;
                cabezal += "direccionDepto"; valores += "'" + usuario.Direccion.calle_dpto + "'";
            }
            cabezal += ")"; valores += ")";
            return (cabezal + valores);
        }
        public List<Usuario> transductor(DataTable tabla)
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
                user.TipoDocu = Convert.ToInt32(fila["tipoDocu"]);
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
    }
}