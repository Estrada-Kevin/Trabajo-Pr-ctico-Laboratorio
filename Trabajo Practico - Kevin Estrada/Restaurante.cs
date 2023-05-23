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

        private void Restaurante_Load(object sender, EventArgs e)
        {
            cargarComboBoxes();
            agregarMesas();
            actualizarMesas();
            
        }

        private void btn_mesa1_Click(object sender, EventArgs e)
        {
            if (listb_Productos.Items.Count > 0 && (txt_nombre.Text != null && txt_apellido != null && txt_comensales != null && txt_telefono != null))
            {
                foreach (Mesa item in mesas.Mesas)
                {
                    Button btn = (Button)sender;
                    switch (btn.Name)
                    {
                        case "btn_mesa1":
                            completarMesa(item, 1);
                            break;
                        case "btn_mesa2":
                            completarMesa(item, 2);
                            break;
                        case "btn_mesa3":
                            completarMesa(item, 3);
                            break;
                        case "btn_mesa4":
                            completarMesa(item, 4);
                            break;
                        case "btn_mesa5":
                            completarMesa(item, 5);
                            break;
                        case "btn_mesa6":
                            completarMesa(item, 6);
                            break;

                    }
                }
                actualizarMesas();
            }
            else
            {
                MessageBox.Show("Debe completar los datos antes de asignar la orden a una mesa");
            }

        }

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

        private void actualizarMesas()
        {
            settearColor();
            listb_Productos.Items.Clear();
            txt_apellido.Clear();
            txt_nombre.Clear();
            txt_telefono.Clear();
            txt_comensales.Clear();
        }
        private void agregarMesas()
        {
            mesas.Mesas.Add(m1);
            mesas.Mesas.Add(m2);
            mesas.Mesas.Add(m3);
            mesas.Mesas.Add(m4);
            mesas.Mesas.Add(m5);
            mesas.Mesas.Add(m6);
        }
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
        private Cliente obtenerCliente()
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int comensales = int.Parse(txt_comensales.Text);
            int telefono = int.Parse(txt_telefono.Text);

            Cliente c = new Cliente(nombre, apellido, comensales, telefono);
            return c;
        }

        private void completarMesa (Mesa mesa, int numeroMesa)
        {
            if(mesa.NumeroMesa==numeroMesa && mesa.MesaDisponible==true && productos.Count>0)
            {
                mesa.Productos = productos;
                mesa.Cliente = obtenerCliente();
                mesa.MesaDisponible = false;

                MessageBox.Show(mesa.Cliente.mostrar());
            }
                    
        }
    }
}
