using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico___Kevin_Estrada
{
    public class Lector_De_Archivos
    {
        /// <summary>
        /// Lee archivos linea por liena y los retorna en forma de Lista
        /// </summary>
        /// <param string="path">direccion del archivo</param>
        /// <returns lista de strings> </returns>
        public static List<string> Leer(string path)
        {
            List<string> lineas = new List<string>();

            if(File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        lineas.Add(linea);  
                    }
                }
                
            }
            return lineas;   
        }

        /// <summary>
        /// Escribe un archivo de texto, si existe concatena el texto mandado como parametro
        /// </summary>
        /// <param string="path">direccion del archivo</param>
        /// <param string="txtAEscribir"></param>
        public static void Escribir(string path, string txtAEscribir)
        {
            if(File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path,true))
                {
                    sw.WriteLine(txtAEscribir);
                }   
            }
            else
            {
                using (StreamWriter sw = File.CreateText(path)) 
                {
                    sw.WriteLine(txtAEscribir);
                }
            }
                
        }

        public static void Sobreescribir(string path, string txtSobreescribir) 
        {
            File.WriteAllText(path, txtSobreescribir);
        }


    }
}
