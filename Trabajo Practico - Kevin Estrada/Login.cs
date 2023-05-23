using System.Reflection;
using System.Text;

namespace Trabajo_Practico___Kevin_Estrada
{

    public partial class Login : Form
    {
        string directoryPath = AppContext.BaseDirectory + "usuarios.txt";
        Administracion administracion;

        public Login()
        {
            administracion = new Administracion(directoryPath);
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public Administracion Administracion
        {
            get { return administracion; }
            set { administracion = value; }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            bool loginSatisfactorio = false;

            foreach (Usuario item in administracion.Usuarios)
            {
                if (txt_usuario.Text == item.Mail && txt_contraseña.Text == item.Contraseña)
                {
                    MessageBox.Show("Login satisfactorio");
                    Restaurante rest = new Restaurante();

                    if (item.esAdministrador == true)
                    {
                        rest.Config.Visible = true;
                        rest.Config.Enabled = true;
                    }

                    rest.Show();
                    loginSatisfactorio = true;
                    break;
                }
            }

            if (!loginSatisfactorio)
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void btn_autoCompletar_Click(object sender, EventArgs e)
        {
            Usuario user = administracion.Usuarios[0];
            txt_usuario.Text = user.Mail;
            txt_contraseña.Text = user.Contraseña;
            
        }
    }
}