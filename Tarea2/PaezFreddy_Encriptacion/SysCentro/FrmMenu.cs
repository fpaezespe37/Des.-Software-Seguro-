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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.xidrol == "1") { 
                Utilitarios.FrmUtilBackup frm = new Utilitarios.FrmUtilBackup();
                frm.ShowDialog();
            }

        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitarios.FrmUtilRestore frm = new Utilitarios.FrmUtilRestore();
            frm.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario.FrmUsuario frm = new Usuario.FrmUsuario();
            frm.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblUsu.Text = Program.xusuario;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Usuario.FrmUsuario frm = new Usuario.FrmUsuario();
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void demoEncriptarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}
