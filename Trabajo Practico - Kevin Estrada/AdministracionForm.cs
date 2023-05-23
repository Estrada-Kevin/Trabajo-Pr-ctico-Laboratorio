using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico___Kevin_Estrada
{
    public partial class AdministracionForm : Form
    {
        private List<Usuario> _administracionUsuarios;
        public AdministracionForm()
        {
            InitializeComponent();
        }

        public List<Usuario> administracionLista
        {
            get { return _administracionUsuarios; }
            set { _administracionUsuarios = value;}
        }

        private void AdministracionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
