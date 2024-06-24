namespace ProjetodosPets
{
    partial class frmMarcacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Servico = new System.Windows.Forms.Label();
            this.chkBanho = new System.Windows.Forms.CheckBox();
            this.chkTosa = new System.Windows.Forms.CheckBox();
            this.chkConsulta = new System.Windows.Forms.CheckBox();
            this.txtCodPet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCRMV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbnAberto = new System.Windows.Forms.RadioButton();
            this.rbnFechado = new System.Windows.Forms.RadioButton();
            this.dgvMarcacao = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblVet = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblTutor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTutor = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcacao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(135, 25);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 1;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(288, 25);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora";
            // 
            // Servico
            // 
            this.Servico.AutoSize = true;
            this.Servico.Location = new System.Drawing.Point(94, 76);
            this.Servico.Name = "Servico";
            this.Servico.Size = new System.Drawing.Size(48, 13);
            this.Servico.TabIndex = 4;
            this.Servico.Text = "Serviços";
            // 
            // chkBanho
            // 
            this.chkBanho.AutoSize = true;
            this.chkBanho.Location = new System.Drawing.Point(97, 119);
            this.chkBanho.Name = "chkBanho";
            this.chkBanho.Size = new System.Drawing.Size(101, 17);
            this.chkBanho.TabIndex = 5;
            this.chkBanho.Text = "Banho R$85,00";
            this.chkBanho.UseVisualStyleBackColor = true;
            // 
            // chkTosa
            // 
            this.chkTosa.AutoSize = true;
            this.chkTosa.Location = new System.Drawing.Point(97, 142);
            this.chkTosa.Name = "chkTosa";
            this.chkTosa.Size = new System.Drawing.Size(94, 17);
            this.chkTosa.TabIndex = 6;
            this.chkTosa.Text = "Tosa R$90,00";
            this.chkTosa.UseVisualStyleBackColor = true;
            // 
            // chkConsulta
            // 
            this.chkConsulta.AutoSize = true;
            this.chkConsulta.Location = new System.Drawing.Point(97, 165);
            this.chkConsulta.Name = "chkConsulta";
            this.chkConsulta.Size = new System.Drawing.Size(117, 17);
            this.chkConsulta.TabIndex = 7;
            this.chkConsulta.Text = "Consulta R$150,00";
            this.chkConsulta.UseVisualStyleBackColor = true;
            this.chkConsulta.CheckedChanged += new System.EventHandler(this.chkConsulta_CheckedChanged);
            // 
            // txtCodPet
            // 
            this.txtCodPet.Location = new System.Drawing.Point(67, 74);
            this.txtCodPet.Name = "txtCodPet";
            this.txtCodPet.Size = new System.Drawing.Size(100, 20);
            this.txtCodPet.TabIndex = 11;
            this.txtCodPet.TextChanged += new System.EventHandler(this.txtCodPet_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CodPet";
            // 
            // txtCRMV
            // 
            this.txtCRMV.Location = new System.Drawing.Point(67, 36);
            this.txtCRMV.Name = "txtCRMV";
            this.txtCRMV.Size = new System.Drawing.Size(100, 20);
            this.txtCRMV.TabIndex = 9;
            this.txtCRMV.TextChanged += new System.EventHandler(this.txtCRMV_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CRMV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tutor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Situação";
            // 
            // rbnAberto
            // 
            this.rbnAberto.AutoSize = true;
            this.rbnAberto.Location = new System.Drawing.Point(158, 352);
            this.rbnAberto.Name = "rbnAberto";
            this.rbnAberto.Size = new System.Drawing.Size(56, 17);
            this.rbnAberto.TabIndex = 14;
            this.rbnAberto.TabStop = true;
            this.rbnAberto.Text = "Aberto";
            this.rbnAberto.UseVisualStyleBackColor = true;
            this.rbnAberto.CheckedChanged += new System.EventHandler(this.rbnAberto_CheckedChanged);
            // 
            // rbnFechado
            // 
            this.rbnFechado.AutoSize = true;
            this.rbnFechado.Location = new System.Drawing.Point(237, 352);
            this.rbnFechado.Name = "rbnFechado";
            this.rbnFechado.Size = new System.Drawing.Size(67, 17);
            this.rbnFechado.TabIndex = 15;
            this.rbnFechado.TabStop = true;
            this.rbnFechado.Text = "Fechado";
            this.rbnFechado.UseVisualStyleBackColor = true;
            // 
            // dgvMarcacao
            // 
            this.dgvMarcacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcacao.Location = new System.Drawing.Point(82, 388);
            this.dgvMarcacao.Name = "dgvMarcacao";
            this.dgvMarcacao.Size = new System.Drawing.Size(240, 150);
            this.dgvMarcacao.TabIndex = 16;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(102, 573);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 17;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(237, 573);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblVet
            // 
            this.lblVet.AutoSize = true;
            this.lblVet.Location = new System.Drawing.Point(191, 42);
            this.lblVet.Name = "lblVet";
            this.lblVet.Size = new System.Drawing.Size(16, 13);
            this.lblVet.TabIndex = 19;
            this.lblVet.Text = "...";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Location = new System.Drawing.Point(191, 81);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(16, 13);
            this.lblPet.TabIndex = 20;
            this.lblPet.Text = "...";
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(191, 112);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(16, 13);
            this.lblTutor.TabIndex = 21;
            this.lblTutor.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTutor);
            this.groupBox1.Controls.Add(this.txtCRMV);
            this.groupBox1.Controls.Add(this.lblTutor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblPet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblVet);
            this.groupBox1.Controls.Add(this.txtCodPet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(61, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 158);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
<<<<<<< Updated upstream
            // 
            // txtTutor
            // 
            this.txtTutor.Location = new System.Drawing.Point(64, 109);
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(100, 20);
            this.txtTutor.TabIndex = 22;
            this.txtTutor.TextChanged += new System.EventHandler(this.txtTutor_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
=======
            // 
            // txtTutor
            // 
            this.txtTutor.Location = new System.Drawing.Point(64, 109);
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(100, 20);
            this.txtTutor.TabIndex = 22;
            this.txtTutor.TextChanged += new System.EventHandler(this.txtTutor_TextChanged);
            // 
<<<<<<< HEAD
            // txtTutor
            // 
            this.txtTutor.Location = new System.Drawing.Point(64, 109);
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(100, 20);
            this.txtTutor.TabIndex = 22;
            this.txtTutor.TextChanged += new System.EventHandler(this.txtTutor_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
=======
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(2, 3);
>>>>>>> 65417e1806acf40e4c5b409de3d97465a1f35d73
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
=======
>>>>>>> 65417e1806acf40e4c5b409de3d97465a1f35d73
            // 
>>>>>>> Stashed changes
            // frmMarcacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 620);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvMarcacao);
            this.Controls.Add(this.rbnFechado);
            this.Controls.Add(this.rbnAberto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkConsulta);
            this.Controls.Add(this.chkTosa);
            this.Controls.Add(this.chkBanho);
            this.Controls.Add(this.Servico);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label1);
            this.Name = "frmMarcacao";
            this.Text = "frmMarcacao";
            this.Load += new System.EventHandler(this.frmMarcacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcacao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Servico;
        private System.Windows.Forms.CheckBox chkBanho;
        private System.Windows.Forms.CheckBox chkTosa;
        private System.Windows.Forms.CheckBox chkConsulta;
        private System.Windows.Forms.TextBox txtCodPet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCRMV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbnAberto;
        private System.Windows.Forms.RadioButton rbnFechado;
        private System.Windows.Forms.DataGridView dgvMarcacao;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblVet;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTutor;
        private System.Windows.Forms.Button btnVoltar;
    }
}