using System.Reflection;
using System.Text;

namespace Trabajo_Practico___Kevin_Estrada
{

    public partial class Login : Form
    {
        string directoryPath = AppContext.BaseDirectory + "usuarios.txt";
        Administracion administracion;

        /// <summary>       
        /// solo agregar funciones para manipular datos - y logica de como mostrar datos
        /// </summary>
        public Login()
        {
            administracion = new Administracion(directoryPath);
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //AdministracionForm administracionForm = new AdministracionForm();
            //administracionForm.administracionLista = administracion.Usuarios;

            foreach (Usuario item in administracion.Usuarios)
            {
                if(txt_usuario.Text == item.Mail && txt_contraseña.Text == item.Contraseña)
                {
                    MessageBox.Show("Login satisfactorio");
                    //administracionForm.Show();
                    Restaurante rest = new Restaurante();
                    rest.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                    break;
                }
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