using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaVirtual2020.Datos
{
    public class ConexionBd
    {
        //Campo de solo lectura, esto es, que puede ser modificado
        //únicamente en el método constructor
        private readonly SqlConnection _cnSqlConnection;
        /*Cuando se instancia esta clase
         leo la cadena de conexion y establezco la conexión con la BD*/
        public ConexionBd()
        {
            var cadenaDeConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
            _cnSqlConnection=new SqlConnection(cadenaDeConexion);
        }

        public SqlConnection AbrirConexion()
        {
            if (_cnSqlConnection.State==ConnectionState.Closed)
            {
                _cnSqlConnection.Open();
            }

            return _cnSqlConnection;
        }

        public void CerrarConexion()
        {
            if (_cnSqlConnection.State==ConnectionState.Open)
            {
                _cnSqlConnection.Close();
            }
        }
    }
}
