using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Conexion
{
    public class ProductoSql:Sql
    {
        public ProductoSql() { }


        /// <summary>
        /// agrega un producto a la base de datos
        /// </summary>
        /// <param name="producto"></param>
        public void AgregarProducto(Producto<TPlato,TBebida> producto)
        {
            string insertQuery = "INSERT INTO Productos (numeroMesa, plato, bebida) VALUES (@numeroMesa, @plato, @bebida)";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@numeroMesa", producto.NumeroMesa),
                new SqlParameter("@plato", (int)producto.Plato),
                new SqlParameter("@bebida", (int)producto.Bebida)
            };
            EjecutarNonQuery(insertQuery, parametros);
        }
    }
}
