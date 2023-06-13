using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCentro.Utilitarios
{
    public partial class FrmUtilRestore : Form
    {
        public FrmUtilRestore()
        {
            InitializeComponent();
        }

        private void FrmUtilRestore_Load(object sender, EventArgs e)
        {
            uCusuario1.xnombre = Program.xusuario;
            uCusuario1.mostrar();
            try
            {                
                webBrowser2.Navigate("D:\\BD"); //Carpeta
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            CapaNegocio.CNutil obj = new CapaNegocio.CNutil();
            string respuesta = obj.restaura(txtNomBd.Text, txtNomCopia.Text);
            lblRes.Text = respuesta;

            //Muestra las BDs
            dataGridView1.DataSource = obj.ListarBD();
        }
    }
}
