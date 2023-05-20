using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamimiProofei.dao
{
    class ConexaoBD
    {
        private static String connString = "Server = localhost; Database = BancoAnimes; UId = root; Pwd = 12345"; //String de conexão
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao() // static: não pode ser mudado
        {
            conn = new MySqlConnection(connString);

            try
            {
                conn.Open(); // Abertura da conexão
                //MessageBox.Show("Conexão Estabelecida com Sucesso.");
            }
            catch (MySqlException sqle)
            {
                conn = null;
                MessageBox.Show("Erro: " + sqle);
            }

            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close(); // Fecha a conexão
            }
        }
    }
}
