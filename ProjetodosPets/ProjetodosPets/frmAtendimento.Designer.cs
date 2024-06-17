namespace ProjetodosPets
{
    partial class frmAtendimento
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Exames = new System.Windows.Forms.Label();
            this.cboExames = new System.Windows.Forms.ComboBox();
            this.dgvAtendimento = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblTutor = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CodPet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tutor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Dia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Descrição";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 74);
            this.textBox1.TabIndex = 9;
            // 
            // Exames
            // 
            this.Exames.AutoSize = true;
            this.Exames.Location = new System.Drawing.Point(31, 282);
            this.Exames.Name = "Exames";
            this.Exames.Size = new System.Drawing.Size(44, 13);
            this.Exames.TabIndex = 10;
            this.Exames.Text = "Exames";
            // 
            // cboExames
            // 
            this.cboExames.FormattingEnabled = true;
            this.cboExames.Location = new System.Drawing.Point(86, 279);
            this.cboExames.Name = "cboExames";
            this.cboExames.Size = new System.Drawing.Size(121, 21);
            this.cboExames.TabIndex = 11;
            // 
            // dgvAtendimento
            // 
            this.dgvAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendimento.Location = new System.Drawing.Point(34, 324);
            this.dgvAtendimento.Name = "dgvAtendimento";
            this.dgvAtendimento.Size = new System.Drawing.Size(240, 150);
            this.dgvAtendimento.TabIndex = 12;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(34, 508);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 13;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Location = new System.Drawing.Point(83, 40);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(16, 13);
            this.lblPet.TabIndex = 14;
            this.lblPet.Text = "...";
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(83, 83);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(16, 13);
            this.lblTutor.TabIndex = 15;
            this.lblTutor.Text = "...";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(67, 121);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(16, 13);
            this.lblDia.TabIndex = 16;
            this.lblDia.Text = "...";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(144, 121);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(16, 13);
            this.lblHora.TabIndex = 17;
            this.lblHora.Text = "...";
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 543);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblTutor);
            this.Controls.Add(this.lblPet);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dgvAtendimento);
            this.Controls.Add(this.cboExames);
            this.Controls.Add(this.Exames);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmAtendimento";
            this.Text = "frmAtendimento";
            this.Load += new System.EventHandler(this.frmAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Exames;
        private System.Windows.Forms.ComboBox cboExames;
        private System.Windows.Forms.DataGridView dgvAtendimento;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblHora;
    }
}