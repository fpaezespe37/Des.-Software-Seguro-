using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace SysCentro.Utilitarios
{
    public partial class FrmUtilBackup : Form
    {
        public FrmUtilBackup()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void FrmUtilBackup_Load(object sender, EventArgs e)
        {
            uCusuario1.xnombre = Program.xusuario; //Propiedad
            uCusuario1.mostrar();
            //Muestra el contenido de una carpeta
            Contenido.Navigate("D:/BD");
            //webBrowser1.Navigate("http://www.rhsoftperu.com");

            CNutil obj = new CNutil();
            cboBase.DataSource = obj.ListarBD();
            cboBase.DisplayMember = "name";
            cboBase.ValueMember = "dbid";
            

        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            CNutil obj = new CNutil();
            bool xop = true;
            try
            {
                obj.backup(txtNombre.Text, cboBase.Text, (rbDiff.Checked == true) ? (byte)1 : (byte)0);
            }catch(Exception ex)
            {
                xop = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (xop == true) 
                    MessageBox.Show("Se ejecutó el backup, satisfactoriamente");
            }

        }
    }
}
