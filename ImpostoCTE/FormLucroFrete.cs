using System;
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
    public partial class FormLucroFrete : Form
    {
        public FormLucroFrete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCalcularLucro_Click(object sender, EventArgs e)
        {
            double valorFrete = Convert.ToDouble(tbValorFreteLucro.Text);
            double imposto = Convert.ToDouble(tbImpostoLucro.Text);
            double diaria = Convert.ToDouble(tbDiariaLucro.Text);
            double combustivel = Convert.ToDouble(tbCombustivelLucro.Text);
            double outrasDespesas = Convert.ToDouble(tbOutrasDespesasLucro.Text);
            Operacoes.calcularLucroFrete(valorFrete, imposto, diaria, combustivel, outrasDespesas);
            lbValorTotalLucro.Text = Convert.ToString(Operacoes.calcularLucroFrete(valorFrete, imposto, diaria, combustivel, outrasDespesas));
        }

        private void impedirLetrasTextBox(object sender, KeyPressEventArgs e)
        {
            Operacoes.impedirLetrasTextBox(sender, e);
        }

    }
}
