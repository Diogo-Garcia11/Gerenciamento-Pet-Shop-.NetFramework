using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetodosPets
{
    public partial class frmRaca : Form
    {
        clsConexao Conexao = new clsConexao();
        StringBuilder cmdsql = new StringBuilder();
        SqlDataReader SDR;
        DataSet DS;
        DataTable DT;

        public frmRaca()
        {
            InitializeComponent();
        }

        private void frmRaca_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string CodEspecie = txtCodEsp.Text;
            string Raca = txtCodRaca.Text;
            string Desc = txtDescricao.Text;

            if (string.IsNullOrEmpty(txtDescricao.Text) || string.IsNullOrEmpty(txtCodEsp.Text))
            {
                MessageBox.Show("Está faltando informações para enviar");
            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("INSERT INTO Raca ");
                cmdsql.Append("(descRaca, idEspecie)");
                cmdsql.Append("values ");
                cmdsql.Append("('" + Desc + "', " + CodEspecie + ")");

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int Raca = Convert.ToInt32(txtCodRaca.Text.ToString());

            if (string.IsNullOrEmpty(txtCodRaca.Text))
            {
                MessageBox.Show("Preencha o campo chave");
            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("DELETE FROM Raca WHERE idRaca =" + Raca);


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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();

            menu.Show();
            this.Close();
        }
    }
}
