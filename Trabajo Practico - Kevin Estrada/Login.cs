using System.Reflection;
using System.Text;

namespace Trabajo_Practico___Kevin_Estrada
{

    public partial class Login : Form
    {
        string directoryPath = AppContext.BaseDirectory + "usuarios.txt";
        Administracion administracion;

        /// <summary>
        /// constructor que abre directamente el archivo con los usuarios
        /// </summary>
        public Login()
        {
            administracion = new Administracion(directoryPath);
            InitializeComponent();
        }


        /// <summary>
        /// si el usuario es correcto y coincide con la base de datos va a entrar, y si detecta que es admin hace funcionable el boton para dar alta/baja/modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Metodo para autocompletar datos con un usuario admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_autoCompletar_Click(object sender, EventArgs e)
        {
            Usuario user = administracion.Usuarios[0];
            txt_usuario.Text = user.Mail;
            txt_contraseña.Text = user.Contraseña;
            
        }
    }
}