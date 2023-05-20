using HamimiProofei.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamimiProofei.dao
{
    class adminDao
    {
        Admin admin = new Admin();

        private DataSet bdDataSet;

        public Admin valNomeAdmin(Admin admin)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlSelectNome = "SELECT nomeAdmin FROM tblAdmin WHERE nomeAdmin = @nomeAdmin";
                MySqlCommand selectNome = new MySqlCommand(sqlSelectNome, conn);

                MySqlDataReader reader;

                try
                {
                    selectNome.Parameters.AddWithValue("@nomeAdmin", admin.getNomeAdmin());
                    reader = selectNome.ExecuteReader();

                    if (reader.Read())
                    {
                        admin.setValNomeAdmin(reader.GetString("nomeAdmin"));
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro: " + e.ToString());
                }

                finally
                {
                    ConexaoBD.fecharConexao();
                }
            }

            return admin;

        }

        public Admin valEmailAdmin(Admin admin)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlSelectEmail = "SELECT emailAdmin FROM tblAdmin WHERE emailAdmin = @emailAdmin";
                MySqlCommand selectEmail = new MySqlCommand(sqlSelectEmail, conn);

                MySqlDataReader reader;

                try
                {
                    selectEmail.Parameters.AddWithValue("@emailAdmin", admin.getEmailAdmin());
                    reader = selectEmail.ExecuteReader();

                    if (reader.Read())
                    {
                        admin.setValEmailAdmin(reader.GetString("emailAdmin"));
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro: " + e.ToString());
                }

                finally
                {
                    ConexaoBD.fecharConexao();
                }
            }

            return admin;

        }

        public Admin valSenhaAdmin(Admin admin)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlSelectSenha = "SELECT senhaAdmin FROM tblAdmin WHERE nomeAdmin = @nomeAdmin AND senhaAdmin = @senhaAdmin";
                MySqlCommand selectSenha = new MySqlCommand(sqlSelectSenha, conn);

                MySqlDataReader reader;

                try
                {
                    selectSenha.Parameters.AddWithValue("@nomeAdmin", admin.getNomeAdmin());
                    selectSenha.Parameters.AddWithValue("@senhaAdmin", admin.getSenhaAdmin());
                    reader = selectSenha.ExecuteReader();

                    if (reader.Read())
                    {
                        admin.setValSenhaAdmin(reader.GetString("senhaAdmin"));
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro: " + e.ToString());
                }

                finally
                {
                    ConexaoBD.fecharConexao();
                }
            }

            return admin;

        }

        public void inserir(Admin admin)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlInsert = "INSERT INTO tblAdmin(nomeAdmin, emailAdmin, senhaAdmin) values(@nomeAdmin, @emailAdmin, @senhaAdmin)";
                MySqlCommand inserir = new MySqlCommand(sqlInsert, conn); // Passando a String e a Conexão
                MySqlDataReader DataReader;

                try
                {
                    inserir.Parameters.Add(new MySqlParameter("@nomeAdmin", admin.getNomeAdmin()));
                    inserir.Parameters.Add(new MySqlParameter("@emailAdmin", admin.getEmailAdmin()));
                    inserir.Parameters.Add(new MySqlParameter("@senhaAdmin", admin.getSenhaAdmin()));

                    DataReader = inserir.ExecuteReader();

                    MessageBox.Show("Admin Cadastrado Com Sucesso!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro:" + e.ToString());
                }

                finally
                {
                    ConexaoBD.fecharConexao();
                }
            }

        }

        public Admin selectId(Admin admin)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlSelectId = "SELECT idAdmin FROM tblAdmin WHERE nomeAdmin = @nomeAdmin";
                MySqlCommand selectId = new MySqlCommand(sqlSelectId, conn);

                MySqlDataReader reader;

                try
                {
                    selectId.Parameters.AddWithValue("@nomeAdmin", admin.getNomeAdmin());
                    reader = selectId.ExecuteReader();

                    if (reader.Read())
                    {
                        admin.setIdAdmin(int.Parse(reader.GetString("idAdmin")));
                    }
                    else
                    {
                        MessageBox.Show("ERRO");
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro: " + e.ToString());
                }

                finally
                {
                    ConexaoBD.fecharConexao();
                }
            }

            return admin;

        }

        public void excluir(Admin admin)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlDelete = "DELETE FROM tblAdmin WHERE idAdmin = @idAdmin";
                MySqlCommand delete = new MySqlCommand(sqlDelete, conn); // Passando a String e a Conexão
                MySqlDataReader reader;

                try
                {
                    delete.Parameters.AddWithValue("@idAdmin", admin.getIdAdmin());
                    reader = delete.ExecuteReader(); ;

                    MessageBox.Show("Admin Excluído Com Sucesso!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro:" + e.ToString());
                }

                finally
                {
                    ConexaoBD.fecharConexao();
                }
            }
        }
    }
}
