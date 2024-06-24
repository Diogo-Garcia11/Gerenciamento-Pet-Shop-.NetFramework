using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            CarregarRacas();
        }
        string idEspecie;
        private void cboRaca_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Raca = cboRaca.Text;

            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT idRaca FROM Raca WHERE descRaca ='" + Raca + "'");
            Conexao.StrSql = cmdsql.ToString();
            SDR = Conexao.RetornarDataReader();
            if (SDR.Read())
            {

                string id = SDR["idRaca"].ToString();

                idRaca = id;
            }

        }
        string idRaca;
        private void cboSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPet_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarEspecies();
            
        }
        private void CarregarEspecies()
        {
            cboEspecie.Items.Clear();
            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT descEspecie FROM Especie");
            Conexao.StrSql = cmdsql.ToString();
            SDR = Conexao.RetornarDataReader();

            while (SDR.Read())
            {
                cboEspecie.Items.Add(SDR["descEspecie"].ToString());
            }
        }
        private void CarregarRacas() 
        {
            cboRaca.Items.Clear();
            string Especie = cboEspecie.Text;

            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT idEspecie FROM Especie WHERE descEspecie ='" + Especie + "'");

            Conexao.StrSql = cmdsql.ToString();

            SDR = Conexao.RetornarDataReader();
            if (SDR.Read())
            {
                string id = SDR["idEspecie"].ToString();
                idEspecie = id;
                SDR = Conexao.RetornarDataReader();
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("SELECT descRaca FROM Raca WHERE idEspecie =" + id);
                Conexao.StrSql = cmdsql.ToString();
                if (SDR.Read())
                {
                    SDR = Conexao.RetornarDataReader();
                    cboRaca.Items.Clear();
                    while (SDR.Read())
                    {
                        cboRaca.Items.Add(SDR["descRaca"].ToString());
                    }
                }
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
            string data = txtData.Text;

            string situacao = "Ativo";
            string sexo = "nada";
            if (rdMacho.Checked || rdFemea.Checked)
            {
                if (rdMacho.Checked)
                {
                    sexo = "Macho";
                }
                else if (rdFemea.Checked)
                {
                    sexo = "Femea";
                }
            }
            else
            {
                MessageBox.Show("Está faltando informações para enviar");
            }


            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(cboEspecie.Text) || string.IsNullOrEmpty(cboRaca.Text))
            {
                MessageBox.Show("Está faltando informações para enviar1");

            }

            else
            {

                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("INSERT INTO Pet ");
                cmdsql.Append("(nomePet, sexoPet, nascPet,situacaoPet, cpfTutor, idRaca, idEspecie)");
                cmdsql.Append("values ");
                cmdsql.Append("('" + nome + "', '" + sexo + "', '" + data + "', '" + situacao + "', '" + CPF + "', " + idRaca + ", " + idEspecie + ")");
                Conexao.StrSql = cmdsql.ToString();


                if (Conexao.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Inclusao executada com sucesso");
                    CarregarGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao executar a Inclusao");
                }
            }
            CarregarEspecies();
            CarregarRacas();
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
            CarregarEspecies();
            CarregarRacas();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string cod = txtCodPet.Text;
            string CPF = txtCPF.Text;
            string nome = txtNome.Text;
            string data = txtData.Text;
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
            else
            {
                MessageBox.Show("Selecione o sexo do pet.");
                return;
            }

            if (string.IsNullOrEmpty(txtCodPet.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(cboEspecie.Text) || string.IsNullOrEmpty(cboRaca.Text))
            {
                MessageBox.Show("Está faltando informações para enviar.");
                return;
            }

            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("UPDATE Pet SET " +
                "nomePet = '" + nome + "', " +
                "sexoPet = '" + sexo + "', " +
                "nascPet = '" + data + "', " +
                "situacaoPet = '" + situacao + "', " +
                "cpfTutor = '" + CPF + "', " +
                "idRaca = " + idRaca + ", " +
                "idEspecie = " + idEspecie + " " +
                "WHERE idPet = " + cod);

            Conexao.StrSql = cmdsql.ToString();


            if (Conexao.ExecutarCmd() > 0)
            {
                MessageBox.Show("Alteração executada com sucesso");
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Erro ao executar a alteração");
            }
            CarregarEspecies();
            CarregarRacas();
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
            cmdsql.Append("SELECT Pet.nomePet, Pet.sexoPet, Pet.nascPet, Pet.situacaoPet, Pet.cpfTutor, ");
            cmdsql.Append("Raca.descRaca, Especie.descEspecie ");
            cmdsql.Append("FROM Pet ");
            cmdsql.Append("INNER JOIN Raca ON Pet.idRaca = Raca.idRaca ");
            cmdsql.Append("INNER JOIN Especie ON Pet.idEspecie = Especie.idEspecie ");
            cmdsql.Append("WHERE Pet.idPet ="+ idPet);
            Conexao.StrSql = cmdsql.ToString();

            SDR = Conexao.RetornarDataReader();
            if (SDR.Read())
            {

                txtCodPet.Text = idPet;

                txtNome.Text = SDR["nomePet"].ToString();
                string sexo = SDR["sexoPet"].ToString();
                if (sexo == "Macho")
                {
                    rdMacho.Checked = true;
                }
                if (sexo == "Femea")
                {
                    rdFemea.Checked = true;
                }
                txtCPF.Text = SDR["cpfTutor"].ToString();

                txtData.Text = SDR["nascPet"].ToString();

                cboEspecie.Items.Clear();
                cboEspecie.Items.Add(SDR["descEspecie"].ToString());

                cboRaca.Items.Clear();
                cboRaca.Items.Add(SDR["descRaca"].ToString());

                cboSituacao.Items.Clear();
                cboSituacao.Items.Add(SDR["situacaoPet"].ToString());


            }
            


            //  MessageBox.Show("Leitura executada com sucesso");




            //MessageBox.Show("Não Localizado");


        }

       
    }
}
