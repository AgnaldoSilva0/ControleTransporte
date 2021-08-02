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
    public partial class FormFuncionarios : MetroSetForm
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
    }
}
