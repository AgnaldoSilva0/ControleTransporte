using System;
using ImpostoCTE.BancoDado;
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
    public partial class Form_Selecionar_Orcamento : MetroFramework.Forms.MetroForm
    {
        public Form_Selecionar_Orcamento()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Form_Novo_Pedido form_Novo_Pedido = new Form_Novo_Pedido();
            form_Novo_Pedido.ShowDialog();
            this.Close();
        }

        private void btAbrirOrcamento_Click(object sender, EventArgs e)
        {

        }

        private void btPesquisarOrcamento_Click(object sender, EventArgs e)
        {
            listViewOrcamentos.Items.Clear();
            Pesquisar.preencherListaOrcamento();
            foreach (var item in Listas.listPedido)
            {
                if (Convert.ToString(item.IdCliente).IndexOf(tbPesquisarOrcamento.Text, StringComparison.OrdinalIgnoreCase) >= 0 || item.Placa.IndexOf(tbPesquisarOrcamento.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listViewOrcamentos.Items.Add(new ListViewItem(new string[] { Convert.ToString(item.IdPedido), Convert.ToString(item.IdCliente), Convert.ToString(item.Placa), Convert.ToString(item.Modelo) }));
                }
            }
        }
    }
}
