using ImpostoCTE.BancoDado;
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
    public partial class Form_Cad_Frete : MetroSetForm
    {
        public Form_Cad_Frete()
        {
            InitializeComponent();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string data = dtData.Text;
                int cte = Convert.ToInt32(tbCte.Text);
                int mdfe = Convert.ToInt32(tbMdfe.Text);
                string veiculo = cbVeiculo.Text;
                string placa = tbPlaca.Text;
                string cidade = tbCidade.Text;
                string tomador = cbTomador.Text;
                double valorFrete = Convert.ToDouble(tbValorFrete.Text);
                string observacao = tbObservacao.Text;
                Insert.inserirFrete(data, cte, mdfe, veiculo, placa, cidade, tomador, valorFrete, observacao);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Um dos campos está vazio");
            }
        }
    }
}
