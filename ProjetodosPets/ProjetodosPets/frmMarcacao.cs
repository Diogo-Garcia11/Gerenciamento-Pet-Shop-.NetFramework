using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetodosPets
{
    public partial class frmMarcacao : Form
    {
        clsConexao Conexao = new clsConexao();
        StringBuilder cmdsql = new StringBuilder();
        SqlDataReader SDR;
        DataSet DS;
        DataTable DT;

        public frmMarcacao()
        {
            InitializeComponent();
        }

        private void frmMarcacao_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            BloquearCampos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            DateTime Dia = Convert.ToDateTime(txtDia.Text);
            DateTime Hora = Convert.ToDateTime(txtHora.Text);
            string Banho = chkBanho.Checked ? "Sim" : "Nao";
            string Tosa = chkTosa.Checked ? "Sim" : "Nao";
            string Consulta = chkConsulta.Checked ? "Sim" : "Nao";
            string CRMV = txtCRMV.Text;
            string Situacao = "Abt";
            string Tutor = txtTutor.Text;
            int CodPet = Convert.ToInt32(txtCodPet.Text);


            if (string.IsNullOrEmpty(txtDia.Text) || string.IsNullOrEmpty(txtHora.Text) || string.IsNullOrEmpty(Tutor))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }


            cmdsql.Clear();
            cmdsql.Append("INSERT INTO Marcacao (diaMarcacao, horaMarcacao, banhoMarcacao, tosaMarcacao, consultaMarcacao, idPet, situacaoMarcacao, cpfTutor");

            if (chkConsulta.Checked)
            {
                cmdsql.Append(", CRMVVet");
            }

            cmdsql.Append(") VALUES (");
            cmdsql.Append("'" + Dia.ToString("yyyy-MM-dd") + "', ");
            cmdsql.Append("'" + Hora.ToString("HH:mm:ss") + "', ");
            cmdsql.Append("'" + Banho + "', ");
            cmdsql.Append("'" + Tosa + "', ");
            cmdsql.Append("'" + Consulta + "', ");
            cmdsql.Append(CodPet + ", ");
            cmdsql.Append("'" + Situacao + "', ");
            cmdsql.Append("'" + Tutor + "'");

            if (chkConsulta.Checked)
            {
                cmdsql.Append(", '" + CRMV + "'");
            }

            cmdsql.Append(")");

            Conexao.StrSql = cmdsql.ToString();

            if (Conexao.ExecutarCmd() > 0)
            {
                MessageBox.Show("Gravação executada com sucesso");
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Erro ao executar a gravação");
            }

            if (!string.IsNullOrEmpty(txtCodPet.Text))
            {

                cmdsql.Clear();
                cmdsql.Append("SELECT Pet.idPet, Pet.nomePet, Pet.cpfTutor, Tutor.nomeTutor, Marcacao.CRMVVet ");
                cmdsql.Append("FROM Marcacao ");
                cmdsql.Append("INNER JOIN Pet ON Marcacao.idPet = Pet.idPet ");
                cmdsql.Append("INNER JOIN Tutor ON Pet.cpfTutor = Tutor.cpfTutor ");
                cmdsql.Append("INNER JOIN Veterinario ON Marcacao.CRMVVet = Veterinario.CRMVVet ");
                cmdsql.Append("WHERE Pet.idPet = " + CodPet);
                Conexao.StrSql = cmdsql.ToString();
                SDR = Conexao.RetornarDataReader();

                if (SDR.Read())
                {
                    lblPet.Text = SDR["nomePet"].ToString();
                    lblTutor.Text = SDR["nomeTutor"].ToString();
                    MessageBox.Show("Leitura executada com sucesso");
                }
                else
                {
                    MessageBox.Show("Não Localizado");
                }
            }

        }


        private void chkConsulta_CheckedChanged(object sender, EventArgs e)
        {
            BloquearCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string CodPet = txtCodPet.Text;

            if (string.IsNullOrEmpty(txtCodPet.Text))
            {
                MessageBox.Show("Está faltando o campo chave");
            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("DELETE FROM Marcacao WHERE idPet=" + CodPet + ";");

                Conexao.StrSql = cmdsql.ToString();


                if (Conexao.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Exclusão executada com sucesso");
                    CarregarGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao executar a exclusão");
                }
            }
        }

        private void CarregarGrid()
        {
            Conexao.StrSql = "SELECT * FROM Marcacao";
            DS = Conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dgvMarcacao.DataSource = DT;
        }

        private void rbnAberto_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtCRMV_TextChanged(object sender, EventArgs e)
        {
            string CRMV = txtCRMV.Text.ToString();


            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT nomeVet FROM Veterinario WHERE CRMVVet LIKE '%" + CRMV + "%'"); ;
            Conexao.StrSql = cmdsql.ToString();
            SDR = Conexao.RetornarDataReader();

            if (SDR.Read())
            {
                lblVet.Text = SDR["nomeVet"].ToString();
            }
            else
            {
                lblVet.Text = "...";
            }
        }

        private void txtCodPet_TextChanged(object sender, EventArgs e)
        {
            string CodPet = txtCodPet.Text.ToString();


            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT nomePet FROM Pet WHERE idPet LIKE '%" + CodPet + "%'"); ;
            Conexao.StrSql = cmdsql.ToString();
            SDR = Conexao.RetornarDataReader();

            if (SDR.Read())
            {
                lblPet.Text = SDR["nomePet"].ToString();
            }
            else
            {
                lblPet.Text = "...";
            }
        }

        private void txtTutor_TextChanged(object sender, EventArgs e)
        {
            string cpfTutor = txtTutor.Text.ToString();


            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT nomeTutor FROM Tutor WHERE cpfTutor LIKE '%" + cpfTutor + "%'"); ;
            Conexao.StrSql = cmdsql.ToString();
            SDR = Conexao.RetornarDataReader();

            if (SDR.Read())
            {
                lblTutor.Text = SDR["nomeTutor"].ToString();
            }
            else
            {
                lblTutor.Text = "...";
            }
        }

        private void BloquearCampos()
        {
            if (chkConsulta.Checked)
            {
                txtCRMV.Enabled = true;
            }
            else
            {
                txtCRMV.Enabled = false;
                txtCRMV.Text = string.Empty;
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
