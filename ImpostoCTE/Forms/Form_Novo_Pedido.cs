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
    public partial class Form_Novo_Pedido : MetroFramework.Forms.MetroForm
    {
        public Form_Novo_Pedido()
        {
            InitializeComponent();
            preencherComboBoxCliente();
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            //Pedido.idClienteRef 
            Pedido.idOrcamentoRef = Convert.ToInt32(tbIdOrcamento.Text);
            Pedido.nomeClienteRef = cbCliente.Text;
            Pedido.placaRef = tbPlaca.Text;
            Pedido.veiculoRef = tbVeiculo.Text;
            Pedido.dataRef = dtData.Text;
            this.Close();
        }

        private void preencherComboBoxCliente()
        {
            Pesquisar pesquisar = new Pesquisar();
            pesquisar.preencherTabelaCliente();

            foreach(Cliente cliente in Listas.listCliente) {
                cbCliente.Items.Add(cliente.Nome);
            }
        }

    }
}
