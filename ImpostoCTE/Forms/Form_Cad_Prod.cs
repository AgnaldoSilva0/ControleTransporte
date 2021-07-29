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
            Insert.insertBancoProduto(tbCodigo.Text, 
                tbDescricao.Text,
                Convert.ToDouble(tbPreco.Text), 
                Convert.ToInt16(tbIpi.Text));

            lbResultado.Text = "Sucesso";
        }

        private void noTextOnTextBox(object sender, KeyPressEventArgs e)
        {
            Operacoes.impedirLetrasTextBox(sender, e);
        }

    }
}
