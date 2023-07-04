using Conexion;
using Logica;
using System.Text;
using Logs;

namespace Trabajo_Practico___Kevin_Estrada
{
    public partial class Restaurante : Form
    {
        ManejadorDeMesas mesas;
        List<Producto<TPlato, TBebida>> productos;
        Logger logger;

        /// <summary>
        /// inicializa los atributos
        /// </summary>
        public Restaurante(Usuario usuario)
        {
            mesas = new ManejadorDeMesas();
            productos = new List<Producto<TPlato, TBebida>>();

            logger = new Logger();
            logger.Click += Logger_Click;
            InitializeComponent();
        }

        /// <summary>
        /// necesario para que al hacer el login chequee si es admin o no
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
            actualizarMesas();

        }

        /// <summary>
        /// agrega el pedid a la list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_agregarPedido_Click(object sender, EventArgs e)
        {

            if (cmbBox_comida.SelectedItem != null && cmbBox_bebida != null)
            {
                Mesa numeroMesa = (Mesa)cmbBox_mesas.SelectedItem;
                TPlato plato = (TPlato)cmbBox_comida.SelectedItem;
                TBebida bebida = (TBebida)cmbBox_bebida.SelectedItem;
                listb_Productos.Items.Add(cmbBox_comida.SelectedItem.ToString() + " " + "+" + cmbBox_bebida.SelectedItem.ToString());
                Producto<TPlato, TBebida> p = new Producto<TPlato, TBebida>(plato, bebida, numeroMesa.NumeroMesa);
                productos.Add(p);

                ProductoSql productoSql = new ProductoSql();
                productoSql.AgregarProducto(p);
            }

        }

        /// <summary>
        /// Agrega el pedido a la mesa seleccionada en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_agregarPedidoALaMesa_Click(object sender, EventArgs e)
        {

            if (cmbBox_mesas.SelectedItem != null && (listb_Productos.Items.Count > 0 && !string.IsNullOrWhiteSpace(txt_nombre.Text) && !string.IsNullOrWhiteSpace(txt_apellido.Text) && !string.IsNullOrWhiteSpace(txt_comensales.Text) && !string.IsNullOrWhiteSpace(txt_telefono.Text)))
            {
                Mesa selectedMesa = (Mesa)cmbBox_mesas.SelectedItem;
                if(selectedMesa.MesaDisponible)
                {
                    completarMesa(selectedMesa);
                    mesas.Mesas.Add(selectedMesa);

                    Recibo recibo = new Recibo();
                    recibo.Mesa = selectedMesa;
                    recibo.ShowDialog();
                    actualizarMesas();
                }
                else
                {
                    MessageBox.Show("Mesa llena");
                }
                
            }
            else
            {
                MessageBox.Show("Debe completar los datos antes de asignar la orden a una mesa");
            }
        }

        /// <summary>
        /// limpia los atributos para usarlos despues otar vez
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            foreach (Mesa item in mesas.Mesas)
            {
                item.MesaDisponible = true;
            }

            productos.Clear();
            mesas.Mesas.Clear();
            actualizarMesas();

        }

        /// <summary>
        /// carga los combo box
        /// </summary>

        private void cargarComboBoxes()
        {
            int maxMesas = 6;
            foreach (TPlato item in Enum.GetValues(typeof(TPlato)))
            {
                cmbBox_comida.Items.Add(item);
            }
            foreach (TBebida item in Enum.GetValues(typeof(TBebida)))
            {
                cmbBox_bebida.Items.Add(item);
            }
            for (int i = 1; i <= maxMesas; i++)
            {
                cmbBox_mesas.Items.Add(new Mesa { NumeroMesa = i });
            }

            cmbBox_mesas.SelectedIndex = 0;
            cmbBox_comida.SelectedIndex = 0;
            cmbBox_bebida.SelectedIndex = 0;

        }


        /// <summary>
        /// actualiza mesas
        /// </summary>
        private void actualizarMesas()
        {
            listb_Productos.Items.Clear();
            txt_apellido.Clear();
            txt_nombre.Clear();
            txt_telefono.Clear();
            txt_comensales.Clear();
        }


        /// <summary>
        /// toma los datos desde ls text box y los asigna a un cliente para luego retornarlos
        /// </summary>
        /// <returns></returns>
        private Cliente obtenerCliente()
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int.TryParse(txt_comensales.Text, out int comensales);
            int.TryParse(txt_telefono.Text, out int telefono);
            Mesa mesaAuxiliar = (Mesa)cmbBox_mesas.SelectedItem;
            Cliente c = new Cliente(nombre, apellido, comensales, telefono, mesaAuxiliar.NumeroMesa);
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
                mesa.Productos = new List<Producto<TPlato, TBebida>>(productos);
                mesa.Cliente = obtenerCliente();
                mesa.MesaDisponible = false;

                ClienteSql clienteSql = new ClienteSql();
                clienteSql.AgregarCliente(mesa.Cliente);

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
            Informes informes = new Informes(mesas);
            informes.Show();

            //DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    MessageBox.Show("Archivo guardado.");
            //    this.Close();
            //}


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

        /// <summary>
        /// Crea una nueva lista en el cmb box de mesas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nuevaMesa_Click(object sender, EventArgs e)
        {
            int mesaNueva = cmbBox_mesas.Items.Count + 1;
            cmbBox_mesas.Items.Add(new Mesa { NumeroMesa = mesaNueva });
        }



        /// <summary>
        /// elimina la ultima mesa agregada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_eliminarMesa_Click(object sender, EventArgs e)
        {
            if (cmbBox_mesas.Items.Count > 1)
            {
                cmbBox_mesas.Items.RemoveAt(cmbBox_mesas.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Tiene que haber por lo menos una mesa");
            }
        }

    }
}
