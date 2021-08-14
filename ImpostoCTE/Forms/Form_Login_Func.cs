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
    public partial class Form_Login_Func : Form
    {
        public Form_Login_Func()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Pesquisar pesquisar = new Pesquisar();
            if (pesquisar.verificarSenhaFunc(tbUsuario.Text.ToUpper(), tbSenha.Text) == true)
            {
                FormFuncionarios formFuncionarios = new FormFuncionarios();
                formFuncionarios.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário Invalido");
            }
        }
    }
}
