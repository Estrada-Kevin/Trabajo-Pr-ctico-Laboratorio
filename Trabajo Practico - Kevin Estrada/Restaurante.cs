using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Trabajo_Practico___Kevin_Estrada.Producto;

namespace Trabajo_Practico___Kevin_Estrada
{
    public partial class Restaurante : Form
    {
        ManejadorDeMesas mesas;
        List<Producto> productos;
        Mesa m1;
        Mesa m2;
        Mesa m3;
        Mesa m4;
        Mesa m5;
        Mesa m6;


        /// <summary>
        /// inicializa los atributos
        /// </summary>
        public Restaurante()
        {
            mesas = new ManejadorDeMesas();
            productos = new List<Producto>();
            m1 = new Mesa(1);
            m2 = new Mesa(2);
            m3 = new Mesa(3);
            m4 = new Mesa(4);
            m5 = new Mesa(5);
            m6 = new Mesa(6);
            InitializeComponent();
        }

        /// <summary>
        /// necesari para que al hacer el login chequee si es admin o no
        /// </summary>
        public Button Config
        {
            get { return btn_administrarUsuarios; }
            set { btn_administrarUsuarios = value; }
        }

        /// <summary>
        /// carga los datos necesarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Restaurante_Load(object sender, EventArgs e)
        {
            cargarComboBoxes();
            agregarMesas();
            actualizarMesas();
            
        }

        /// <summary>
        /// agrega la rden a la mesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mesa1_Click(object sender, EventArgs e)
        {

            if (listb_Productos.Items.Count > 0 && !string.IsNullOrWhiteSpace(txt_nombre.Text) && !string.IsNullOrWhiteSpace(txt_apellido.Text) && !string.IsNullOrWhiteSpace(txt_comensales.Text) && !string.IsNullOrWhiteSpace(txt_telefono.Text))
            {
                Button btn = (Button)sender;
                Mesa mesa = null;

                switch (btn.Name)
                {
                    case "btn_mesa1":
                        mesa = m1;
                        break;
                    case "btn_mesa2":
                        mesa = m2;
                        break;
                    case "btn_mesa3":
                        mesa = m3;
                        break;
                    case "btn_mesa4":
                        mesa = m4;
                        break;
                    case "btn_mesa5":
                        mesa = m5;
                        break;
                    case "btn_mesa6":
                        mesa = m6;
                        break;
                }

                if (mesa != null)
                {
                    Recibo recibo = new Recibo();
                    completarMesa(mesa);
                    recibo.Mesa = mesa; 
                    recibo.ShowDialog();
                    btn.Enabled = false;
                    actualizarMesas();
                }
            }
            else
            {
                MessageBox.Show("Debe completar los datos antes de asignar la orden a una mesa");
            }

        }

        /// <summary>
        /// agrega el pedid a la list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_agregarPedido_Click(object sender, EventArgs e)
        {
            
            if(cmbBox_comida.SelectedItem != null && cmbBox_bebida != null )
            {
                EPlato plato = (EPlato)cmbBox_comida.SelectedItem;
                EBebida bebida = (EBebida)cmbBox_bebida.SelectedItem;
                listb_Productos.Items.Add(cmbBox_comida.SelectedItem.ToString() + " " + "+" + cmbBox_bebida.SelectedItem.ToString());
                Producto p = new Producto(plato, bebida);
                productos.Add(p);
            }
            
        }

        /// <summary>
        /// limpia los atributos para usarlos despues otar vez
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button>
            {
                btn_mesa1,
                btn_mesa2,
                btn_mesa3,
                btn_mesa4,
                btn_mesa5,
                btn_mesa6
            };

            foreach (Mesa item in mesas.Mesas)
            {
                item.MesaDisponible = true;
            }
            foreach (Button item in buttons)
            {
                item.Enabled = true;
            }

            productos.Clear();
            mesas.Mesas.Clear();
            agregarMesas();
            actualizarMesas();
            
        }

        /// <summary>
        /// carga los combo box
        /// </summary>

        private void cargarComboBoxes()
        {
            foreach (EPlato item in Enum.GetValues(typeof(EPlato)))
            {
                cmbBox_comida.Items.Add(item);
            }
            foreach (EBebida item in Enum.GetValues(typeof(EBebida)))
            {
                cmbBox_bebida.Items.Add(item);
            }

            cmbBox_comida.SelectedIndex = 0;
            cmbBox_bebida.SelectedIndex = 0;
            
        }


        /// <summary>
        /// actualiza mesas
        /// </summary>
        private void actualizarMesas()
        {
            settearColor();
            listb_Productos.Items.Clear();
            txt_apellido.Clear();
            txt_nombre.Clear();
            txt_telefono.Clear();
            txt_comensales.Clear();
        }

        /// <summary>
        /// agrega mesas a la lista que tiene como atributo
        /// </summary>
        private void agregarMesas()
        {
            mesas.Mesas.Add(m1);
            mesas.Mesas.Add(m2);
            mesas.Mesas.Add(m3);
            mesas.Mesas.Add(m4);
            mesas.Mesas.Add(m5);
            mesas.Mesas.Add(m6);
        }

        /// <summary>
        /// setea la configuracion de color para las mesas disponibles
        /// </summary>
        private void settearColor()
        {
            foreach (Mesa item in mesas.Mesas)
            {
                Button button = new Button();
                switch (item.NumeroMesa)
                {
                    case 1:
                        button = btn_mesa1;
                        break;
                    case 2:
                        button = btn_mesa2;
                        break;
                    case 3:
                        button = btn_mesa3;
                        break;
                    case 4:
                        button = btn_mesa4;
                        break;
                    case 5:
                        button = btn_mesa5;
                        break;
                    case 6:
                        button = btn_mesa6;
                        break;

                }
                if (item.MesaDisponible == true)
                {
                    button.BackColor = Color.Green;
                }
                else
                {
                    button.BackColor = Color.Red;
                }
            }
        }


        /// <summary>
        /// toma los datos desde ls text box y los asigna a un cliente para luego retornarlos
        /// </summary>
        /// <returns></returns>
        private Cliente obtenerCliente()
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int comensales = int.Parse(txt_comensales.Text);
            int telefono = int.Parse(txt_telefono.Text);

            Cliente c = new Cliente(nombre, apellido, comensales, telefono);
            return c;
        }


        /// <summary>
        /// junta todos los datos para usarlos en la mesa
        /// </summary>
        /// <param name="mesa"></param>
        private void completarMesa(Mesa mesa)
        {
            if (mesa.MesaDisponible == true && productos.Count > 0)
            {
                mesa.Productos = new List<Producto>(productos);
                mesa.Cliente = obtenerCliente();
                mesa.MesaDisponible = false;

                productos.Clear();
            }
        }

        /// <summary>
        /// hace el conteo final y los agrega en un txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cerrarRest_Click(object sender, EventArgs e)
        {
            mesas.CerrarDia();
        }


        /// <summary>
        /// abre el form para administrar usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_administrarUsuarios_Click(object sender, EventArgs e)
        {
            AdministracionForm adm = new AdministracionForm();
            adm.ShowDialog();
            
        }
    }
}
