namespace ProjetodosPets
{
    partial class frmPet
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
            this.txtCodPet = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dgvPet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.rdMacho = new System.Windows.Forms.RadioButton();
            this.rdFemea = new System.Windows.Forms.RadioButton();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.cboRaca = new System.Windows.Forms.ComboBox();
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodPet
            // 
            this.txtCodPet.Location = new System.Drawing.Point(32, 65);
            this.txtCodPet.Name = "txtCodPet";
            this.txtCodPet.Size = new System.Drawing.Size(100, 20);
            this.txtCodPet.TabIndex = 25;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Situação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Especie";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(243, 550);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(139, 550);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(32, 550);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 16;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // dgvPet
            // 
            this.dgvPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPet.Location = new System.Drawing.Point(32, 381);
            this.dgvPet.Name = "dgvPet";
            this.dgvPet.Size = new System.Drawing.Size(506, 150);
            this.dgvPet.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código do pet";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(32, 221);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 13;
            // 
            // rdMacho
            // 
            this.rdMacho.AutoSize = true;
            this.rdMacho.Location = new System.Drawing.Point(32, 141);
            this.rdMacho.Name = "rdMacho";
            this.rdMacho.Size = new System.Drawing.Size(58, 17);
            this.rdMacho.TabIndex = 26;
            this.rdMacho.TabStop = true;
            this.rdMacho.Text = "Macho";
            this.rdMacho.UseVisualStyleBackColor = true;
            // 
            // rdFemea
            // 
            this.rdFemea.AutoSize = true;
            this.rdFemea.Location = new System.Drawing.Point(123, 141);
            this.rdFemea.Name = "rdFemea";
            this.rdFemea.Size = new System.Drawing.Size(57, 17);
            this.rdFemea.TabIndex = 27;
            this.rdFemea.TabStop = true;
            this.rdFemea.Text = "Fêmea";
            this.rdFemea.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(32, 164);
            this.dtpData.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 28;
            // 
            // cboEspecie
            // 
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Location = new System.Drawing.Point(32, 260);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(121, 21);
            this.cboEspecie.TabIndex = 29;
            // 
            // cboRaca
            // 
            this.cboRaca.FormattingEnabled = true;
            this.cboRaca.Location = new System.Drawing.Point(32, 310);
            this.cboRaca.Name = "cboRaca";
            this.cboRaca.Size = new System.Drawing.Size(121, 21);
            this.cboRaca.TabIndex = 30;
            // 
            // cboSituacao
            // 
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboSituacao.Location = new System.Drawing.Point(32, 356);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(121, 21);
            this.cboSituacao.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Raça";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nome";
            // 
            // frmPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 629);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboSituacao);
            this.Controls.Add(this.cboRaca);
            this.Controls.Add(this.cboEspecie);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.rdFemea);
            this.Controls.Add(this.rdMacho);
            this.Controls.Add(this.txtCodPet);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvPet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpf);
            this.Name = "frmPet";
            this.Text = "Pet";
            this.Load += new System.EventHandler(this.frmPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodPet;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView dgvPet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.RadioButton rdMacho;
        private System.Windows.Forms.RadioButton rdFemea;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.ComboBox cboRaca;
        private System.Windows.Forms.ComboBox cboSituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}