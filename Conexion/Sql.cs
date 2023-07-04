using Logica;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Conexion
{
    public class Sql:Conexion
    {
        public Sql(string connectionString): base(connectionString) { }
        public Sql() : base("\r\nServer=.;Database=Labo TP 2;Trusted_Connection=True;\r\n")
        {

        }

        public DataTable EjecutarQuery(string comando)
        {
            Abrir();
            var command = new SqlCommand(comando, _connection);
            var reader = command.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(reader);
            reader.Close();
            Cerrar();

            return tabla;
            
        }

        public void EjecutarNonQuery(string comando, SqlParameter[] parametros)
        {
            Abrir();
            var command = new SqlCommand(comando, _connection);
            command.Parameters.AddRange(parametros);
            command.ExecuteNonQuery();
            Cerrar();
        }
    }
}