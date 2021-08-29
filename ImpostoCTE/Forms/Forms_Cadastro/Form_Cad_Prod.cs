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
    public partial class Form_Cad_Prod : MetroSetForm
    {
        public Form_Cad_Prod()
        {
            InitializeComponent();
        }

        private void btCadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCodigo.Text == string.Empty)
                {
                    Operacoes.validator(tbCodigo, "Preencha o Código");
                    return;
                }

                if (tbDescricao.Text == string.Empty)
                {
                    Operacoes.validator(tbDescricao, "Preencha a Descrição", tbCodigo);
                    return;
                }

                if (tbPreco.Text == string.Empty)
                {
                    Operacoes.validator(tbPreco, "Preencha o Preço", tbDescricao);
                    return;
                }

                if (tbIpi.Text == string.Empty)
                {
                    Operacoes.validator(tbIpi, "Preencha o IPI", tbPreco);
                    return;
                }

                if (tbEstoque.Text == string.Empty)
                {
                    Operacoes.validator(tbIpi, "Preencha o Estoque", tbIpi);
                    return;
                }

                Insert.insertBancoProduto(tbCodigo.Text,
                tbDescricao.Text,
                Convert.ToDouble(tbPreco.Text),
                Convert.ToInt16(tbIpi.Text),
                Convert.ToInt32(tbEstoque.Text));

                limparTextBox();
            } catch(Exception)
            {
                
            }
        }

        private void noTextOnTextBox(object sender, KeyPressEventArgs e)
        {
            Operacoes.impedirLetrasTextBox(sender, e);
        }

        private void limparTextBox()
        {
            lbResultado.Text = "Sucesso";
            tbCodigo.Text = string.Empty;
            tbDescricao.Text = string.Empty;
            tbPreco.Text = string.Empty;
            tbIpi.Text = string.Empty;
            tbEstoque.Text = string.Empty;
        }

    }
}
