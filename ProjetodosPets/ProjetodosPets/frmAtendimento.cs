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
    public partial class frmAtendimento : Form
    {
        clsConexao Conexao = new clsConexao();
        StringBuilder cmdsql = new StringBuilder();
        
        SqlDataReader SDR;
        DataSet DS;
        DataTable DT;
        public frmAtendimento()
        {
            InitializeComponent();
        }

        private void frmAtendimento_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT descExame FROM Exame;");
            Conexao.StrSql = cmdsql.ToString();

            while (SDR.Read())
            {
                cboExames.Items.Add(SDR["descExame"].ToString());
            }
        }
        private void CarregarGrid()
        {
            Conexao.StrSql = "SELECT * FROM Marcacao";
            DS = Conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dgvAtendimento.DataSource = DT;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void dgvAtendimento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idMarcacao = dgvAtendimento.CurrentRow.Cells[0].Value.ToString();


            id = idMarcacao;
            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("SELECT Pet.idPet, nomeTutor.Tutor, Marcacao.diaMarcacao, Marcacao.horaMarcacao FROM Marcacao INNER JOIN Pet ON Marcacao.idPet =Pet.idPet INNER JOIN Tutor ON Marcacao.cpfTutor = Tutor.cpfTutor WHERE idMarcacao = " + idMarcacao + ")");
            Conexao.StrSql = cmdsql.ToString();
            SDR = Conexao.RetornarDataReader();
            if (SDR.Read())
            {

                lblPet.Text = SDR["idPet"].ToString();
                lblTutor.Text = SDR["nomeTutor"].ToString();
                lblDia.Text = SDR["diaMarcacao"].ToString();
                lblHora.Text = SDR["horaMarcacao"].ToString();
               
                MessageBox.Show("Leitura executada com sucesso");

            }
            else
            {
                MessageBox.Show("Não Localizado");

            }
        }
        string id = "nada";
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //tem mais coisa pra fazer aqui
            cmdsql.Remove(0, cmdsql.Length);
            cmdsql.Append("UPDATE Marcacao SET situacaoMarcacao = \"Fechado\" WHERE idMarcacao = " + id);
            Conexao.StrSql = cmdsql.ToString();

            if (Conexao.ExecutarCmd() > 0)
            {
                MessageBox.Show("Finalizado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao finalizar");
            }
        }
    }
}
