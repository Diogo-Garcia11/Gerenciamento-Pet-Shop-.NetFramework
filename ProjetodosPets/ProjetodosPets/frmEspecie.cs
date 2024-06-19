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
    public partial class frmEspecie : Form
    {
        clsConexao Conexao = new clsConexao();
        StringBuilder cmdsql = new StringBuilder();
        SqlDataReader SDR;
        DataSet DS;
        DataTable DT;

        public frmEspecie()
        {
            InitializeComponent();
        }

        private void frmEspecie_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            String Descricao = txtDescricao.Text;

            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Está faltando informações para enviar");
            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("INSERT INTO Especie ");
                cmdsql.Append("(descEspecie)");
                cmdsql.Append("values ");
                cmdsql.Append("(" + Descricao + ")");

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
            int CodEspecie = Convert.ToInt32(txtCodEsp.Text.ToString());
            if (string.IsNullOrEmpty(txtCodEsp.Text))
            {
                MessageBox.Show("Preencha o campo chave");
            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("DELETE FROM Veterinario WHERE idEspecie =" + CodEspecie);


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
