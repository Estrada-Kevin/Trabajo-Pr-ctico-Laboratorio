using System.Text;

namespace Logica
{
    public class Mesa
    {
        private int _numeroMesa;
        private List<Producto<TPlato, TBebida>> productos;
        private Cliente cliente;
        private bool mesaDisponible;
        private int costoFinal;

        /// <summary>
        /// inicializa las mesas y las hace disponible
        /// </summary>
        public Mesa()
        {
            productos = new List<Producto<TPlato, TBebida>>();
            mesaDisponible = true;
        }

        /// <summary>
        /// constructor con solo el numero de mesa en caso de ser necesario
        /// </summary>
        /// <param name="numeroMesa"></param>
        public Mesa(int numeroMesa) : this()
        {
            _numeroMesa = numeroMesa;
        }

        /// <summary>
        /// constructor con todos los datos 
        /// </summary>
        /// <param name="numeroMesa"></param>
        /// <param name="cliente"></param>
        public Mesa(int numeroMesa, Cliente cliente) : this(numeroMesa)
        {
            this.cliente = cliente;
        }


        public List<Producto<TPlato,TBebida>> Productos
        {
            get { return productos; }
            set
            {
                if (value != null)
                {
                    productos = value;
                }
            }
        }
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public bool MesaDisponible
        {
            get { return mesaDisponible; }
            set { mesaDisponible = value; }
        }
        public int NumeroMesa
        {
            get { return _numeroMesa; }
            set { _numeroMesa = value; }
        }

        public override string ToString()
        {
            return "Mesa " + NumeroMesa.ToString();
        }


        /// <summary>
        /// calcula el costo final
        /// </summary>
        public int CostoFinal
        {

            get
            {
                costoFinal = 0;
                if (productos != null)
                {
                    foreach (Producto<TPlato, TBebida> item in productos)
                    {
                        costoFinal += (int)item.Plato + (int)item.Bebida;
                    }
                }
                return costoFinal;
            }
        }

        public string informacionParaExportar()
        {
            return $"{mesaDisponible},{_numeroMesa},{CostoFinal}";
        }

        public string listaProductosAString()
        {

            List<string> productNames = new List<string>();
            foreach (Producto<TPlato,TBebida> item in productos)
            {
                productNames.Add(item.ToString());
            }

            return string.Join(",", productNames);
        }
    }
}