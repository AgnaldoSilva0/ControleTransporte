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
    public partial class Form_Edit_Func : MetroFramework.Forms.MetroForm
    {
        public Form_Edit_Func()
        {
            InitializeComponent();
        }

        public Form_Edit_Func(int id, string nome, string telefone, double salarioSemanal, string funcao)
        {
            InitializeComponent();
            tbNomeFunc.Text = nome;
            tbIdFunc.Text = Convert.ToString(id);
            tbTelefoneFunc.Text = telefone;
            tbSalarioFunc.Text = Convert.ToString(salarioSemanal);
            tbFuncaoFunc.Text = funcao;
        }

        private void btEditFunc_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.editarFunc(Convert.ToInt32(tbIdFunc.Text), 
                tbNomeFunc.Text, 
                tbTelefoneFunc.Text, 
                Convert.ToDouble(tbSalarioFunc.Text),
                tbFuncaoFunc.Text
                );

            this.Close();
        }

        private void ImpedirLetrasTextBox(object sender, KeyPressEventArgs e)
        {
            Operacoes.impedirLetrasTextBox(sender, e);
        }
    }
}
