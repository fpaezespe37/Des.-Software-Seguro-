namespace SysCentro.Utilitarios
{
    partial class FrmUtilBackup
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
            this.Contenido = new System.Windows.Forms.WebBrowser();
            this.BtnBackup = new System.Windows.Forms.Button();
            this.cboBase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDiff = new System.Windows.Forms.RadioButton();
            this.rbCom = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.uCusuario1 = new SysCentro.Controles.UCusuario();
            this.uCsalir1 = new SysCentro.Controles.UCsalir();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenido
            // 
            this.Contenido.Location = new System.Drawing.Point(257, 109);
            this.Contenido.MinimumSize = new System.Drawing.Size(20, 20);
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(620, 338);
            this.Contenido.TabIndex = 0;
            this.Contenido.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // BtnBackup
            // 
            this.BtnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackup.Image = global::SysCentro.Properties.Resources.diskette;
            this.BtnBackup.Location = new System.Drawing.Point(32, 315);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(202, 67);
            this.BtnBackup.TabIndex = 1;
            this.BtnBackup.Text = "Copia de Seguridad";
            this.BtnBackup.UseVisualStyleBackColor = true;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // cboBase
            // 
            this.cboBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBase.FormattingEnabled = true;
            this.cboBase.Location = new System.Drawing.Point(32, 135);
            this.cboBase.Name = "cboBase";
            this.cboBase.Size = new System.Drawing.Size(202, 28);
            this.cboBase.TabIndex = 2;
            this.cboBase.Text = "CboBase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione Base de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Etiqueta de Base de datos";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(35, 196);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 29);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDiff);
            this.groupBox1.Controls.Add(this.rbCom);
            this.groupBox1.Location = new System.Drawing.Point(35, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Copia";
            // 
            // rbDiff
            // 
            this.rbDiff.AutoSize = true;
            this.rbDiff.Location = new System.Drawing.Point(17, 43);
            this.rbDiff.Name = "rbDiff";
            this.rbDiff.Size = new System.Drawing.Size(75, 17);
            this.rbDiff.TabIndex = 1;
            this.rbDiff.Text = "Diferencial";
            this.rbDiff.UseVisualStyleBackColor = true;
            // 
            // rbCom
            // 
            this.rbCom.AutoSize = true;
            this.rbCom.Checked = true;
            this.rbCom.Location = new System.Drawing.Point(17, 19);
            this.rbCom.Name = "rbCom";
            this.rbCom.Size = new System.Drawing.Size(69, 17);
            this.rbCom.TabIndex = 0;
            this.rbCom.TabStop = true;
            this.rbCom.Text = "Completo";
            this.rbCom.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "ADMINISTRACIÓN DE BACKUP";
            // 
            // uCusuario1
            // 
            this.uCusuario1.Location = new System.Drawing.Point(703, 41);
            this.uCusuario1.Name = "uCusuario1";
            this.uCusuario1.Size = new System.Drawing.Size(174, 43);
            this.uCusuario1.TabIndex = 9;
            // 
            // uCsalir1
            // 
            this.uCsalir1.Location = new System.Drawing.Point(791, 481);
            this.uCsalir1.Name = "uCsalir1";
            this.uCsalir1.Size = new System.Drawing.Size(86, 44);
            this.uCsalir1.TabIndex = 10;
            // 
            // FrmUtilBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 537);
            this.Controls.Add(this.uCsalir1);
            this.Controls.Add(this.uCusuario1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBase);
            this.Controls.Add(this.BtnBackup);
            this.Controls.Add(this.Contenido);
            this.Name = "FrmUtilBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copia de Seguridad - Base de datos";
            this.Load += new System.EventHandler(this.FrmUtilBackup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser Contenido;
        private System.Windows.Forms.Button BtnBackup;
        private System.Windows.Forms.ComboBox cboBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDiff;
        private System.Windows.Forms.RadioButton rbCom;
        private System.Windows.Forms.Label label3;
        private Controles.UCusuario uCusuario1;
        private Controles.UCsalir uCsalir1;
    }
}