using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Administracion
    {
        private List<Usuario> _usuarios;
        private string _path;

        /// <summary>
        /// Constructor con el path hacia el archivo incluido asi lee los usuarios al isntanciar el objeto
        /// </summary>
        /// <param name="path"></param>
        public Administracion(string path)
        {
            _usuarios = new List<Usuario>();
            _path = path;
            LeerUsuarios();
        }

        public List<Usuario> Usuarios
        {
            get { return _usuarios; }
        }
        /// <summary>
        /// Agrega al usuario pasado como parametro y despues modifica el texto
        /// </summary>
        /// <param name="usuario"></param>
        public void AgregarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
            EscribirUsuarios();
        }

        /// <summary>
        /// Eliminar el usuario pasado como parametro y modifica el texto acorde
        /// </summary>
        /// <param name="usuario"></param>
        public void RemoverUsuario(Usuario usuario)
        {
            _usuarios.Remove(usuario);
            EscribirUsuarios();
        }

        /// <summary>
        /// modifica la contraseña pasada como parametros comparando el usuario pasado como parametro 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        public void ModificarContraseñaUsuario(Usuario usuario, string contraseña)
        {
            foreach (Usuario item in _usuarios)
            {
                if (item == usuario)
                {
                    item.Contraseña = contraseña;
                }
            }
            EscribirUsuarios();
        }

        /// <summary>
        /// lee el arhivo de usuarios
        /// </summary>
        private void LeerUsuarios()
        {
            List<string> lineas = Lector_De_Archivos.Leer(_path);
            foreach (string item in lineas)
            {
                string[] parametros = item.Split(',');
                if (parametros.Length == 5)
                {
                    bool auxiliar = false;
                    if (parametros[4] == "True")
                    {
                        auxiliar = true;
                    }

                    Usuario usuario = new Usuario(parametros[0], parametros[1], parametros[2], parametros[3], auxiliar);
                    _usuarios.Add(usuario);
                }
            }
        }

        /// <summary>
        /// parsea los usuarios en forma de texto para poder escribirlos 
        /// </summary>
        private void EscribirUsuarios()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Usuario item in _usuarios)
            {
                string linea = item.Nombre + "," + item.Apellido + "," + item.Mail + "," + item.Contraseña + "," + item.esAdministrador.ToString();
                sb.AppendLine(linea);
            }

            Lector_De_Archivos.Sobreescribir(_path, sb.ToString());
        }
    }
}
