using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjDSS_seg_20_5
{
    internal class clsConexao
    {
        private string _StrSql;

        public string StrSql
        {
            get { return _StrSql; }
            set { _StrSql = value; }
        }

        private string strConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\alunoinfo\\Documents\\GitHub\\ProjDSS_27-5\\ProjDSS_seg_20-5\\bdDSS.mdf;Integrated Security=True";


        private SqlConnection AbrirBanco()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = strConexao;
            Conn.Open();
            return Conn;
        }

        private void FecharBanco(SqlConnection Conn)
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        public DataSet RetornarDataSet()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand Cmd = conn.CreateCommand();
            SqlDataAdapter DA = new SqlDataAdapter();
            DataSet DS = new DataSet();

            try
            {
                conn = AbrirBanco();
                Cmd.CommandText = _StrSql;
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = conn;

                DA.SelectCommand = Cmd;
                DA.Fill(DS);

                return (DS);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conn.Close();
            }

        }

        public SqlDataReader RetornarDataReader()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();

            try
            {
                conn = AbrirBanco();
                Cmd.CommandText = _StrSql;
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = conn;

                return Cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecutarCmd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();

            try
            {
                conn = AbrirBanco();
                Cmd.CommandText = _StrSql;
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = conn;

                return Cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception("Erro " + ex.Message.ToString());
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
