using ImpostoCTE.BancoDado;
using ImpostoCTE.Model;
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
    public partial class FormFuncionarios : MetroFramework.Forms.MetroForm
    {
        public FormFuncionarios()
        {
            InitializeComponent();
            listViewFunc.Columns.Remove(clmSalario);
            
        }

        private void btCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Form_Cad_Func formCadFuncionario = new Form_Cad_Func();
            //Dialog pq bloqueia a tela principal, só desbloqueia após fechar o form
            formCadFuncionario.ShowDialog();
        }

        private void btCadastrarFunc_Click(object sender, EventArgs e)
        {
            Form_Cad_Func form_Cad_Func = new Form_Cad_Func();
            form_Cad_Func.ShowDialog();
        }

        private void btPesquisarFunc_Click(object sender, EventArgs e)
        {
            listViewFunc.Columns.Add(clmSalario);
            listViewFunc.Items.Clear();
            Pesquisar.pesquisarFuncionario();
            foreach (var item in Listas.listFuncionario)
            {
                if (item.Nome.IndexOf(tbPesquisarFun.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listViewFunc.Items.Add(new ListViewItem(new string[] { Convert.ToString(item.Id),
                        Convert.ToString(item.Nome), item.Telefone, Convert.ToString(item.SalarioSemanal) }));
                }
            }
        }

        private void listViewFunc_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var item in Listas.listFuncionario)
            {
                if(item.Id == Convert.ToInt32(listViewFunc.SelectedItems[0].SubItems[0].Text))
                {
                    lbAdmissaoClick.Text = item.Admissao;
                    lbFuncao.Text = item.Funcao;
                }

            }
            
            
            //Funcionario detalhes = (Funcionario)Pesquisar.detalhesFrete(Convert.ToInt32(listViewFunc.SelectedItems[0].SubItems[1].Text));
            
        }

        private void listViewFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(listViewFunc.SelectedItems[0].SubItems[0].Text);
            string nome = listViewFunc.SelectedItems[0].SubItems[1].Text;
            string telefone = listViewFunc.SelectedItems[0].SubItems[2].Text;
            double salarioSemanal = Convert.ToDouble(listViewFunc.SelectedItems[0].SubItems[3].Text);
            string funcao = lbFuncao.Text;
            Form_Edit_Func form_Edit_Func = new Form_Edit_Func(id, nome, telefone, salarioSemanal, funcao);
            form_Edit_Func.ShowDialog();
        }
    }
}
