using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico___Kevin_Estrada
{
    public class Mesa
    {
        private int _numeroMesa;
        private List<Producto> productos;
        private Cliente cliente;
        private bool mesaDisponible;
        private int costoFinal;

        public Mesa()
        {
            productos = new List<Producto>();
            mesaDisponible = true;
        }

        public Mesa(int numeroMesa):this()
        {
            _numeroMesa = numeroMesa;
        }

        public Mesa(int numeroMesa,Cliente cliente):this(numeroMesa)
        {
            this.cliente = cliente;
        }

        public List<Producto> Productos
        {
            get { return productos; }
            set { if(value != null)
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

        public int CostoFinal
        {

            get 
            {
                costoFinal = 0;
                if (productos != null)
                {
                    foreach (Producto item in productos)
                    {
                        costoFinal += (int)item.Plato + (int)item.Bebida;
                    }
                }
                return costoFinal;
            }
        }

        


    }
}
