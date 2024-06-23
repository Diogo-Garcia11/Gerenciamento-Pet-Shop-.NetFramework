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
    public partial class frmTutor : Form
    {
        clsConexao Conexao = new clsConexao();
        StringBuilder cmdsql = new StringBuilder();
        SqlDataReader SDR;
        DataSet DS;
        DataTable DT;
        public frmTutor()
        {
            InitializeComponent();
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            string CPF = txtCPF.Text;
            string Celular = txtCelular.Text;
            string Email = txtEmail.Text;

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(txtCelular.Text))
            {
                MessageBox.Show("Está faltando informações para enviar");
            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("INSERT INTO Tutor ");
                cmdsql.Append("(nomeTutor, cpfTutor, celularTutor,emailTutor)");
                cmdsql.Append("values ");
                cmdsql.Append("('" + Nome + "', '" + CPF + "', '" + Celular + "', '"+Email+ "')");

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
            string CPF = txtCPF.Text;

            if (string.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show("Está faltando o campo chave");
            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("DELETE FROM Tutor WHERE cpfTutor=" + CPF +";");

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCPF.Text) && string.IsNullOrEmpty(txtCelular.Text))
            {
                Conexao.StrSql = "SELECT * FROM Tutor";
                DS = Conexao.RetornarDataSet();
                DT = DS.Tables[0];
                dgvTutor.DataSource = DT;
            }
            else if (!string.IsNullOrEmpty(txtCPF.Text) && string.IsNullOrEmpty(txtCelular.Text))
            {
                Conexao.StrSql = "SELECT * FROM Pet WHERE cpfTutor = " + txtCPF.Text + ";";
                DS = Conexao.RetornarDataSet();
                DT = DS.Tables[0];
                dgvTutor.DataSource = DT;
            }
            else if (string.IsNullOrEmpty(txtCPF.Text) && !string.IsNullOrEmpty(txtCelular.Text))
            {
                Conexao.StrSql = "SELECT cpfTutor FROM Tutor WHERE celularTutor = " + txtCelular.Text + ";";
                SDR = Conexao.RetornarDataReader();
                Conexao.StrSql = "SELECT * FROM Pet WHERE cpfTutor= " + SDR["cpfTutor"].ToString() + ";";
                DS = Conexao.RetornarDataSet();
                DT = DS.Tables[0];
                dgvTutor.DataSource = DT;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string CPF = txtCPF.Text;
            string Nome = txtNome.Text;
            string Celular = txtCelular.Text;
            string Email = txtEmail.Text;

            if (string.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show("Está faltando o campo chave");
            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("UPDATE Tutor SET nomeTutor ="+Nome+", emailTutor ="+Email+", celularTutor="+Celular+",  WHERE cpfTutor=" + CPF + ";");

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
            this.Hide();
        }
    }
}
