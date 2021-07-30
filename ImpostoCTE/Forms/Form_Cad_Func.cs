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
                Insert.insertBancoFuncionario(Convert.ToInt32(tbIdFunc.Text),
                tbNomeFunc.Text,
                Convert.ToDouble(tbSalarioFunc.Text),
                tbAdmissaoFunc.Text,
                tbTelefoneFunc.Text);

                tbIdFunc.Text = string.Empty;
                tbNomeFunc.Text = string.Empty;
                tbSalarioFunc.Text = string.Empty;
                tbAdmissaoFunc.Text = string.Empty;
                tbTelefoneFunc.Text = string.Empty;
                MessageBox.Show(tbNomeFunc.Text + "Cadastrado");
                lbRegistroInserido.Text = "Último Registo inserio: " + tbNomeFunc.Text;
            } catch (Exception ex)
            {
                MessageBox.Show("Campo Vazio");
            }
            
        }

        private void impedirLetrasTextBox(object sender, KeyPressEventArgs e)
        {
            Operacoes.impedirLetrasTextBox(sender, e);
        }

    }
}
