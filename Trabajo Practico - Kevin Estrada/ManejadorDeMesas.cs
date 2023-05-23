using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico___Kevin_Estrada
{
    public class ManejadorDeMesas
    {
        private List<Mesa> mesas;

        public ManejadorDeMesas()
        {
            mesas = new List<Mesa>();
        }

        public List<Mesa> Mesas
        {
            get { return mesas; }
            set { mesas = value; }
        }

        public void CerrarDia()
        {

            int auxiliar = 0;
            StringBuilder sb = new StringBuilder();
            foreach (Mesa item in mesas)
            {
                if(item!=null && item.Productos.Count>0)
                {
                    sb.AppendLine($"Mesa {item.NumeroMesa} -Ganancias: {item.CostoFinal}");
                    auxiliar += item.CostoFinal;
                }
            }
            sb.AppendLine($"Ganancias en total: {auxiliar}");

            string path = AppContext.BaseDirectory + "mesas.txt";
            Lector_De_Archivos.Sobreescribir(path, sb.ToString());
        }
    }
}
