using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE
{
    class ConexaoBD
    {

        public static void conexao()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            if (!File.Exists(baseDados))
            {
                SQLiteConnection.CreateFile(baseDados);
            }

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            conexao.ConnectionString = strConection;

            try
            {
                conexao.Open();
                MessageBox.Show("Conectado SQLite");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Conectar SQLite \n"  + ex);
            }
            finally
            {
                conexao.Close();
            }
        }


        public static void insertBancoProduto()
        {
            string baseDados = Application.StartupPath + @"\db\produtos.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                //Aqui deve ser criado as variaveis que vai guardar os dados que vai ser inserido no banco de dados
                string codigo = "6546";
                string descricao = "KIT EMBREAGEM SACHS Pellegrino";
                double preco = 2588.26;
                int ipi = 22;

                comando.CommandText = "INSERT INTO produto VALUES (" + codigo + ", '" + descricao + "', '" + preco + "', '" + ipi +"' )";

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
    }

    }
