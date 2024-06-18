namespace ProjetodosPets
{
    partial class frmVet
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtCRMV = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dgvVeterinario = new System.Windows.Forms.DataGridView();
            this.CRMV = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinario)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Nome";
            // 
            // txtCRMV
            // 
            this.txtCRMV.Location = new System.Drawing.Point(149, 96);
            this.txtCRMV.Name = "txtCRMV";
            this.txtCRMV.Size = new System.Drawing.Size(100, 20);
            this.txtCRMV.TabIndex = 44;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(149, 146);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 43;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(248, 285);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 38;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(141, 285);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 37;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // dgvVeterinario
            // 
            this.dgvVeterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeterinario.Location = new System.Drawing.Point(141, 325);
            this.dgvVeterinario.Name = "dgvVeterinario";
            this.dgvVeterinario.Size = new System.Drawing.Size(506, 150);
            this.dgvVeterinario.TabIndex = 36;
            // 
            // CRMV
            // 
            this.CRMV.AutoSize = true;
            this.CRMV.Location = new System.Drawing.Point(146, 80);
            this.CRMV.Name = "CRMV";
            this.CRMV.Size = new System.Drawing.Size(38, 13);
            this.CRMV.TabIndex = 35;
            this.CRMV.Text = "CRMV";
            this.CRMV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(149, 247);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 53;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(149, 197);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtEndereco.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Endereço";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(30, 525);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 57;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 560);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCRMV);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvVeterinario);
            this.Controls.Add(this.CRMV);
            this.Name = "frmVet";
            this.Text = "Veterinário";
            this.Load += new System.EventHandler(this.frmVet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCRMV;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView dgvVeterinario;
        private System.Windows.Forms.Label CRMV;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
    }
}