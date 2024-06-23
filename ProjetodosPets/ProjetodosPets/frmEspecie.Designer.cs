namespace ProjetodosPets
{
    partial class frmEspecie
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
            this.txtCodEsp = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Descrição";
            // 
            // txtCodEsp
            // 
            this.txtCodEsp.Location = new System.Drawing.Point(173, 94);
            this.txtCodEsp.Name = "txtCodEsp";
            this.txtCodEsp.Size = new System.Drawing.Size(100, 20);
            this.txtCodEsp.TabIndex = 62;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(173, 144);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 61;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(247, 213);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 60;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(140, 213);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 59;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Codigo Especie";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 64;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 360);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodEsp);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.label1);
            this.Name = "frmEspecie";
            this.Text = "Espécie";
            this.Load += new System.EventHandler(this.frmEspecie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodEsp;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
    }
}