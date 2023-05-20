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
    class animeDao
    {

        Anime anime = new Anime(); //Instanciar o Anime

        private DataSet bdDataSet;

        public void inserir(Anime anime)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlInsert = "INSERT INTO tblAnime(nomeAnime, estudio, numEps, dataLanc, sinopse, fotoAnime) values(@nomeAnime, @estudio, @numEps, @dataLanc, @sinopse, @fotoAnime)";
                MySqlCommand inserir = new MySqlCommand(sqlInsert, conn); // Passando a String e a Conexão
                MySqlDataReader DataReader;

                try
                {
                    inserir.Parameters.Add(new MySqlParameter("@nomeAnime", anime.getNomeAnime()));
                    inserir.Parameters.Add(new MySqlParameter("@estudio", anime.getEstudio()));
                    inserir.Parameters.Add(new MySqlParameter("@numEps", anime.getNumEps()));
                    inserir.Parameters.Add(new MySqlParameter("@dataLanc", anime.getDataLanc()));
                    inserir.Parameters.Add(new MySqlParameter("@sinopse", anime.getSinopse()));
                    inserir.Parameters.Add(new MySqlParameter("@fotoAnime", anime.getFotoAnime()));

                    DataReader = inserir.ExecuteReader();

                    MessageBox.Show("Anime Cadastrado Com Sucesso!");
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

        public Anime selecionar(Anime anime)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlSelect = "SELECT * FROM tblAnime WHERE nomeAnime like '%" + anime.getNomeAnime() + "%'LIMIT 1;";
                MySqlCommand select = new MySqlCommand(sqlSelect, conn);

                MySqlDataReader reader;

                try
                {
                    select.Parameters.AddWithValue("@nomeAnime", anime.getNomeAnime());
                    reader = select.ExecuteReader();

                    if (reader.Read())
                    {
                        anime.setNomeAnime(reader.GetString("nomeAnime"));
                        anime.setEstudio(reader.GetString("estudio"));
                        anime.setNumEps(int.Parse(reader.GetString("numEps")));
                        anime.setDataLanc(reader.GetString("dataLanc").Remove(10)); // removendo os caracteres que estiverem depois da 10º posição
                        anime.setSinopse(reader.GetString("sinopse"));
                        anime.setFotoAnime((byte[])(reader["fotoAnime"]));
                        anime.setDataPicker(DateTime.Parse(reader.GetString("dataLanc")));
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado!");
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

            return anime;

        }

        public Anime selectId(Anime anime)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlSelectId = "SELECT idAnime FROM tblAnime WHERE nomeAnime = @nomeAnime";
                MySqlCommand selectId = new MySqlCommand(sqlSelectId, conn);

                MySqlDataReader reader;

                try
                {
                    selectId.Parameters.AddWithValue("@nomeAnime", anime.getNomeAnime());
                    reader = selectId.ExecuteReader();

                    if (reader.Read())
                    {
                        anime.setIdAnime(int.Parse(reader.GetString("idAnime")));
                    }
                    else
                    {
                        MessageBox.Show("ERRO SUS");
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

            return anime;

        }

        public Anime selectFotoAnime(Anime anime)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlSelectFotoAnime = "SELECT fotoAnime FROM tblAnime WHERE nomeAnime = @nomeAnime";
                MySqlCommand selectFotoAnime = new MySqlCommand(sqlSelectFotoAnime, conn);

                MySqlDataReader reader;

                try
                {
                    selectFotoAnime.Parameters.AddWithValue("@nomeAnime", anime.getNomeAnime());
                    reader = selectFotoAnime.ExecuteReader();

                    if (reader.Read())
                    {
                        anime.setFotoAnime((byte[])(reader["fotoAnime"]));
                    }
                    else
                    {
                        MessageBox.Show("ERRO SUS");
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

            return anime;

        }

        public void salvar(Anime anime)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlUpdate = "UPDATE tblAnime SET nomeAnime = @nomeAnime, estudio = @estudio, numEps = @numEps, dataLanc = @dataLanc, sinopse = @sinopse, fotoAnime = @fotoAnime WHERE idAnime = @idAnime";
                MySqlCommand update = new MySqlCommand(sqlUpdate, conn); // Passando a String e a Conexão
                MySqlDataReader DataReader;

                try
                {
                    update.Parameters.AddWithValue("@idAnime", anime.getIdAnime());
                    update.Parameters.AddWithValue("@nomeAnime", anime.getNomeAnime());
                    update.Parameters.AddWithValue("@estudio", anime.getEstudio());
                    update.Parameters.AddWithValue("@numEps", anime.getNumEps());
                    update.Parameters.AddWithValue("@dataLanc", anime.getDataLanc());
                    update.Parameters.AddWithValue("@sinopse", anime.getSinopse());
                    update.Parameters.AddWithValue("@fotoAnime", anime.getFotoAnime());

                    DataReader = update.ExecuteReader();

                    MessageBox.Show("Anime Atualizado Com Sucesso!");
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

        public void excluir(Anime anime)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlDelete = "DELETE FROM tblAnime WHERE idAnime = @idAnime";
                MySqlCommand delete = new MySqlCommand(sqlDelete, conn); // Passando a String e a Conexão
                MySqlDataReader reader;

                try
                {
                    delete.Parameters.AddWithValue("@idAnime", anime.getIdAnime());
                    reader = delete.ExecuteReader(); ;

                    MessageBox.Show("Anime Excluído Com Sucesso!");
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

        public Anime valAnime(Anime anime)
        {
            MySqlConnection conn = ConexaoBD.obterConexao(); // Abrir a conexão
            if (conn.State == ConnectionState.Open) // Verifica se a conexão está aberta
            {
                String sqlSelectNome = "SELECT nomeAnime FROM tblAnime WHERE nomeAnime = @nomeAnime";
                MySqlCommand selectNome = new MySqlCommand(sqlSelectNome, conn);

                MySqlDataReader reader;

                try
                {
                    selectNome.Parameters.AddWithValue("@nomeAnime", anime.getNomeAnime());
                    reader = selectNome.ExecuteReader();

                    if (reader.Read())
                    {
                        anime.setValAnime(reader.GetString("nomeAnime"));
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

            return anime;

        }
    }
}
