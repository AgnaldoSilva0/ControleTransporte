using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ConexaoBD.pesquisarTodosItens();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewProdutos_MouseClick(object sender, MouseEventArgs e)
        {
            lbAplicacao.Text = listViewProdutos.SelectedItems[0].SubItems[1].Text;

            foreach (var item in Listas.listProduto)
            {
                if (item.Codigo == listViewProdutos.SelectedItems[0].SubItems[0].Text)
                {
                    double valorVenda = item.Preco;
                    lbValorVenda.Text = Convert.ToString(valorVenda + (valorVenda * (120.0 / 100)));
                }
            }

            
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            listViewProdutos.Items.Clear();
            ConexaoBD.pesquisarTodosItens();
            foreach (var item in Listas.listProduto)
            {
               if (item.Codigo.IndexOf(tbPesquisar.Text, StringComparison.OrdinalIgnoreCase) >= 0 || item.Descricao.IndexOf(tbPesquisar.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listViewProdutos.Items.Add(new ListViewItem(new string[] { item.Codigo, item.Descricao, "R$ " + Convert.ToString(item.Preco), Convert.ToString(item.Ipi) }));
                }
            }
            
        }
    }
}
