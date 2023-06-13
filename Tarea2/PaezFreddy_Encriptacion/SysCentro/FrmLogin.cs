using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCentro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;            
        }
        
        private void btnIng_Click(object sender, EventArgs e)
        {
            //Verificar si existe el usuario con la contraseña
            CapaNegocio.CNusuario obj = new CapaNegocio.CNusuario();
            DataTable dt = new DataTable();
            dt = obj.buscarUsu(txtUsu.Text, Encriptar(txtCla.Text));

            if (dt.Rows.Count == 0)
            {
                lblres.Text = "Verificar usuario y contraseña,...";
                txtUsu.SelectionStart = 0;
                txtUsu.SelectionLength = txtUsu.Text.Length;
                txtUsu.Focus();
            }
            else
            {
                //Ingresar al menú
                Program.xusuario = txtUsu.Text;
                Program.xidrol = dt.Rows[0]["id_rol"].ToString();
                FrmMenu frm = new FrmMenu();
                frm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
