using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Conexion
{
    public class UsuariosSql:Sql
    {
        public List<Usuario> listaUsuarios;

        public UsuariosSql() 
        {
            listaUsuarios= new List<Usuario>();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> listaAuxiliar = new List<Usuario>();
            string query = "SELECT * FROM Usuarios";
            DataTable tabla = this.EjecutarQuery(query);

            if(tabla.Rows.Count > 0) 
            {
                foreach (DataRow item in tabla.Rows)
                {
                    string nombre = item["nombre"].ToString() ?? "";
                    string apellido = item["apellido"].ToString() ?? "";
                    string mail = item["mail"].ToString() ?? "";
                    string contraseña = item["contraseña"].ToString() ?? "";
                    bool esAdministrador = false;
                    if (Convert.ToInt32(item["esAdministrador"]) == 1)
                    {
                        esAdministrador = true;
                    }

                    Usuario usuario = new Usuario(nombre, apellido, mail, contraseña, esAdministrador);
                    listaAuxiliar.Add(usuario);
                }
            }

            return listaAuxiliar;
        }

        public void AgregarUsuario(Usuario usuario) 
        {
            string query = "INSERT INTO Usuarios (nombre, apellido, mail, contraseña, esAdministrador) VALUES (@nombre,@apellido,@mail,@contraseña,@esAdministrador)";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@nombre",usuario.Nombre),
                new SqlParameter("@apellido",usuario.Apellido),
                new SqlParameter("@mail",usuario.Mail),
                new SqlParameter("@contraseña",usuario.Contraseña),
                new SqlParameter("@esAdministrador",SqlDbType.Bit) { Value = usuario.esAdministrador}
            };

            EjecutarNonQuery(query, sqlParameter);
        }

        public void EliminarUsuario(Usuario usuario)
        {
            string query = "DELETE FROM Usuarios WHERE CAST(mail AS NVARCHAR(MAX)) = @mail";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@mail", usuario.Mail)
            };
            EjecutarNonQuery(query,sqlParameter);
        }

        public void CambiarContraseña(Usuario usuario)
        {
            string query = "UPDATE Usuarios SET contraseña = @contraseña WHERE CAST(mail AS NVARCHAR(MAX)) = @mail";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@contraseña",usuario.Contraseña),
                new SqlParameter("@mail",usuario.Mail)
            };
            EjecutarNonQuery(query, sqlParameter);
        }
    }
}
