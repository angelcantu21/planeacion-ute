using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionDB
    {
        public MySqlConnection conectar;
        String cadenaconex;

        public MySqlConnection conexion()
        {
            cadenaconex = "Server = localhost; Uid = root; Password = ''; Database = proyectoInt; Port= 3306";
            conectar = new MySqlConnection(cadenaconex);
            return conectar;
        }
        public void AbrirConexion()
        {
            conectar.Open();
        }
        public void CerrarConexion()
        {
            conectar.Close();
        }
    }
}
