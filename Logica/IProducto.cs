using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IProducto<TPlato,TBebida>
    {
        TPlato Plato { get; set; }
        TBebida Bebida { get; set; }
    }
}
