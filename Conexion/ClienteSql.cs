using Logica;
using System.Data.SqlClient;

namespace Conexion
{
    public class ClienteSql : Sql
    {
        public ClienteSql() { }

        /// <summary>
        /// agrega un cliente a la base tabla cliente de la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        public void AgregarCliente(Cliente cliente)
        {
            string query = "INSERT INTO Clientes (nombre, apellido, cantidadComensales, numeroTelefono, numeroMesa) VALUES (@nombre, @apellido, @cantidadComensales, @numeroTelefono, @numeroMesa)";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", cliente.Nombre),
                new SqlParameter("@apellido", cliente.Apellido),
                new SqlParameter("@cantidadComensales", cliente.CantidadComensales),
                new SqlParameter("@numeroTelefono", cliente.NumeroDeTelefono),
                new SqlParameter("@numeroMesa", cliente.NumeroMesa)
            };

            EjecutarNonQuery(query, parametros);
        }
    }
}
