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
    public partial class Form_Selecionar_Orcamento : MetroFramework.Forms.MetroForm
    {
        public Form_Selecionar_Orcamento()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Form_Novo_Pedido form_Novo_Pedido = new Form_Novo_Pedido();
            form_Novo_Pedido.ShowDialog();
            this.Close();
        }
    }
}
