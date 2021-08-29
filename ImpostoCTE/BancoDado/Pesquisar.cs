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
                string query = "SELECT * FROM table_produto";
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
                        Convert.ToDouble(row["preco"]), Convert.ToInt16(row["ipi"]), Convert.ToInt32(row["estoque"])));
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

        #region Preencher Lista de frete
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
        #endregion

        #region Preencher Lista Cliente
        public void preencherTabelaCliente()
        {
            Listas.listCliente.Clear();
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_cliente";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);


                foreach (System.Data.DataRow row in dados.Rows)
                {
                    Listas.listCliente.Add(new Cliente(Convert.ToInt32(row["id"]),
                        Convert.ToString(row["nome"]),
                        Convert.ToString(row["telefone"])
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
        #endregion

        #region Preencher Lista Itens do pedido
        public static void preencherListaItensPedido(int idPedido)
        {
            Listas.listItensPedido.Clear();
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_pedido " +
                    "INNER JOIN table_produto ON table_pedido.idProduto = table_produto.id " +
                    "INNER JOIN table_cliente ON table_pedido.idCliente = table_cliente.id " +
                    "WHERE idPedido LIKE '" + idPedido + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    double precoTotalItem = Convert.ToDouble(row["preco"]) * Convert.ToDouble(row["quantidade"]);
                    Listas.listItensPedido.Add(new ItensPedido(Convert.ToString(row["codigo"]),
                        Convert.ToString(row["descricao"]),
                        Convert.ToInt32(row["preco"]),
                        precoTotalItem,
                        Convert.ToInt32(row["quantidade"])));
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

        #region Preencher Lista de Orçamentos
        public static void preencherListaOrcamento()
        {
            Listas.listPedido.Clear();
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_pedido " +
                    "INNER JOIN table_produto ON table_pedido.idProduto = table_produto.id " +
                    "INNER JOIN table_cliente ON table_pedido.idCliente = table_cliente.id";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    Listas.listPedido.Add(new Pedido(Convert.ToInt32(row["idCliente"]), 
                        Convert.ToInt32(row["idProduto"]),
                        Convert.ToInt32(row["quantidade"]), 
                        Convert.ToString(row["data"]),
                        Convert.ToInt32(row["idPedido"]),
                        Convert.ToString(row["placa"]),
                        Convert.ToString(row["modelo"])));
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

        #region Pesquisar Funcionario
        public static void pesquisarFuncionario()
        {
            Listas.listFuncionario.Clear();
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_funcionarios";

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
        #endregion

        #region Detalhes dos fretes retorna objeto
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
        #endregion

        #region Validar Senha Para abrir tela funcionario
        public Boolean verificarSenhaFunc(string usuario, string senha)
        {
            Boolean result = false;
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {

                 string query = "SELECT * FROM table_usuario WHERE usuario LIKE '" + usuario + "' AND senha LIKE '"+ senha +"'";
                

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                if (dados.Rows.Count > 0)
                {
                    result = true;
                } else
                {
                    result = false;
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
            return result;
        }
        #endregion

        #region retorna ID do produto para atualizar o estoque do mesmo
        public static int retornarIdProduto(string codigo, string descricao, int operacao)
        {
            int id = 0;
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_produto " +
                    "WHERE codigo LIKE '"+ codigo + "' AND descricao = '" + descricao + "'";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                //Adaptado com IF para reusar o código, para retornar o id do produto ou o id do estoque
                foreach (System.Data.DataRow row in dados.Rows)
                {
                    if (Convert.ToString(row["codigo"]) == codigo)
                    {
                        if (operacao == 1)
                        {
                            id = Convert.ToInt32(row["id"]);
                        } 
                        else
                        {
                            id = Convert.ToInt32(row["id"]);
                        }
                    }
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

            return id;
        }
        #endregion

        #region Retorna ID do cliente
        public static int retornarIdCliente(string nome)
        {
            int id = 0;
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_cliente WHERE nome LIKE '" + nome + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    if (Convert.ToString(row["nome"]) == nome)
                    {
                       id = Convert.ToInt32(row["id"]);
                    }
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
            return id;
        }

        #endregion

    }
}
