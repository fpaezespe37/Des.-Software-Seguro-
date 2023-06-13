using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCentro.Usuario
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void FrmUsuario_Activated(object sender, EventArgs e)
        {
            CapaNegocio.CNusuario obj = new CapaNegocio.CNusuario();
            DataTable dt = new DataTable();
            dt = obj.listarUsu();


            ListViewItem fila;

            for (int i=0; i< dt.Rows.Count; i++)
            {
                fila = new ListViewItem(dt.Rows[i]["id_usu"].ToString());
                fila.SubItems.Add(dt.Rows[i]["nom_usu"].ToString());
                fila.SubItems.Add(dt.Rows[i]["foto"].ToString());
                
                fila.SubItems.Add(dt.Rows[i]["nom_rol"].ToString());
                fila.SubItems.Add(dt.Rows[i]["fec_usu"].ToString());
                fila.SubItems.Add(dt.Rows[i]["est_usu"].ToString());

                LVusu.Items.Add(fila);
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmABusu frm = new FrmABusu();
            frm.ShowDialog();
        }
    }
}
