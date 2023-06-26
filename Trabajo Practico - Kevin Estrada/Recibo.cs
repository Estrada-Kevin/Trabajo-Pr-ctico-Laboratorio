using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Trabajo_Practico___Kevin_Estrada
{
    public partial class Recibo : Form
    {
        Mesa mesa;

        /// <summary>
        /// inicializa el atributo mesa para despues sus datos
        /// </summary>
        public Recibo()
        {
            mesa= new Mesa();
            InitializeComponent();
        }

        public Mesa Mesa
        {
            get { return mesa; }
            set { mesa = value; }
        }

        /// <summary>
        /// cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// carga con todos los datos para mostrar tomandolos desde su inicializacion en el otro form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Recibo_Load(object sender, EventArgs e)
        {
            if (mesa != null)
            {
                lbl_nombreCliente.Text = mesa.Cliente.Nombre + mesa.Cliente.Apellido;
                lbl_costoFinal.Text = "Costo final: " + mesa.CostoFinal.ToString() + "US$";

                foreach (Producto item in mesa.Productos)
                {
                    listBox_detallesCompra.Items.Add(item.ToString());
                }
            }
            
            
        }
    }
}
