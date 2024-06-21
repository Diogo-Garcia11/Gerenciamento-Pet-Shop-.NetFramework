using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetodosPets
{
    public partial class frmExames : Form
    {
        clsConexao Conexao = new clsConexao();
        StringBuilder cmdsql = new StringBuilder();
        // SqlDataReader SDR;
        //DataSet DS;
        //DataTable DT;
        public frmExames()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string exame = txtIdExame.Text;

            if (string.IsNullOrEmpty(txtIdExame.Text))
            {
                MessageBox.Show("Está faltando o campo chave");
            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("DELETE FROM Exame WHERE idExame=" + exame + ";");

                Conexao.StrSql = cmdsql.ToString();


                if (Conexao.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Exclusão executada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao executar a exclusão");
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string desc = txtDescricao.Text;

            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Está faltando informações para enviar");
            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("INSERT INTO Exame ");
                cmdsql.Append("(descExame)");
                cmdsql.Append("values ");
                cmdsql.Append("('" + desc + "')");

                Conexao.StrSql = cmdsql.ToString();


                if (Conexao.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Gravação executada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao executar a gravação");
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
