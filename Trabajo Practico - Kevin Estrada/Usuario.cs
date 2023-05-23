using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico___Kevin_Estrada
{
    public class Usuario : Persona
    {
        private string _mail;
        private string _contraseña;
        private bool _esAdministrador;  

        /// <summary>
        /// constructor que hereda los atributos de personas
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Usuario(string nombre, string apellido):base(nombre, apellido)
        {

        }

        /// <summary>
        /// sobrecarga de constructor con los parametros de la clase misma
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="mail"></param>
        /// <param name="contraseña"></param>
        /// <param name="esAdministrador"></param>
        public Usuario(string nombre, string apellido, string mail, string contraseña, bool esAdministrador):this(nombre,apellido)
        {
            _mail = mail;
            _contraseña = contraseña;
            if(esAdministrador == true)
            {
                _esAdministrador = esAdministrador;
            }
            else
            {
                _esAdministrador = false;
            }
        }

        public string Mail
        {
            get { return _mail; }
        }
        public bool esAdministrador
        {
            get { return _esAdministrador; }
            set { _esAdministrador = value; }
        }
        
        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }    
        }

        
        /// <summary>
        /// funcion que retorna un string con los atributos de la clase madre y la clase actual
        /// </summary>
        /// <returns></returns>
        public override string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.mostrar());
            sb.AppendLine($"Email: {_mail}");
            
            return sb.ToString();
        }

        /// <summary>
        /// funcion abstracta que retorna la informacion de contacto (mail)
        /// </summary>
        /// <returns></returns>
        public override string ConseguirInformacionContacto()
        {
            return Mail;
        }

    }
}
