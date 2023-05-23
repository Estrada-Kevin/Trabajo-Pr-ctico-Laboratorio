using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico___Kevin_Estrada
{
    public class Administracion
    {
      
        private List<Usuario> _usuarios;
        private string _path;
        public Administracion(string path)
        {
            _usuarios= new List<Usuario>();
            _path = path;
            LeerUsuarios();
        }

        public List<Usuario> Usuarios
        {
            get { return _usuarios; }
        }
        public void AgregarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
            EscribirUsuarios();
        }
        public void RemoverUsuario(Usuario usuario)
        {
            _usuarios.Remove(usuario);
            EscribirUsuarios();
        }   

        public void ModificarContraseñaUsuario(Usuario usuario,string contraseña)
        {
            foreach (Usuario item in _usuarios)
            {
                if(item==usuario)
                {
                    item.Contraseña = contraseña;
                }
            }
        }

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
                        auxiliar= true;
                    }

                    Usuario usuario = new Usuario(parametros[0],parametros[1],parametros[2],parametros[3],auxiliar);
                    _usuarios.Add(usuario);
                }
            }
        }

        private void EscribirUsuarios()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Usuario item in _usuarios)
            {
                string linea = item.Nombre + "," + item.Apellido + "," + item.Mail + "," + item.Contraseña + "," + item.esAdministrador.ToString();
                sb.AppendLine(linea);
            }

            Lector_De_Archivos.Escribir(_path, sb.ToString());
        }

        
    }
}
