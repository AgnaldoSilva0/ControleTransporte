using ImpostoCTE.BancoDado;
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
    }
}
