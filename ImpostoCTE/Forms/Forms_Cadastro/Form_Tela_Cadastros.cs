using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE.Forms.Forms_Cadastro
{
    public partial class Form_Tela_Cadastros : Form
    {
        public Form_Tela_Cadastros()
        {
            InitializeComponent();
        }

        private void btCadastrarProduto_Click(object sender, EventArgs e)
        {
            Form_Cad_Prod form_Cad_Prod = new Form_Cad_Prod();
            form_Cad_Prod.ShowDialog();
        }

        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            Form_Cad_Cliente form_Cad_Cliente = new Form_Cad_Cliente();
            form_Cad_Cliente.ShowDialog();
        }

        private void btCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Form_Cad_Func form_Cad_Func = new Form_Cad_Func();
            form_Cad_Func.ShowDialog();
        }
    }
}
