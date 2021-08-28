using ImpostoCTE.BancoDado;
using ImpostoCTE.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE.Model
{
    public partial class Form_Pedido : MetroFramework.Forms.MetroForm
    {
        public Form_Pedido()
        {
            InitializeComponent();
            Pesquisar.pesquisarTodosItens();
        }

        private void btPesquisarProduto_Click(object sender, EventArgs e)
        {
            listViewProdutos.Items.Clear();
            Pesquisar.pesquisarTodosItens();
            foreach (var item in Listas.listProduto)
            {
                if (item.Codigo.IndexOf(tbPesquisarProduto.Text, StringComparison.OrdinalIgnoreCase) >= 0 || item.Descricao.IndexOf(tbPesquisarProduto.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listViewProdutos.Items.Add(new ListViewItem(new string[] { item.Codigo, item.Descricao, Convert.ToString(item.Preco), Convert.ToString(item.Estoque) }));
                }
            }
        }

        private void btAlterarCliente_Click(object sender, EventArgs e)
        {
            Form_Selecionar_Orcamento Selecionar_Orcamento = new Form_Selecionar_Orcamento();
            Selecionar_Orcamento.ShowDialog();
            lbCliente.Text = Pedido.nomeClienteRef;
            lbData.Text = Pedido.dataRef;
            lbIdOrcamento.Text = Convert.ToString(Pedido.idOrcamentoRef);
            lbPlaca.Text = Pedido.placaRef;
            lbVeiculo.Text = Pedido.veiculoRef;
            atualizarListaPedido();
        }

        private void btFecharTelaPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Controle de Estoque
        private void btAdicionarProduto_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            int newEstoque = Convert.ToInt32(lbEstoqueAtual.Text) + 1;
            int id = Pesquisar.retornarIdProduto(lbCodigoDetalhe.Text, lbDescricaoDetalhe.Text, 1);
            update.atualizarEstoqueProduto(id, newEstoque);
            contador = 0;
            timerEstoqueAlterado.Start();
            lbEstoqueAtual.Text = Convert.ToString(Convert.ToInt32(lbEstoqueAtual.Text) + 1);
            btPesquisarProduto.PerformClick();
        }

        private void btDiminuirProduto_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            int newEstoque = Convert.ToInt32(lbEstoqueAtual.Text) - 1;
            int id = Pesquisar.retornarIdProduto(lbCodigoDetalhe.Text, lbDescricaoDetalhe.Text, 1);
            update.atualizarEstoqueProduto(id, newEstoque);
            contador = 0;
            timerEstoqueAlterado.Start();
            lbEstoqueAtual.Text = Convert.ToString(Convert.ToInt32(lbEstoqueAtual.Text) - 1);
            btPesquisarProduto.PerformClick();
        }
        #endregion

        #region timer para alterar label de estoque alterado
        private int contador;
        private void timerEstoqueAlterado_Tick(object sender, EventArgs e)
        {
            if (lbEstoqueAlterado.Text == "...")
            {
                lbEstoqueAlterado.Text = "Estoque alterado";
            }
            else
            {
                contador = contador + 1;
                lbEstoqueAlterado.Text = "...";
                if (contador == 2)
                {
                    timerEstoqueAlterado.Stop();
                }
            }
        }
        #endregion

        private void listViewProdutos_MouseClick(object sender, MouseEventArgs e)
        {
            lbCodigoDetalhe.Text = listViewProdutos.SelectedItems[0].SubItems[0].Text;
            lbDescricaoDetalhe.Text = listViewProdutos.SelectedItems[0].SubItems[1].Text;
            lbEstoqueAtual.Text = listViewProdutos.SelectedItems[0].SubItems[3].Text;
        }

        private void listViewProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string codigo = listViewProdutos.SelectedItems[0].SubItems[0].Text;
            string descricao = listViewProdutos.SelectedItems[0].SubItems[1].Text;
            double precoUnitario = Convert.ToDouble(listViewProdutos.SelectedItems[0].SubItems[2].Text);
            int idCliente = Pesquisar.retornarIdCliente(lbCliente.Text);
            int idPedido = Convert.ToInt32(lbIdOrcamento.Text);
            string placa = lbPlaca.Text;
            string modelo = lbVeiculo.Text;

            Form_AddItemOrcamento form_AddItem = new Form_AddItemOrcamento(codigo, descricao, precoUnitario, idCliente, idPedido, placa, modelo);
            //Ao usar ShowDialog o código pausa no mesmo local
            form_AddItem.ShowDialog();
            this.Refresh();
        }

        private void atualizarListaPedido()
        {
            listViewPedido.Items.Clear();
            Pesquisar.preencherListaItensPedido(Convert.ToInt32(lbIdOrcamento.Text));
            foreach (var item in Listas.listItensPedido)
            {
                listViewPedido.Items.Add(new ListViewItem(new string[] { 
                    item.Codigo, 
                    item.Descricao, 
                    Convert.ToString(item.PrecoUni), 
                    Convert.ToString(item.Quantidade),
                    Convert.ToString(item.PrecoTotal) }));
            }
        }

    }
}
