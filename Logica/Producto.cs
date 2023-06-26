﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Producto
    {
        public enum EPlato
        {
            Burgir = 10,
            Fideos = 12,
            Pizza = 15,
            Pancho = 8,
            Choripan = 11,
            Papas = 7

        }

        public enum EBebida
        {
            Coca = 4,
            Sprite = 5,
            ManaosDeUva = 1,
            Agua = 2,
            FernetConCoca = 6

        }

        EPlato _plato;
        EBebida _bebida;

        public Producto()
        {

        }

        /// <summary>
        /// constructor que asigna los valores de los parametros
        /// </summary>
        /// <param name="plato"></param>
        /// <param name="bebida"></param>
        public Producto(EPlato plato, EBebida bebida) : this()
        {
            _plato = plato;
            _bebida = bebida;
        }

        public EPlato Plato
        {
            get { return _plato; }
            set { _plato = value; }
        }

        public EBebida Bebida
        {
            get { return _bebida; }
            set { _bebida = value; }
        }

        /// <summary>
        /// devuelve un string con los datos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Plato.ToString()} + {Bebida.ToString()}");

            return sb.ToString();
        }
    }
}