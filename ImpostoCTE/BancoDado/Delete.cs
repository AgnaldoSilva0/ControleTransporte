using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE.BancoDado
{
    class Delete
    {
        public static void deletarFrete(int cte)
        {
            string baseDados = "C:\\BDs\\dds\\banco_dados.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM table_frete WHERE cte = " + cte + ";";

                comando.ExecuteNonQuery();

                MessageBox.Show("Registro Excluido");
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir item no banco de dados" + ex);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
