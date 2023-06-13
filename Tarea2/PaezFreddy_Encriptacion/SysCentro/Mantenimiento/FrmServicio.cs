using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysCentro.Mantenimiento
{
    public partial class FrmServicio : Form
    {
        public FrmServicio()
        {
            InitializeComponent();
        }

        private void FrmServicio_Load(object sender, EventArgs e)
        {
            this.Height = 306;
            CapaNegocio.CNservicio obj = new CapaNegocio.CNservicio();
            DGser.DataSource = obj.ListarSer();
            mostrar_datos();
            cboEst.SelectedIndex = 0; 
        }
        public void mostrar_datos()
        {
            
            DGser.Columns[0].Width = 50;
            DGser.Columns[1].Width = 200;
            DGser.Columns[2].Width = 70;
            DGser.Columns[3].Width = 40;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.Height = 456;
            btnGrabar.Text = "Grabar";
            txtSer.Clear();
            txtTar.Text = "0.00";
            cboEst.SelectedIndex = 0;
            txtSer.Focus();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Height = 456;
            btnGrabar.Text = "Actualizar";

            lblId.Text = DGser.CurrentRow.Cells[0].Value.ToString();
            txtSer.Text = DGser.CurrentRow.Cells[1].Value.ToString();
            txtTar.Text = DGser.CurrentRow.Cells[2].Value.ToString();
            string xe = DGser.CurrentRow.Cells[3].Value.ToString();
            if (xe == "A")
            {
                cboEst.SelectedIndex = 0; //Activado
            }
            else
            {
                cboEst.SelectedIndex = 1; //Desactivado
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Height = 306;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            this.Height = 306;
            CapaNegocio.CNservicio obj = new CapaNegocio.CNservicio();

            if (btnGrabar.Text == "Grabar")
            {                
                string resultado = obj.IngSer(txtSer.Text, decimal.Parse(txtTar.Text));
                DGser.DataSource = obj.ListarSer();
                mostrar_datos();
            }
            else
            {             
                string resultado = obj.ModSer(int.Parse(lblId.Text), txtSer.Text, decimal.Parse(txtTar.Text), cboEst.Text.Substring(0,1));
                DGser.DataSource = obj.ListarSer();
                mostrar_datos();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string xnom = textBox1.Text;
                CapaNegocio.CNservicio obj = new CapaNegocio.CNservicio();
                DGser.DataSource = obj.BuscarSer(xnom);
                mostrar_datos();
        
            }catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Eliminar

            string xi = DGser.CurrentRow.Cells[0].Value.ToString();
            CapaNegocio.CNservicio obj = new CapaNegocio.CNservicio();
            string resultado = obj.EliSer(int.Parse(xi));
            DGser.DataSource = obj.ListarSer();
            mostrar_datos();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteServicio frm = new FrmReporteServicio();
            frm.ShowDialog();
        }
    }
}
