namespace Logica
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
            try
            {
                if (File.Exists(path))
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error al leer archivo", ex.Message);
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
            try
            {
                if (File.Exists(path))
                {
                    using (StreamWriter sw = new StreamWriter(path, true))
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
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error al escribir archivo", ex.Message);
            }


        }

        /// <summary>
        /// sobreescribe el archivo con los datos pasados como parametro
        /// </summary>
        /// <param name="path"></param>
        /// <param name="txtSobreescribir"></param>
        public static void Sobreescribir(string path, string txtSobreescribir)
        {
            try
            {
                File.WriteAllText(path, txtSobreescribir);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al sobreescribir archivo", ex.Message);
            }

        }
    }
}
