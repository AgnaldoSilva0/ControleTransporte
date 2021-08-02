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
    public partial class Form_Cad_Func : MetroSetForm
    {
        public Form_Cad_Func()
        {
            InitializeComponent();
        }

        private void btCadFunc_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbIdFunc.Text == string.Empty)
                {
                    validator(tbIdFunc, "Preencha o ID do Funcionário");
                    return;
                }

                if (tbSalarioFunc.Text == string.Empty)
                {
                    validator(tbSalarioFunc, "Preencha o Salário do Funcionário");
                    return;
                }

                if (tbAdmissaoFunc.Text == string.Empty)
                {
                    validator(tbAdmissaoFunc, "Preencha o Admissão do Funcionário");
                    return;
                }

                if (tbTelefoneFunc.Text == string.Empty)
                {
                    validator(tbTelefoneFunc, "Preencha o Telefone do Funcionário");
                    return;
                }

                if (tbNomeFunc.Text == string.Empty)
                {
                    validator(tbNomeFunc, "Preencha o Nome do Funcionário");
                    return;
                }

                Insert.insertBancoFuncionario(Convert.ToInt32(tbIdFunc.Text),
                tbNomeFunc.Text,
                Convert.ToDouble(tbSalarioFunc.Text),
                tbAdmissaoFunc.Text,
                tbTelefoneFunc.Text);
                limparTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campo Vazio");
            }

        }

        private void impedirLetrasTextBox(object sender, KeyPressEventArgs e)
        {
            Operacoes.impedirLetrasTextBox(sender, e);
        }

        private void validator(MetroSet_UI.Controls.MetroSetTextBox textBox, string label) 
        {
            textBox.BorderColor = Color.Red;
            textBox.Focus();
            MessageBox.Show(label);
        }

        private void limparTextBox()
        {
            tbIdFunc.Text = string.Empty;
            tbNomeFunc.Text = string.Empty;
            tbSalarioFunc.Text = string.Empty;
            tbAdmissaoFunc.Text = string.Empty;
            tbTelefoneFunc.Text = string.Empty;
            MessageBox.Show(tbNomeFunc.Text + "Cadastrado");
            lbRegistroInserido.Text = "Último Registo inserio: " + tbNomeFunc.Text;
        }

    }
}
