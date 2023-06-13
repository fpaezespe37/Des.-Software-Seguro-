namespace SysCentro.Utilitarios
{
    partial class FrmUtilRestore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomBd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBackup = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomCopia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.uCusuario1 = new SysCentro.Controles.UCusuario();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(339, 109);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(616, 420);
            this.webBrowser2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "ADMINISTRACIÓN DE RESTORE";
            // 
            // txtNomBd
            // 
            this.txtNomBd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomBd.Location = new System.Drawing.Point(40, 137);
            this.txtNomBd.Name = "txtNomBd";
            this.txtNomBd.Size = new System.Drawing.Size(199, 29);
            this.txtNomBd.TabIndex = 11;
            this.txtNomBd.Text = "NomBb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Etiqueta de Base de datos";
            // 
            // BtnBackup
            // 
            this.BtnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackup.ForeColor = System.Drawing.Color.Blue;
            this.BtnBackup.Location = new System.Drawing.Point(37, 260);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(202, 67);
            this.BtnBackup.TabIndex = 9;
            this.BtnBackup.Text = "Restaurar Base de datos";
            this.BtnBackup.UseVisualStyleBackColor = true;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(283, 170);
            this.dataGridView1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Base de datos del Servidor";
            // 
            // txtNomCopia
            // 
            this.txtNomCopia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCopia.Location = new System.Drawing.Point(42, 207);
            this.txtNomCopia.Name = "txtNomCopia";
            this.txtNomCopia.Size = new System.Drawing.Size(199, 29);
            this.txtNomCopia.TabIndex = 15;
            this.txtNomCopia.Text = "NomCopia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre de copia a Restaurar";
            // 
            // lblRes
            // 
            this.lblRes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRes.Location = new System.Drawing.Point(0, 555);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(986, 22);
            this.lblRes.TabIndex = 16;
            this.lblRes.Text = "label5";
            // 
            // uCusuario1
            // 
            this.uCusuario1.Location = new System.Drawing.Point(781, 32);
            this.uCusuario1.Name = "uCusuario1";
            this.uCusuario1.Size = new System.Drawing.Size(174, 43);
            this.uCusuario1.TabIndex = 17;
            // 
            // FrmUtilRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 577);
            this.Controls.Add(this.uCusuario1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtNomCopia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNomBd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBackup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.webBrowser2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUtilRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restauración de base de datos";
            this.Load += new System.EventHandler(this.FrmUtilRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomBd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBackup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomCopia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRes;
        private Controles.UCusuario uCusuario1;
    }
}