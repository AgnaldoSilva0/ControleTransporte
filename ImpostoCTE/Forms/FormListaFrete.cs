using ImpostoCTE.BancoDado;
using ImpostoCTE.Model;
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
    public partial class FormListaFrete : Form
    {
        public FormListaFrete()
        {
            InitializeComponent();
            Pesquisar.preencherTabelaFrete();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            listViewFrete.Items.Clear();
            Pesquisar.preencherTabelaFrete();
            foreach (var item in Listas.listFrete)
            {
                if (item.Tomador.IndexOf(tbPesquisarFrete.Text, StringComparison.OrdinalIgnoreCase) >= 0 || item.Data.IndexOf(tbPesquisarFrete.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listViewFrete.Items.Add(new ListViewItem(new string[] { item.Data, Convert.ToString(item.Cte), item.Tomador, "R$ " + Convert.ToString(item.ValorFrete) }));
                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Delete.deletarFrete(Convert.ToInt32(listViewFrete.SelectedItems[0].SubItems[1].Text));
            } catch (Exception ex)
            {
                MessageBox.Show("Selecione um item para exclusão");
            }
        }

        private void listViewFrete_MouseClick(object sender, MouseEventArgs e)
        {
            //Precisa fazer (Frete) para converter o metodo em objeto
            Frete detalhes = (Frete)Pesquisar.detalhesFrete(Convert.ToInt32(listViewFrete.SelectedItems[0].SubItems[1].Text));
            lbPlaca.Text ="Placa " + detalhes.Placa;
            lbData.Text = "Data: " + detalhes.Data;
            lbCte.Text = "Cte: " +Convert.ToString(detalhes.Cte);
            lbTomador.Text = "Tomador: " + detalhes.Tomador;
            lbMdfe.Text = "Mdfe: " + Convert.ToString(detalhes.Mdfe);
            lbValor.Text = "Valor: R$ " + Convert.ToString(detalhes.ValorFrete);
            lbObservacao.Text = "OBS: " + detalhes.Observacao;
            lbCidade.Text = "Cidade: " + detalhes.Cidade;
            lbVeiculo.Text = "Veiculo: " + detalhes.Veiculo;
        }

        private void btCadastrarFrete_Click(object sender, EventArgs e)
        {
            Form_Cad_Frete formCadFrete = new Form_Cad_Frete();
            formCadFrete.ShowDialog();
        }
    }
}
