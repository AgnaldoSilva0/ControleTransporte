using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE
{
    public partial class Form1
    {
        public static void alterarCor(Label labelImposto, Label labelAtivado, CheckBox checkBox)
        {
            if (checkBox.Checked == true)
            {
                labelImposto.ForeColor = Color.FromArgb(26, 229, 190);
                labelAtivado.ForeColor = Color.FromArgb(26, 229, 190);
                labelAtivado.Text = "Ativado";
            }
            else
            {
                labelImposto.ForeColor = Color.FromArgb(93, 93, 91);
                labelAtivado.ForeColor = Color.FromArgb(93, 93, 91);
                labelAtivado.Text = "Desativado";
            }
        }

        
    }
}
