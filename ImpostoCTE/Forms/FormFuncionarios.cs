﻿using ImpostoCTE.BancoDado;
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
                }

            }
            
            
            //Funcionario detalhes = (Funcionario)Pesquisar.detalhesFrete(Convert.ToInt32(listViewFunc.SelectedItems[0].SubItems[1].Text));
            
        }
    }
}
