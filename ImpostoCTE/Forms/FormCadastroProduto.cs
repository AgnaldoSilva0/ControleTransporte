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
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btFecharForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrarProduto_Click(object sender, EventArgs e)
        {
            
            Insert.insertBancoProduto(tbCodigoCadastro.Text, tbDescricaoCadastro.Text, 
            Convert.ToDouble(tbPrecoCadastro.Text), Convert.ToInt16(tbIpiCadastro.Text));

            lbAvisoCadastro.Text = "Sucesso";
        }

        private void noTextOnTextBox(object sender, KeyPressEventArgs e)
        {
            Operacoes.impedirLetrasTextBox(sender, e);
        }

    }
}
