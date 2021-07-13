using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpostoCTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        #region Customização Botão
        private void customizeDesign()
        {
            panelSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu);
        }

        private Form activeForm = null;
        private void openChieldForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        #region MudarCorImpostosCheckBox
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            alterarCor(lbIcms, lbIcmsAtivado, checkBox5);
         }

        private void cbPis_CheckedChanged(object sender, EventArgs e)
        {
            alterarCor(lbPis, lbPisAtivado, cbPis);
        }

        private void cbCofins_CheckedChanged(object sender, EventArgs e)
        {
            alterarCor(lbCofins, lbCofinsAtivado, cbCofins);
        }

        private void cbImpTrim_CheckedChanged(object sender, EventArgs e)
        {
            alterarCor(lbImpTri, lbIrtAtivado, cbImpTrim);
        }

        private void cbConSocial_CheckedChanged(object sender, EventArgs e)
        {
            alterarCor(lbConSocial, lbCsAtivado, cbConSocial);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox6.ForeColor = Color.FromArgb(26, 229, 190);
            }
            else
            {
                checkBox6.ForeColor = Color.FromArgb(93, 93, 91);
            }
        }

        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            Impostos imp = new Impostos();
            imp.ValorFrete = Convert.ToDouble(mtbValorFrete.Text);

            lbIcmsResult.Text = "R$ " + Convert.ToString(imp.Icms);
            lbPisResult.Text = "R$ " + Convert.ToString(imp.Pis);
            lbCofinsResult.Text = "R$ " + Convert.ToString(imp.Cofins);
            lbIrtResult.Text = "R$ " + Convert.ToString(imp.ImpTri);
            lbCsResult.Text = "R$ " + Convert.ToString(imp.ConSocial);

            if (checkBox6.Checked == true)
            {
                double icms = imp.Icms - (imp.Icms * 20 / 100);
                lbIcmsResult.Text = "R$ " + Convert.ToString(icms);
                lbValorTotalImpostos.Text = "R$ " + Convert.ToString(Operacoes.calcularTotalImposto(icms, imp.Pis, imp.Cofins, imp.ImpTri, imp.ConSocial));
                lbDescontoAviso.Text = "Desconto aplicado no valor total";
                lbDescontoAviso.ForeColor = Color.FromArgb(26, 229, 190);

                return;
            }

            lbValorTotalImpostos.Text = "R$ " + Convert.ToString(Operacoes.calcularTotalImposto(imp.Icms, imp.Pis, imp.Cofins, imp.ImpTri, imp.ConSocial));
            lbDescontoAviso.Text = "Desconto não aplicado no valor total";
            lbDescontoAviso.ForeColor = Color.FromArgb(93, 93, 91);
        }

        private void mtbValorFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacoes.impedirLetrasTextBox(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChieldForm(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChieldForm(new FormLucroFrete());
        }


    }

   


}
