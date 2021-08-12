using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE.BancoDado
{
    class Insert
    {
        #region InserirFrete
        public static void inserirFrete(string data, int cte, int mdfe, string veiculo, string placa, string cidade,
            string tomador, double valorFrete, string observacao)
        {
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO table_frete(data, cte, mdfe, veiculo, placa, cidade, tomador, valorFrete, observacao) " +
                    "VALUES ('" + data + "', '" + cte + "', '" + mdfe + "', '" + veiculo + "', '" + placa + "', '" + cidade + "'," +
                    "'" + tomador + "', '" + valorFrete + "', '" + observacao + "' )";

                comando.ExecuteNonQuery();

                MessageBox.Show("Registro Inserido");
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir item no banco de dados" + ex);
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion

        #region InserirProduto
        public static void insertBancoProduto(string codigo, string descricao, double preco, int ipi)
        {
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO banco_produto(codigo, descricao, preco, ipi) VALUES ('" + codigo + "', '" + descricao + "', '" + preco + "', '" + ipi + "' )";

                comando.ExecuteNonQuery();

                MessageBox.Show("Registro Inserido");
                comando.Dispose();
                Produto.validator = 1;
            }
            catch (Exception ex)
            {
                Produto.validator = 2;
                MessageBox.Show("Erro ao inserir item" + ex);
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion

        #region InserirFuncionario
        public static void insertBancoFuncionario(int id, string nome, double salario, string admissao, string telefone, string funcao)
        {
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO table_funcionarios(id, nome, admissao, telefone, salarioSemanal, funcao) " +
                    "VALUES ('" + id + "', '" + nome + "', '" + admissao + "', '" + telefone + "', '"+ salario +"', '"+ funcao +"' )";

                comando.ExecuteNonQuery();

                MessageBox.Show("Registro Inserido");
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir item" + ex);
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion

    }
}
