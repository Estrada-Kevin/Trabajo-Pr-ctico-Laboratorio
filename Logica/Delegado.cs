using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public delegate void ManejadorDeBotones(string nombreBoton);
    public class Delegado
    {
        /// <summary>
        /// cada vez que se invoca va a escribir en el texto la hora y el boton clickeado
        /// </summary>
        /// <param name="nombreBoton"></param>
        public static void ManejadorDeClicks(string nombreBoton)
        {
            string log = $"{DateTime.Now} - Boton clickeado {nombreBoton}\n";
            File.AppendAllText(AppContext.BaseDirectory + "clicks.txt", log);
        }



    }
}
