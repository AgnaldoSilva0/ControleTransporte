using ImpostoCTE.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE.BancoDado
{
    class Pesquisar
    {
        #region PreencherListaDeProduto
        public static void pesquisarTodosItens()
        {
            Listas.listProduto.Clear();
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db"; C:\BDs\dds
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM banco_produto";
                //if (codigo != "")
                //{
                //   query = "SELECT * FROM produto WHERE nome LIKE '" + codigo + "'";
                //}

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);


                foreach (System.Data.DataRow row in dados.Rows)
                {
                    Listas.listProduto.Add(new Produto(Convert.ToString(row["codigo"]), Convert.ToString(row["descricao"]),
                        Convert.ToDouble(row["preco"]), Convert.ToInt16(row["ipi"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();

            }

        }
        #endregion

        public static void preencherTabelaFrete()
        {
            Listas.listFrete.Clear();
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db"; C:\BDs\dds
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_frete";
                //if (codigo != "")
                //{
                //   query = "SELECT * FROM produto WHERE nome LIKE '" + codigo + "'";
                //}

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);


                foreach (System.Data.DataRow row in dados.Rows)
                {
//string data, string veiculo, string placa, string cidade, string tomador, string observacao, int cte, int mdfe, double valorFrete
                    Listas.listFrete.Add(new Frete(Convert.ToString(row["data"]), 
                        Convert.ToString(row["veiculo"]),
                        Convert.ToString(row["placa"]), 
                        Convert.ToString(row["cidade"]),
                        Convert.ToString(row["tomador"]),
                        Convert.ToString(row["observacao"]),
                        Convert.ToInt32(row["cte"]),
                        Convert.ToInt32(row["mdfe"]),
                        Convert.ToDouble(row["valorFrete"])
                        ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();

            }

        }

        public static void pesquisarFuncionario()
        {
            Listas.listFuncionario.Clear();
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_funcionarios";
                //if (codigo != "")
                //{
                //   query = "SELECT * FROM produto WHERE nome LIKE '" + codigo + "'";
                //}

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);


                foreach (System.Data.DataRow row in dados.Rows)
                {
                    //int id, string nome, string admissao, string telefone, double salarioSemanal
                    Listas.listFuncionario.Add(new Funcionario(Convert.ToInt16(row["ID"]),
                        Convert.ToString(row["nome"]),
                        Convert.ToString(row["admissao"]),
                        Convert.ToString(row["telefone"]),
                        Convert.ToDouble(row["salarioSemanal"]),
                        Convert.ToString(row["funcao"])
                        ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();

            }

        }

        public static Object detalhesFrete(int cte)
        {
            Frete detalhes = new Frete();

            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_frete";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);


                foreach (System.Data.DataRow row in dados.Rows)
                {
                    //string data, string veiculo, string placa, string cidade, string tomador, string observacao, int cte, int mdfe, double valorFrete
                    detalhes.Data = Convert.ToString(row["data"]);
                    detalhes.Veiculo = Convert.ToString(row["veiculo"]);
                    detalhes.Placa = Convert.ToString(row["placa"]);
                    detalhes.Cidade = Convert.ToString(row["cidade"]);
                    detalhes.Tomador = Convert.ToString(row["tomador"]);
                    detalhes.Observacao = Convert.ToString(row["observacao"]);
                    detalhes.Cte = Convert.ToInt32(row["cte"]);
                    detalhes.Mdfe = Convert.ToInt32(row["mdfe"]);
                    detalhes.ValorFrete =  Convert.ToDouble(row["valorFrete"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return detalhes;
        }

    }
}
