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

namespace ImpostoCTE.Forms.Forms_Cadastro
{
    public partial class Form_Cad_Cliente : MetroSet_UI.Forms.MetroSetForm
    {
        public Form_Cad_Cliente()
        {
            InitializeComponent();
        }

        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (tbNomeCliente.Text == string.Empty)
            {
                MessageBox.Show("Preenchar o nome");
                tbNomeCliente.Focus();
                return;
            }
            if (tbNumeroCliente.Text == string.Empty)
            {
                tbNumeroCliente.Text = "NULL";
            }
            Insert insert = new Insert();
            insert.insertBancoCliente(tbNomeCliente.Text, tbNumeroCliente.Text);
        }
    }
}
