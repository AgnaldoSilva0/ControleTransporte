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
        }

        private void btPesquisarProduto_Click(object sender, EventArgs e)
        {

        }

        private void btAlterarCliente_Click(object sender, EventArgs e)
        {
            Form_Edit_Cliente_Pedido form_Edit_Pedido = new Form_Edit_Cliente_Pedido();
            form_Edit_Pedido.ShowDialog();
        }

        private void btFecharTelaPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdicionarProduto_Click(object sender, EventArgs e)
        {
            Timer Tempo = new Timer();
            Tempo.Interval = 2000;
            Tempo.Tick += new EventHandler(tempoLabelAlteracao_Tick);
            Tempo.Start();
        }

        private void tempoLabelAlteracao_Tick(object sender, EventArgs e)
        {
            if (lbEstoqueAlterado.Text == "...")
            {
                lbEstoqueAlterado.Text = "Estoque Alterado";
            }
            else
            {
                lbEstoqueAlterado.Text = "...";
            }
        }
    }
}
