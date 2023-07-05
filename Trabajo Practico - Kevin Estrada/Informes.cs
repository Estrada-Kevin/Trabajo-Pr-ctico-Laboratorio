using iTextSharp.text;
using iTextSharp.text.pdf;
using Logica;
using System.Text.Json;

namespace Trabajo_Practico___Kevin_Estrada
{
    public partial class Informes : Form
    {
        ManejadorDeMesas mesas;
        public event ManejadorDeBotones unClick;

        /// <summary>
        /// constructor que inicializa las mesas y subscribe al evento
        /// </summary>
        /// <param name="mesas"></param>
        public Informes(ManejadorDeMesas mesas)
        {
            this.mesas = mesas;
            InitializeComponent();
            unClick += Delegado.ManejadorDeClicks;
        }

        /// <summary>
        /// boton para salir 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// exporta los datos finales en un archivo csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_csv_Click(object sender, EventArgs e)
        {
            string path = AppContext.BaseDirectory + "archivoCsv.csv";
            if (mesas.Mesas.Count > 0)
            {
                File.WriteAllText(path, mesas.Finalizar());
                MessageBox.Show("Exportado satisfactoriamente");
                unClick?.Invoke(((Button)sender).Name);
            }
            else
            {
                MessageBox.Show("Error mesas vacias");
            }
        }


        /// <summary>
        /// exporta los datos finales en un archivo JSON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_json_Click(object sender, EventArgs e)
        {
            string path = AppContext.BaseDirectory + "archivoJson.json";
            if (mesas.Mesas.Count > 0)
            {
                string jsonString = JsonSerializer.Serialize(mesas.Mesas);
                File.WriteAllText(path, jsonString);
                MessageBox.Show("Exportado satisfactoriamente");
                unClick?.Invoke(((Button)sender).Name);
            }
            else
            {
                MessageBox.Show("Error mesas vacias");
            }

        }

        /// <summary>
        /// exporta los datos finales en un archivo PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PDF_Click(object sender, EventArgs e)
        {
            if(mesas.Mesas.Count>0)
            {
                string path = AppContext.BaseDirectory + "archivoPdf.pdf";
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));

                document.Open();

                foreach (Mesa item in mesas.Mesas)
                {
                    string data =
                      $"Nombre = {item.Cliente.Nombre}\n" +
                      $"Apellido = {item.Cliente.Apellido}\n" +
                      $"Productos = {item.listaProductosAString()}\n" +
                      $"CantidadComensales = {item.Cliente.CantidadComensales}\n" +
                      $"NumeroDeTelefono = {item.Cliente.NumeroDeTelefono}\n" +
                      $"Mesa Disponible = {item.MesaDisponible}\n" +
                      $"NumeroMesa = {item.NumeroMesa}\n" +
                      $"CostoFinal = {item.CostoFinal}";

                    Paragraph paragraph = new Paragraph(data);
                    document.Add(paragraph);
                    document.Add(new Paragraph(" "));
                }
                unClick?.Invoke(((Button)sender).Name);
                document.Close();
                writer.Close();
            }
            else
            {
                MessageBox.Show("Error mesas vacias.");
            }
            
        }
    }
}
