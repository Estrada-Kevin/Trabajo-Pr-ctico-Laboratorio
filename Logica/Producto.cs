using System.Text;

namespace Logica
{
    public enum TPlato
    {
        Burgir = 10,
        Fideos = 12,
        Pizza = 15,
        Pancho = 8,
        Choripan = 11,
        Papas = 7
    }

    public enum TBebida
    {
        Coca = 4,
        Sprite = 5,
        ManaosDeUva = 1,
        Agua = 2,
        FernetConCoca = 6
    }
    public class Producto<TPlato, TBebida> : IProducto<TPlato, TBebida>
    {
        TPlato _plato;
        TBebida _bebida;
        int _numeroMesa;
        public Producto()
        {

        }

        /// <summary>
        /// constructor que asigna los valores de los parametros
        /// </summary>
        /// <param name="plato"></param>
        /// <param name="bebida"></param>
        public Producto(TPlato plato, TBebida bebida, int numeroMesa) : this()
        {
            _plato = plato;
            _bebida = bebida;
            _numeroMesa = numeroMesa;
        }

        public TPlato Plato
        {
            get { return _plato; }
            set { _plato = value; }
        }

        public TBebida Bebida
        {
            get { return _bebida; }
            set { _bebida = value; }
        }

        public int NumeroMesa
        {
            get { return _numeroMesa; }
            set { _numeroMesa = value; }
        }
        /// <summary>
        /// devuelve un string con los datos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Plato.ToString()},{Bebida.ToString()}";
        }
    }

    
}
