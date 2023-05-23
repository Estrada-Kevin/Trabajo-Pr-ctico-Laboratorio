namespace Trabajo_Practico___Kevin_Estrada
{
    public partial class AdministracionForm : Form
    {
        private Administracion _administracionUsuarios;
        public AdministracionForm()
        {
            InitializeComponent();
            _administracionUsuarios = new Administracion(AppContext.BaseDirectory + "usuarios.txt");
        }

        public Administracion administracionUsuarios
        {
            get { return _administracionUsuarios; }
            set { _administracionUsuarios = value; }
        }

        private void AdministracionForm_Load(object sender, EventArgs e)
        {
            rellenarComboBox();
        }

        private void btn_eliminarUsuario_Click(object sender, EventArgs e)
        {
            foreach (Usuario item in _administracionUsuarios.Usuarios)
            {
                if (cmbx_usuario.SelectedItem.ToString() == item.Mail)
                {
                    DialogResult result = MessageBox.Show("Esta seguro que desea eliminar este usuario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    {
                        if (result == DialogResult.Yes)
                        {
                            _administracionUsuarios.RemoverUsuario(item);
                        }
                    }

                    break;
                }
            }
            actualizarComboBox();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cambiarContraseña_Click(object sender, EventArgs e)
        {
            foreach (Usuario item in _administracionUsuarios.Usuarios)
            {
                if (cmbx_usuario.SelectedItem.ToString() == item.Mail)
                {
                    DialogResult result = MessageBox.Show("Esta seguro que desea cambiar la contraseña este usuario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    {
                        if (result == DialogResult.Yes)
                        {
                            _administracionUsuarios.ModificarContraseñaUsuario(item, txt_contraseñaNueva.Text);
                        }
                    }
                }
            }
            actualizarComboBox();

        }

        private void btn_agregarUsuario_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            if (!string.IsNullOrEmpty(txt_nombre.Text) && !string.IsNullOrEmpty(txt_apellido.Text) && !string.IsNullOrEmpty(txt_mail.Text) && !string.IsNullOrEmpty(txt_nuevoUsuarioContraseña.Text))
            {
                u.Nombre = txt_nombre.Text;
                u.Apellido = txt_apellido.Text;
                u.Mail = txt_mail.Text;
                u.Contraseña = txt_nuevoUsuarioContraseña.Text;
                if (checkBox_esAdmin.Checked)
                {
                    u.esAdministrador = true;
                }
                else
                {
                    u.esAdministrador = false;
                }

                _administracionUsuarios.AgregarUsuario(u);
            }
            actualizarComboBox();

        }

        private void actualizarComboBox()
        {
            cmbx_usuario.Items.Clear();
            rellenarComboBox();
        }

        private void rellenarComboBox()
        {
            foreach (Usuario item in _administracionUsuarios.Usuarios)
            {
                cmbx_usuario.Items.Add(item.Mail);
                cmbx_usuario.SelectedIndex = 0;
            }
        }
    }
}
