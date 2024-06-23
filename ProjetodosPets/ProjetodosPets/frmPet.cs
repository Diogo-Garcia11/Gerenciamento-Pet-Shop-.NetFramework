using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetodosPets
{
    public partial class frmPet : Form
    {
        clsConexao Conexao = new clsConexao();
        StringBuilder cmdsql = new StringBuilder();
        SqlDataReader SDR;
        DataSet DS;
        DataTable DT;
        public frmPet()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void cboEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Especie = cboEspecie.Text;

            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT idEspecie FROM Especie WHERE descEspecie =" +Especie +";");
            Conexao.StrSql = cmdsql.ToString();
            SDR = Conexao.RetornarDataReader();
            string id = SDR["idEspecie"].ToString();
            idEspecie = id;

            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT descRaca FROM Raca WHERE idEspecie =" + id + ";");
            Conexao.StrSql = cmdsql.ToString();

            while (SDR.Read())
            {
                cboRaca.Items.Add(SDR["descRaca"].ToString());
            }
        }
        string idEspecie;
        private void cboRaca_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Raca = cboRaca.Text;

            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT idRaca FROM Raca WHERE descRaca =" + Raca + ";");
            Conexao.StrSql = cmdsql.ToString();
            SDR = Conexao.RetornarDataReader();
            string id = SDR["idRaca"].ToString();
            idRaca = id;
        }
        string idRaca;
        private void cboSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPet_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.CustomFormat = "MM/dd/yyyy";

            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT descEspecie FROM Especie");
            Conexao.StrSql = cmdsql.ToString();
            SDR = Conexao.RetornarDataReader();

            while (SDR.Read())
            {
                cboEspecie.Items.Add(SDR["descEspecie"].ToString());
            }
        }
        private void CarregarGrid()
        {
            Conexao.StrSql = "SELECT * FROM Pet";
            DS = Conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dgvPet.DataSource = DT;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string CPF = txtCPF.Text;
            string nome = txtNome.Text;
            string data = dtpData.Text;
            
            string situacao = "Ativo";
            string sexo = "nada";
            if (rdMacho.Checked)
            {
                sexo = "Macho";
            }
            else if (rdFemea.Checked)
            {
                sexo = "Femea";
            }

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(cboEspecie.Text) || string.IsNullOrEmpty(cboRaca.Text) )
            {
                MessageBox.Show("Está faltando informações para enviar");
            }
            if(rdMacho.Checked || rdFemea.Checked)
            {
                MessageBox.Show("Está faltando informações para enviar");
            }
            else
            {

                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("INSERT INTO Pet ");
                cmdsql.Append("(nomePet, sexoPet, nascPet,situacaoPet, cpfTutor, idRaca, idEspecie)");
                cmdsql.Append("values ");
                cmdsql.Append("('" + nome + "', '" + sexo + "', '" + data + "', '" + situacao + "', '" + CPF + "', " + idRaca + "," +idEspecie);
                Conexao.StrSql = cmdsql.ToString();


                if (Conexao.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Inclusao executada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao executar a Inclusao");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string cod = txtCodPet.Text;

            if (string.IsNullOrEmpty(txtCodPet.Text))
            {
                MessageBox.Show("Está faltando o campo chave");
            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("DELETE FROM Pet WHERE idPet=" + cod + ";");

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string cod = txtCodPet.Text;
            string CPF = txtCPF.Text;
            string nome = txtNome.Text;
            string data = dtpData.Text;
           
            string situacao = cboSituacao.Text;
            string sexo = "nada";
            if (rdMacho.Checked)
            {
                sexo = "Macho";
            }
            else if (rdFemea.Checked)
            {
                sexo = "Femea";
            }
            if (!string.IsNullOrEmpty(txtCodPet.Text))
            {
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(cboEspecie.Text) || string.IsNullOrEmpty(cboRaca.Text))
                {
                    MessageBox.Show("Está faltando informações para enviar");
                }
                if (rdMacho.Checked || rdFemea.Checked)
                {
                    MessageBox.Show("Está faltando informações para enviar");
                }
                else
                {

                    cmdsql.Remove(0, cmdsql.Length);
                    cmdsql.Append("UPDATE Pet ");
                    cmdsql.Append("SET nomePet="+nome+ ", sexoPet="+sexo+ ", nascPet="+data+ ",situacaoPet="+situacao+ ", cpfTutor="+CPF+ ", idRaca="+idRaca+ ", idEspecie="+idEspecie+")");
                    cmdsql.Append("WHERE ");
                    cmdsql.Append("idPet =" +cod+ ";");
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
            else
            {
                MessageBox.Show("Está faltando informações para enviar");
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            string CPF = txtCPF.Text.ToString();

 
            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT nomeTutor FROM Tutor WHERE cpfTutor LIKE '%" + CPF + "%'"); ;
            Conexao.StrSql = cmdsql.ToString();
            SDR = Conexao.RetornarDataReader();
            
            if(SDR.Read())
            {
               lblNome.Text=SDR["nomeTutor"].ToString();
            }
            else
            {
                lblNome.Text = "...";
            }
        }

        private void dgvPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idPet = dgvPet.CurrentRow.Cells[0].Value.ToString();


            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT Pet.idPet, Pet.nomePet, Pet.sexoPet, Pet.cpfTutor, Pet.nascPet, Especie.descEspecie, Raca.descRaca, Pet.situacaoPet FROM Pet INNER JOIN Especie ON Pet.idEspecie = Especie.idEspecie INNER JOIN Raca ON Pet.idRaca = Raca.idRaca WHERE idPet = " + idPet);
            Conexao.StrSql = cmdsql.ToString();
            
            SDR = Conexao.RetornarDataReader();
            if (SDR.Read())
            {

                txtCodPet.Text = SDR["idPet"].ToString();
                txtNome.Text = SDR["nomePet"].ToString();
                string sexo = SDR["sexoPet"].ToString();
                if (sexo == "Macho")
                {
                    rdMacho.Checked = true;
                }
                if (sexo == "Femea")
                {
                    rdFemea.Checked= true;
                }
                txtCPF.Text = SDR["cpfTutor"].ToString();

                string data = SDR["nascPet"].ToString();
                dtpData.Text = data;

                cboEspecie.Text = SDR["descEspecie"].ToString();

                cboRaca.Text = SDR["descRaca"].ToString();


                cboSituacao.Text = SDR["situacaoPet"].ToString();
                MessageBox.Show("Leitura executada com sucesso");

            }
            else
            {
                MessageBox.Show("Não Localizado");
                
            }
        }
    }
}
