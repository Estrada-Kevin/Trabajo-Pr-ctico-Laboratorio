using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico___Kevin_Estrada
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
        public Producto(EPlato plato, EBebida bebida):this()
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

    }
}
