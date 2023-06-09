using Conexion;
using Logica;

namespace Tester
{
    [TestClass]
    public class MetodosAProbar
    {
        /// <summary>
        /// chequea si obtiene usuarios, y chequea que el usuario no sea basura
        /// </summary>
        [TestMethod]
        public void ObtenerUsuariosTest()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            UsuariosSql usuariosSql = new UsuariosSql();
            Usuario usuarioPrueba = new Usuario("Emma", "Johnson", "lsmith@example.com", "carlos",true);

            listaUsuarios = usuariosSql.ObtenerUsuarios();
            bool resultado = false;

            foreach (Usuario item in listaUsuarios)
            {
                if(usuarioPrueba.Mail == item.Mail)
                {
                    resultado = true;
                }
            }

            Assert.IsTrue(listaUsuarios.Count() > 0);
            Assert.IsTrue(resultado);
        }


        /// <summary>
        /// chequea si se agrega correcatamente un usuario
        /// </summary>

        [TestMethod]
        public void AgregarUsuarioTest()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            UsuariosSql usuariosSql = new UsuariosSql();
            Usuario usuarioPrueba = new Usuario("Prueba", "Eliminar", "usuarioAEliminar@gmail.com", "quierosereliminado", false);

            usuariosSql.AgregarUsuario(usuarioPrueba);
            listaUsuarios = usuariosSql.ObtenerUsuarios();

            bool resultado = false;

            foreach (Usuario item in listaUsuarios)
            {
                if(item.Mail == usuarioPrueba.Mail)
                {
                    resultado = true;
                }
            }

            Assert.IsTrue(resultado);
        }


        /// <summary>
        /// chequea si se elimina correcatemente un usuario
        /// </summary>
        [TestMethod]
        public void EliminarUsuarioTest()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            UsuariosSql usuariosSql = new UsuariosSql();
            Usuario usuarioPrueba = new Usuario("Prueba", "Eliminar", "usuarioAEliminar@gmail.com", "quierosereliminado", false);

            usuariosSql.EliminarUsuario(usuarioPrueba);

            bool resultado = true;

            foreach (Usuario item in listaUsuarios)
            {
                if(item.Mail== usuarioPrueba.Mail)
                {
                    resultado = false;
                }
            }

            Assert.IsTrue(resultado);
        }
    }
}