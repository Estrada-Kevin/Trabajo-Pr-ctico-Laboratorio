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

        public Conexion(string connectionString) 
        {   
            _connectionString = connectionString;
        }

        protected void Abrir()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        protected void Cerrar()
        {
            _connection.Close();
        }
    }
}
