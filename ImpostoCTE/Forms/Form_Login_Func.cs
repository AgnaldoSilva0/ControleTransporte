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
            //Senha teste, ainda falta implementar armazenamento
            if (tbUsuario.Text.ToUpper() == "AGNALDO" && tbSenha.Text == "1234")
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
