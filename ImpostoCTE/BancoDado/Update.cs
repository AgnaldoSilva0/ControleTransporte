using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE.BancoDado
{
    class Update
    {
        #region Editar Funcionario
        public void editarFunc(int id, string nome, string telefone, double salarioSemanal, string funcao)
        {
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;
                string query = "UPDATE table_funcionarios SET nome = '" + nome + "', telefone = '" + telefone + "', salarioSemanal = '" + salarioSemanal + "', funcao = '"+ funcao +"'  WHERE id LIKE '" + id + "' ";
                
                comando.CommandText = query;

                comando.ExecuteNonQuery();

                MessageBox.Show("Registro Editado");
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar item no banco de dados" + ex);
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion

        public void atualizarEstoqueProduto(int idProduto, int newEstoque)
        {
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                string query = "UPDATE table_produto SET estoque = '" + newEstoque + "'  WHERE id LIKE '" + idProduto + "' ";

                comando.CommandText = query;

                comando.ExecuteNonQuery();

                MessageBox.Show("Registro Editado");
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar item no banco de dados" + ex);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
