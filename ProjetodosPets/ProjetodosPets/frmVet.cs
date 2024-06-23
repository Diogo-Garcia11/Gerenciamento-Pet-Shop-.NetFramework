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
    public partial class frmVet : Form
    {
        clsConexao Conexao = new clsConexao();
        StringBuilder cmdsql = new StringBuilder();
        
        DataSet DS;
        DataTable DT;

        public frmVet()
        {
            InitializeComponent();
        }

        private void frmVet_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            String CRMV = txtCRMV.Text;
            String Nome = txtNome.Text;
            String Celular = txtCelular.Text;
            String Endereco = txtEndereco.Text;

            if (string.IsNullOrEmpty(txtCelular.Text) || string.IsNullOrEmpty(txtEndereco.Text) || string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Está faltando informações para enviar");

            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("INSERT INTO Veterinario ");
                cmdsql.Append("(CRMVVet, nomeVet, celularVet, enderecoVet)");
                cmdsql.Append("values ");
                cmdsql.Append("('" + CRMV + "', '" + Nome + "', '" + Celular + "', '" + Endereco +"' )");

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
                CarregarGrid();
            }
        }
        private void CarregarGrid()
        {
            Conexao.StrSql = "SELECT * FROM Veterinario";
            DS = Conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dgvVeterinario.DataSource = DT;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string CRMV = txtCRMV.Text;
            if (string.IsNullOrEmpty(txtCRMV.Text))
            {
                MessageBox.Show("Preencha o campo chave");
            }
            else
            {
                cmdsql.Remove(0, cmdsql.Length);
                cmdsql.Append("DELETE FROM Veterinario WHERE CRMVVet = '" + CRMV + "'");


                Conexao.StrSql = cmdsql.ToString();

                if (Conexao.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Exclusão executada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao executar a exclusão");
                }
                CarregarGrid();
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
