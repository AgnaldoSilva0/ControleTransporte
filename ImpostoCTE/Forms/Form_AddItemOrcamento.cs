using ImpostoCTE.BancoDado;
using ImpostoCTE.Model;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE.Forms
{
    public partial class Form_AddItemOrcamento : MetroSetForm
    {
        public Form_AddItemOrcamento()
        {
            InitializeComponent();
        }

        public Form_AddItemOrcamento(string codigo, string descricao, double valorUnitario, int idCliente, int idPedido)
        {
            InitializeComponent();
            varIdCliente = idCliente;
            varIdPedido = idPedido;
            preencherTextBox(codigo, descricao, valorUnitario);
        }

        private void btFecharTelaAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void preencherTextBox(string codigo, string descricao, double valorUnitario)
        {
            lbCodigoProduto.Text = codigo;
            lbDescricaoProduto.Text = descricao;
            tbPrecoProduto.Text = Convert.ToString(valorUnitario);
        }

        private void btIncrementarQuant_Click(object sender, EventArgs e)
        {
            int quantidadeAtual = Convert.ToInt32(tbQuantidadeProduto.Text);
            tbQuantidadeProduto.Text = Convert.ToString(quantidadeAtual + 1);
        }

        private void btDecrementarItem_Click(object sender, EventArgs e)
        {
            int quantidadeAtual = Convert.ToInt32(tbQuantidadeProduto.Text);
            tbQuantidadeProduto.Text = Convert.ToString(quantidadeAtual - 1);
        }

        #region KeyPressed Metodos
        private void tbPrecoProduto_KeyPressed(object sender, KeyPressEventArgs e)
        {
            Operacoes.impedirLetrasTextBox(sender, e);
        }

        private void tbQuantidadeProduto_KeyPressed(object sender, KeyPressEventArgs e)
        {
            Operacoes.impedirLetrasTextBox(sender, e);
        }
        #endregion

        private int varIdCliente = 0;
        private int varIdPedido = 0;
        private void btAddProduto_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            string data = DateTime.Now.Date.ToString("yyyy-MM-dd");
            

            insert.insertBancoPedido(varIdCliente, 
                Pesquisar.retornarIdProduto(lbCodigoProduto.Text, lbDescricaoProduto.Text, 2), 
                data, 
                Convert.ToInt32(tbQuantidadeProduto.Text),
                varIdPedido);
        }
    }
}
