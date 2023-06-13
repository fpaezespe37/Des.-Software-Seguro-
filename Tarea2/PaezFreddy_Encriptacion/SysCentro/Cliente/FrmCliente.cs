using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCentro.Cliente
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
        CapaNegocio.CNcliente obj = new CapaNegocio.CNcliente();
        private void FrmCliente_Activated(object sender, EventArgs e)
        {
            DGcli.DataSource = obj.ListarCli();
            mostrar_datos();
        }
        public void mostrar_datos()
        {
            DGcli.Columns[0].Width = 50;
            DGcli.Columns[0].HeaderText = "Id";

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmABCcliente frm = new FrmABCcliente();
            frm.lblOp.Text = "Nuevo";

            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmABCcliente frm = new FrmABCcliente();
            frm.lblOp.Text = "Editar";
            frm.lblId.Text = DGcli.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
        }
    }
}
