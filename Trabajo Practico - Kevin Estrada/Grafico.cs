using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Trabajo_Practico___Kevin_Estrada
{
    /// <summary>
    /// delegado que recibe un txt y no devuelve informacion
    /// </summary>
    /// <param name="txt"></param>
    delegate void textoAChart(string txt);
    public partial class Grafico : Form
    {
        public Grafico()
        {
            InitializeComponent();
        }
        /// <summary>
        /// inicializa el form y el chart con sus propiedades necesarias conteniendo la informacino requerida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grafico_Load(object sender, EventArgs e)
        {
            chart.ChartAreas.Add(new ChartArea());
            chart.Series.Add(new Series());
            chart.Series[0].ChartType = SeriesChartType.Point;



            chart.Series.RemoveAt(1);
            chart.Series[0].Name = "Clicks";

            chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";

            textoAChart textoAChart = new textoAChart(insertarInformacionAlChart);


            using (StreamReader reader = new StreamReader(AppContext.BaseDirectory + "clicks.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Invoke(textoAChart, linea);
                }
            }
        }

        /// <summary>
        /// funcion para el delegado que lee el texto con la informacion necesaria
        /// </summary>
        /// <param name="txt"></param>
        private void insertarInformacionAlChart(string txt)
        {
            string[] parts = txt.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2)
            {
                string dateTimeString = parts[0];
                string information = parts[1];

                if (DateTime.TryParse(dateTimeString, out DateTime dateTime))
                {
                    //Agrega la fecha a la parte de abajo
                    chart.Series[0].Points.AddXY(dateTime.Date, dateTime);

                    //Agrega la hora a la parte de la izquierda
                    chart.ChartAreas[0].AxisY.LabelStyle.Format = "HH:mm:ss";
                }
            }
        }

        
    }
}
