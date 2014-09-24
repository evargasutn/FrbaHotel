using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DOM.DAO
{
    class DAOUsuario
    {
        /// Configura un SqlCommand para ejecutar una sentencia con unos parámetros específicos
        /// La conexión tomada por defecto es aquella configurada como 'SqlServer' en el fichero
        /// de configuración.
        /// Daniel García    13/05/2009    Creación
        private SqlCommand ObtenerOrdenSql(string sentenciaSQL, ArrayList Parametros)
        {
            try
            {
                // Creamos una conexión a partir de la ConnectionString del web.config
                SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString);

                // Instanciamos un SqlCommand que ejecutará la sentencia que le pasemos como parámetro con la conexión.
                SqlCommand orden = new SqlCommand(sentenciaSQL, conexion);

                //Configuramos el SqlCommand,indicando que ejecutará una sentencia e inyectándole los parámetros
                orden.CommandType = CommandType.Text;
                foreach (SqlParameter param in Parametros)
                    orden.Parameters.Add(param);

                // Finalmente, devolvemos el SqlCommand
                return orden;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}
