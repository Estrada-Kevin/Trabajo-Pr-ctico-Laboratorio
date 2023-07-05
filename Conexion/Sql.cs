using Logica;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Conexion
{
    public class Sql:Conexion
    {
        /// <summary>
        /// trae el connection string de la clase madre para poder conectarse 
        /// </summary>
        /// <param name="connectionString"></param>
        public Sql(string connectionString): base(connectionString) { }

        /// <summary>
        /// pone por defecto la base de datos que estoy usando
        /// </summary>
        public Sql() : base("\r\nServer=.;Database=Labo TP 2;Trusted_Connection=True;\r\n")
        {

        }

        /// <summary>
        /// ejecuta un query con comandos que devuelven una DataTable
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
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

        /// <summary>
        /// ejecuta un comando que no devuelve nada (INSERT DELETE UPDATE)
        /// </summary>
        /// <param name="comando"></param>
        /// <param name="parametros"></param>

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