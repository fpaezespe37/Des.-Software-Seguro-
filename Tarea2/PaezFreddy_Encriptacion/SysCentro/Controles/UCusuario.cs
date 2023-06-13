using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCentro.Controles
{
    public partial class UCusuario : UserControl
    {
        public UCusuario()
        {
            InitializeComponent();
        }
        // propiedad
        public string xnombre;

        private void UCusuario_Load(object sender, EventArgs e)
        {
            
        }
        //Método
        public void mostrar()
        {
            lblUsu.Text = xnombre;
        }

        private void lblUsu_Click(object sender, EventArgs e)
        {

        }
    }
}
