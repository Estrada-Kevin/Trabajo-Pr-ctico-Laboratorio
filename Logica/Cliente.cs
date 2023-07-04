using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente : Persona
    {
        private int _cantidadComensales;
        private int _numeroDeTelefono;
        private int _numeroMesa;
        


        /// <summary>
        /// sobrecarga de constructor que agrega los datos de la clase actual
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="numeroTelefono"></param>
        public Cliente(string nombre, string apellido, int cantidadComensales, int numeroTelefono, int numeroMesa) : base(nombre, apellido)
        {
            _cantidadComensales = cantidadComensales;
            _numeroDeTelefono = numeroTelefono;
            _numeroMesa= numeroMesa;
        }

        public int NumeroDeTelefono
        {
            get { return _numeroDeTelefono; }
            set { _numeroDeTelefono = value; }
        }

        public int CantidadComensales
        {
            get { return _cantidadComensales; }
            set { _cantidadComensales = value; }
        }

        public int NumeroMesa
        {
            get { return _numeroMesa; }
            set { _numeroMesa= value; }
        }

        /// <summary>
        /// funcion que retorna un string con los atributos de la clase madre y los de esta clase para luego mostrarlos.
        /// </summary>
        /// <returns></returns>
        public override string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.mostrar());
            sb.AppendLine($"Cantidad de acompañantes: {_cantidadComensales}");


            return sb.ToString();
        }

        /// <summary>
        /// retorna la información de contacto.
        /// </summary>
        /// <returns></returns>
        public override string ConseguirInformacionContacto()
        {
            return NumeroDeTelefono.ToString();
        }

        public string informacionParaExportar()
        {
            return $"{Nombre},{Apellido},{CantidadComensales},{NumeroDeTelefono},{NumeroMesa}";
        }
    }
}
