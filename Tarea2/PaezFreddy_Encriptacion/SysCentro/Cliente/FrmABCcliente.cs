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
    public partial class FrmABCcliente : Form
    {
        public FrmABCcliente()
        {
            InitializeComponent();
        }

        private void FrmABCcliente_Load(object sender, EventArgs e)
        {
            llenarCli();
            cboEst.SelectedIndex = 0;
            if (lblOp.Text == "Editar")
            {
                CapaNegocio.CNcliente obj = new CapaNegocio.CNcliente();
                DataTable tb = new DataTable();
                tb = obj.BuscarCliId(int.Parse(lblId.Text));
                txtNom.Text = tb.Rows[0]["nom_cli"].ToString();
                txtApe.Text = tb.Rows[0]["ape_cli"].ToString();
                cboDis.Text = tb.Rows[0]["nom_dis"].ToString();
                txtDeuda.Text = tb.Rows[0]["deuda"].ToString();
                if (tb.Rows[0]["est_cli"].ToString() == "A")
                {
                    cboEst.SelectedIndex = 0;
                }
                else
                {
                    cboEst.SelectedIndex = 1;
                }
            }
        }
        public void llenarCli()
        {
            CapaNegocio.CNgeneral obj = new CapaNegocio.CNgeneral();
            cboDis.DisplayMember = "nom_dis";
            cboDis.ValueMember = "id_dis";
            cboDis.DataSource = obj.ListarDis();
            cboDis.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapaNegocio.CNcliente obj = new CapaNegocio.CNcliente();
            if (lblOp.Text == "Nuevo")
            {
                string resultado = obj.IngCli(txtNom.Text, txtApe.Text, int.Parse(cboDis.SelectedValue.ToString()), decimal.Parse(txtDeuda.Text));
            }
            else
            {
                string resultado = obj.ModCli(int.Parse(lblId.Text), txtNom.Text, txtApe.Text, int.Parse(cboDis.SelectedValue.ToString()), decimal.Parse(txtDeuda.Text), cboEst.Text.Substring(0, 1));
            }
            this.Close();
        }
    }
}
