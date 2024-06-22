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
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            DateTime Dia = Convert.ToDateTime(txtDia.Text);
            DateTime Hora = Convert.ToDateTime(txtHora.Text);
            string Banho = chkBanho.Text;
            string Tosa = chkTosa.Text;
            string Consulta = chkConsulta.Text;
            string CRMV = txtCRMV.Text;
            string Situacao = "Aberto";
            int CodPet = Convert.ToInt32(txtCodPet.Text.ToString());


            if (chkBanho.Checked)
            {
                Banho = chkBanho.Text;
            }

            if (chkTosa.Checked)
            {
                Tosa = chkTosa.Text;
            }

            if (chkConsulta.Checked)
            {
                Consulta = chkConsulta.Text;
            }

            cmdsql.Clear();
            cmdsql.Append("INSERT INTO Marcacao (diaMarcacao, horaMarcacao, banhoMarcacao, tosaMarcacao, consultaMarcacao, CRMV, idPet) VALUES (");
            cmdsql.Append("'" + Dia.ToString("yyyy-MM-dd") + "', ");
            cmdsql.Append("'" + Hora.ToString("HH:mm:ss") + "', ");
            cmdsql.Append("'" + Banho + "', ");
            cmdsql.Append("'" + Tosa + "', ");
            cmdsql.Append("'" + Consulta + "', ");
            cmdsql.Append("'" + CRMV + "', ");
            cmdsql.Append(CodPet + ")");
            cmdsql.Append("'" + Situacao + "')");

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
                    lblPet.Text = SDR["idPet"].ToString();
                    lblTutor.Text = SDR["nomeTutor"].ToString();
                    lblVet.Text = SDR["CRMVVet"].ToString();
                    MessageBox.Show("Leitura executada com sucesso");
                }
                else
                {
                    MessageBox.Show("Não Localizado");
                }
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();

            menu.Show();
            this.Close();
        }

        private void chkConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConsulta.Checked)
            {
                txtDia.Enabled = true;
                txtHora.Enabled = true;
                txtCRMV.Enabled = true;
                txtCodPet.Enabled = true;
            }
            else
            {

                txtDia.Enabled = false;
                txtHora.Enabled = false;
                txtCRMV.Enabled = false;
                txtCodPet.Enabled = false;

                txtDia.Text = string.Empty;
                txtHora.Text = string.Empty;
                txtCRMV.Text = string.Empty;
                txtCodPet.Text = string.Empty;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvMarcacao.SelectedRows.Count > 0)
            {
                int idMarcacao = Convert.ToInt32(dgvMarcacao.SelectedRows[0].Cells["IdMarcacao"].Value);

                cmdsql.Clear();
                cmdsql.Append("DELETE FROM Marcacao ");
                cmdsql.Append("WHERE IdMarcacao = " + idMarcacao);

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
            string situacao = "Aberto";

            if (!rbnAberto.Checked)
            {
                situacao = "Fechado";
            }

            Conexao.StrSql = "SELECT Marcacao.IdMarcacao, Marcacao.diaMarcacao, Marcacao.horaMarcacao, Marcacao.banhoMarcacao, Marcacao.tosaMarcacao, Marcacao.consultaMarcacao, Marcacao.situacaoMarcacao, Marcacao.CRMV, Pet.nomePet, Tutor.nomeTutor " +
                    "FROM Marcacao " +
                    "INNER JOIN Pet ON Marcacao.idPet = Pet.idPet " +
                    "INNER JOIN Tutor ON Pet.cpfTutor = Tutor.cpfTutor " +
                    "WHERE Marcacao.situacaoMarcacao = '" + situacao + "'";

            DS = Conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dgvMarcacao.DataSource = DT;
        }

        private void rbnAberto_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
