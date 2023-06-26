using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;

        /// <summary>
        /// Constructor para inicializar persona con el nombre y apellido
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Persona(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }

        /// <summary>
        /// Consigue informacion dependiendo de quien lo use
        /// </summary>
        /// <returns></returns>
        public abstract string ConseguirInformacionContacto();

        /// <summary>
        /// retorna un string con los datos de los atributos para despues mostrarlos 
        /// </summary>
        /// <returns></returns>
        public virtual string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {_nombre}");
            sb.Append($"Apellido: {_apellido}");

            return sb.ToString();
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
    }
}
