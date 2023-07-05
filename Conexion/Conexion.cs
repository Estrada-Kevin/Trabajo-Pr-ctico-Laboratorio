using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public abstract class Conexion
    {
        protected SqlConnection _connection;
        private string _connectionString;

        /// <summary>
        /// constructor con el connection string para hacer la conexion
        /// </summary>
        /// <param name="connectionString"></param>
        public Conexion(string connectionString) 
        {   
            _connectionString = connectionString;
        }

        /// <summary>
        /// conecta con la base de datos
        /// </summary>
        protected void Abrir()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        /// <summary>
        /// cierra la conexion con la base de datos
        /// </summary>
        protected void Cerrar()
        {
            _connection.Close();
        }
    }
}
